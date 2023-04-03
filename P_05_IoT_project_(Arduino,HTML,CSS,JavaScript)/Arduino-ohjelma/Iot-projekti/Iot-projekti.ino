#include <ArduinoJson.h>
#include <ArduinoJson.hpp>

// REQUIRES the following Arduino libraries:
// - DHT Sensor Library: https://github.com/adafruit/DHT-sensor-library
// - Adafruit Unified Sensor Lib: https://github.com/adafruit/Adafruit_Sensor
// - Adafruit SSD1306

//dht11
#include "DHT.h"

//oled
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

//servo
#include <Servo.h>

//wifi
#include <SPI.h>
#include <WiFiNINA.h>

#include "secrets/secrets.h"

char ssid[] = SECRET_SSID;  // your network SSID (name)
char pass[] = SECRET_PASS;  // your network password (use for WPA, or use as key for WEP)

char servername[] = SECRET_SERVERNAME;
int serverport = 8080;

int wifistatus = WL_IDLE_STATUS;  // the WiFi radio's status
WiFiClient client;

bool offline_mode = false;  // for testing...


//oled
#define SCREEN_WIDTH 128     // OLED display width, in pixels
#define SCREEN_HEIGHT 64     // OLED display height, in pixels
#define OLED_RESET -1        // Reset pin # (or -1 if sharing Arduino reset pin)
#define SCREEN_ADDRESS 0x3C  ///< See datasheet for Address; 0x3D for 128x64, 0x3C for 128x32
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

//servo
Servo myservo;
int servo_pos = 0;  // current servo pos


//dht11
#define DHTPIN 2
#define DHTTYPE DHT11  // DHT 11
DHT dht(DHTPIN, DHTTYPE);

//global variables
bool logger_on = true;
float temperature = -1.0;  //current
float humidity = -1.0;     //current
float wants_temp = -99;    //the temp we are trying to achieve
float wants_humidity = -99;
bool override_temp = false;
float min_temp = 17;
float max_temp = 25;
int h2s;  // humidity to servo state
int t2s;  // temperature to servo state
char heating_state='n';

//servo position to set when cooling down // configure this!
int coolingPosition = 0;

//same but heating up  // configure this!
int heatingPosition = 90;


//Local json object to save sensor data into
//["temperature"]
//["humidity"]
const size_t capacity_sdj = JSON_OBJECT_SIZE(2);
DynamicJsonDocument sensor_data_json(capacity_sdj);



//----------------------------------------------------------------------------

String IpAddress2String(const IPAddress &ipAddress) {
    return String(ipAddress[0]) + String(".") + String(ipAddress[1]) + String(".") + String(ipAddress[2]) + String(".") + String(ipAddress[3]);
}

String getlocalip() {
    IPAddress localip = WiFi.localIP();
    return IpAddress2String(localip);
}

String getgatewayip() {
    IPAddress gatewayip = WiFi.gatewayIP();
    return IpAddress2String(gatewayip);
}



void logger(String text) {
    if (logger_on == true) {
        Serial.println(text);
    }
}
void loggersl(String text) {
    if (logger_on == true) {
        Serial.print(text);
    }
}

//---------------------------------------------------------------

//call this to connect wifi.
void wifi_init() {
    // check for the WiFi module:
    if (WiFi.status() == WL_NO_MODULE) {
        logger("Communication with WiFi module failed!");
        // don't continue
    } else {
        String fv = WiFi.firmwareVersion();
        if (fv < WIFI_FIRMWARE_LATEST_VERSION) {
            logger("Please upgrade the firmware");
        }

        wifi_connect();
        delay(500);


        //keep connecting until success
        unsigned long TIME = millis();
        while (WiFi.status() != WL_CONNECTED) {
            if (millis() - TIME > 10000L) {
                wifi_connect();
                TIME = millis();
            }
        }
        logger("Wifi connection to Access Point " + String(WiFi.SSID()) + " succesful.");
        logger("Local IP: " + getlocalip());
        logger("Remote IP: " + getgatewayip());
        // print your MAC address:
        byte mac[6];
        WiFi.macAddress(mac);
        logger("MAC address: ");
        printMacAddress(mac);

        pingServer();
    }
}

// only used with wifi_init()
void wifi_connect() {
    // attempt to connect to WiFi network:
    if (WiFi.status() != WL_CONNECTED) {
        loggersl("Attempting to connect to WPA SSID: ");
        logger(ssid);
        // Connect to WPA/WPA2 network:
        wifistatus = WiFi.begin(ssid, pass);
        //delay handled elsewhere
    }
}

void display_sensor_data() {
    display.clearDisplay();
    display.setCursor(0, 0);
    display.println(String(temperature) + " C");
    display.println(String(humidity) + " %");
    display.println("Tgt:" + String(wants_temp) + " C");
    //display.println("Servo:" + String(myservo.read()));
    if (heating_state == 'c') {
        display.println("Cooling...");
    } else if (heating_state == 'h') {
        display.println("Heating...");
    }
    display.display();
}

int read_sensor_data() {
    //humidity 0-100
    float hNow = dht.readHumidity();

    // Read temperature as Celsius (the default)
    float tNow = dht.readTemperature();

    bool update_display = false;

    // Check if any reads failed and exit early (to try again).
    if (isnan(hNow) || isnan(tNow)) {
        logger(F("Failed to read from DHT sensor!"));
        return -1;
    } else {
        if (tNow != temperature) {
            temperature = tNow;
            update_display = true;
        }

        if (hNow != humidity) {
            humidity = hNow;
            update_display = true;
        }
    }
    if (update_display) {
        return 0;
    }
    return 1;
}

int update_targets() {
    //What are the temperature targets?
    //Min, Max, Single target?
    float targ_temperature = -99;
    float targ_humidity = -99;


    //check connection
    if (WiFi.status() != WL_CONNECTED) {
        //ERROR
        logger("update_targets: WIFI NOT CONNECTED!");
        return -1;
    }


    logger(F("Connecting..."));

    if (!client.connect(servername, serverport)) {
        logger("update_targets: Client not connected.");
        return -1;
    }

    logger("update_targets: Client connected.");

    // Send HTTP request
    client.println(F("GET /api/targets HTTP/1.0"));
    client.println("Host: " + String(servername));
    client.println(F("Connection: close"));
    if (client.println() == 0) {
        logger("update_targets: Failed to send request");
        client.stop();
        return -1;
    }

    // Check HTTP status
    /*
    char status[32] = { 0 };
    client.readBytesUntil('\r', status, sizeof(status));
    // It should be "HTTP/1.0 200 OK" or "HTTP/1.1 200 OK"
    if (strcmp(status + 9, "200 OK") != 0) {
      loggersl("Unexpected response: ");
      logger(status);
      client.stop();
      return -1;
    }*/

    // Skip HTTP headers
    char endOfHeaders[] = "\r\n\r\n";
    if (!client.find(endOfHeaders)) {
        logger("Invalid response");
        client.stop();
        return -1;
    }



    // Allocate the JSON document
    // Use https://arduinojson.org/v6/assistant to compute the capacity.
    const size_t capacity = JSON_OBJECT_SIZE(2) + JSON_ARRAY_SIZE(2) + 60;
    //const size_t capacity = JSON_OBJECT_SIZE(4);
    DynamicJsonDocument json_response(capacity);

    // Parse JSON object
    DeserializationError error = deserializeJson(json_response, client);
    if (error) {
        loggersl("deserializeJson() failed: ");
        logger(error.f_str());
        client.stop();
        return -1;
    }
    // Disconnect
    client.stop();
    loggersl("target json response: ");
    serializeJson(json_response, Serial);
    logger("");


    targ_temperature = json_response["targets_json"]["temperature_target"];
    targ_humidity = json_response["targets_json"]["humidity_target"];


    wants_temp = targ_temperature;
    wants_humidity = targ_humidity;


    return 0;
}


int upload_data(char *host, int port) {
    if (WiFi.status() == WL_CONNECTED) {
        //logger("upload_data: WiFi is connected.");
        if (client.connect(host, serverport)) {

            logger("Connected " + String(host) + ":" + port);
            logger("Making request...");
            String sensor_data_string;
            serializeJson(sensor_data_json, sensor_data_string);
            logger("Data: " + sensor_data_string);
            client.println("POST /api/upload HTTP/1.1");
            client.println("Host: " + String(host));
            client.println("Content-Type: application/json;charset=UTF-8");
            client.print("Content-Length: ");
            client.println(measureJson(sensor_data_json));
            client.println();
            serializeJson(sensor_data_json, client);
        } else {
            logger("SERVER CONNECTION FAILED!!!");
        }


        if (client.connected()) {
            logger("\ndisconnecting from server.");
            client.stop();
        }
    } else {
        logger("upload_data: WiFi NOT CONNECTED.");
    }
    return -1;
}

void setup() {
    Serial.begin(9600);

    if (!offline_mode) {
        wifi_init();
    }

    //dht11
    dht.begin();

    //servo
    myservo.attach(9);

    //OLED
    // SSD1306_SWITCHCAPVCC = generate display voltage from 3.3V internally
    if (!display.begin(SSD1306_SWITCHCAPVCC, SCREEN_ADDRESS)) {
        logger("SSD1306 allocation failed");
        for (;;)
            ;  // Don't proceed, loop forever
    }
    display.clearDisplay();
    display.setTextSize(2);
    display.setTextColor(WHITE);
    display_sensor_data();


    sensor_data_json["temperature"] = "-99";
    sensor_data_json["humidity"] = "-99";
}




void react_toohot() {
    int curpos = myservo.read();
    logger(String(curpos));
    if (curpos != coolingPosition) {
        myservo.write(coolingPosition);
        heating_state = 'c';
    }
}

void react_toocold() {
    int curpos = myservo.read();
    logger(String(curpos));
    if (curpos != heatingPosition) {
        myservo.write(heatingPosition);
        heating_state = 'h';
    }
}

void servoStateHandler() {
    int h2sNow = map(humidity, 40, 95, 0, 180);
    int t2sNow = map(temperature, min_temp, max_temp, heatingPosition, coolingPosition);

    if (h2sNow != h2s) {
        //new values. set servo state.
        h2s = h2sNow;
    }

    if (t2sNow != t2s) {
        t2s = t2sNow;
    }
}



//unsigned long TIME_SINCE_ACTION_TAKEN = 0;
//unsigned long LAST_ACTION_TIME = 0;
unsigned long SENSOR_UPDATE_DELAY = 5000;  // 5 seconds.
unsigned long LAST_SENSOR_UPDATE_TIME = 0;

unsigned long TARGET_UPDATE_DELAY = 10000;
unsigned long LAST_TARGET_UPDATE_TIME = 0;

float react_sensitivity_delta = 0.1;
void loop() {

    // check if enough time has passed for us to get new measurements.
    //...
    unsigned long TIME = millis();


    if (TIME - LAST_TARGET_UPDATE_TIME >= TARGET_UPDATE_DELAY || LAST_TARGET_UPDATE_TIME == 0) {

        //check connection
        if (WiFi.status() != WL_CONNECTED) {
            //ERROR
            logger("WIFI NOT CONNECTED! Attempting to reconnect.");
            wifi_init();
        } else {
            update_targets();
            LAST_TARGET_UPDATE_TIME = TIME;
        }
    }

    if (TIME - LAST_SENSOR_UPDATE_TIME >= SENSOR_UPDATE_DELAY || LAST_SENSOR_UPDATE_TIME == 0) {
        logger("SENSOR_UPDATE...");
        // reads current temperature, saves value in 'temperature' global variable

        switch (read_sensor_data()) {
        case -1:
            //something went wrong!
            break;

        case 1:
            //read OK, but nothing was updated...
            logger("Current temp: " + String(temperature) + "°C");
            logger("Current humidity: " + String(humidity));
            LAST_SENSOR_UPDATE_TIME = TIME;
            break;

        case 0:
            LAST_SENSOR_UPDATE_TIME = TIME;
            //Read OK, and something was updated.
            logger("Current temp: " + String(temperature) + "°C");
            logger("Current humidity: " + String(humidity));
            sensor_data_json["temperature"] = temperature;
            sensor_data_json["humidity"] = humidity;
            display_sensor_data();
            servoStateHandler();
            break;

        default:
            //wtf?
            break;
        }
        if (temperature < wants_temp) {
            //if too far from targets, react accordingly
            if (abs(wants_temp - temperature) > react_sensitivity_delta) {
                react_toocold();
            }
        } else {
            if (abs(wants_temp - temperature) > react_sensitivity_delta) {
                react_toohot();
            }
        }



        loggersl("Target humidity: ");
        logger(String(wants_humidity));
        loggersl("Target temperature: ");
        logger(String(wants_temp));
        //upload new readings...
        if (WiFi.status() != WL_CONNECTED) {
            //ERROR
            logger("WIFI NOT CONNECTED! Attempting to reconnect.");
            wifi_init();
        }
        upload_data(servername, serverport);
    }
    //
}


//connectivity testing...
void pingServer() {
    int pingResult;
    loggersl("Pinging ");
    loggersl(servername);
    loggersl(": ");

    pingResult = WiFi.ping(servername);

    if (pingResult >= 0) {
        loggersl("SUCCESS! RTT = ");
        loggersl(String(pingResult));
        logger(" ms");
    } else {
        loggersl("FAILED! Error code: ");
        logger(String(pingResult));
    }
}

void printMacAddress(byte mac[]) {
    if (logger_on) {
        for (int i = 5; i >= 0; i--) {
            if (mac[i] < 16) {
                loggersl("0");
            }
            if (logger_on) {
                Serial.print(mac[i], HEX);
            }
            if (i > 0) {
                loggersl(":");
            }
        }
        logger("");
    }
}
