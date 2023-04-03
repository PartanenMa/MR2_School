//Tulostus ENTER-näppäimen avulla:
function onko_enter(event) {
  if (event.keyCode == 13) {
     tulosta();
  }
}

//Tulostaa asioita:
function tulosta() {
  document.getElementsByClassName("section_2_container")[0].style.display = "none"; //Piilottaa komennot.
  document.getElementsByClassName("section_3")[0].style.backgroundImage = "none"; //Piilottaa imagen.
  document.getElementById("canvas").style.display = "none"; //Piilottaa canvaksen.
  document.body.style.backgroundColor = "black"; //Palauttaa alkuperäisen bodyn taustavärin.
  var komento = "listaa"; //Oletuskomentona "listaa".
  if(document.getElementById("text_field").value != "") { //Jos tekstikenttä ei ole tyhjä, oletuskomento ylikirjoitetaan.
      komento = document.getElementById("text_field").value;
  }
  var vasen = document.getElementById("vasen_teksti");
  var oikea = document.getElementById("oikea_teksti");
  var popup = document.getElementById("ilmestynyt");
  var nappi = document.getElementById("sulje_div");
  var oikea_input = document.getElementById("oikea_tekstikentta");
  var oikea_input_nappi = document.getElementById("suorita");
  vasen.style.display = "none";
  oikea.style.display = "none";
  popup.style.display = "none";
  nappi.style.display = "none";
  oikea_input.style.display = "none";
  oikea_input_nappi.style.display = "none";
  while(true) {
      //1. komento "google":
      if(komento == "google") { 
          oikea.innerHTML = "Siirrytäänkö googleen?";
          oikea.style.display = "block";
          break;
      //2. komento "listaa":
      }else if(komento == "listaa") {
          document.getElementsByClassName("section_2_container")[0].style.display = "block";
          break;
      //3. komento "oma nimi":
      }else if(komento == "manu") {
          document.getElementsByClassName("section_3")[0].style.backgroundImage = "url(apina.jpg)";
          break;
      //4. komento "numero väliltä 1-999":
      }else if(komento >= 1 || komento <= 999) {
          const sanoja = [];
          for(var i1 = 0; i1 < komento; i1++) {
            var sana = "";
            var aakkoset = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,r,s,t,u,v,w,x,y,z".split(",");
            var sanamaara = 256;
            for(var i = 0; i < sanamaara; i++) {
              var random = null;
              for (var x = 0; x < 7; x++) {
                random = Math.floor(Math.random() * aakkoset.length);
                sana += aakkoset[rand];
              }
              if (i < sanamaara - 1)
                sana += " ";
              else
                sana += ".";
            }
            sanoja.push(sana);
          }
          var teksti = "";
          var numero = 1;
          for(var i2 = 0; i2 < komento; i2++) {
            teksti = teksti + numero + ". " + sanoja[i2] + "<br>";
            document.getElementById("sanat").innerHTML = teksti;
            document.getElementById("sanat").style.display = "block";
            numero++;
          }
          break;
      //5. komento "piirrä":
      }else if(komento == "piirrä") {
          var ympyra = document.getElementById("canvas");
          var konteksti = ympyra.getContext("2d");
          konteksti.beginPath();
          konteksti.arc(100, 75, 50, 0, 2 * Math.PI);
          konteksti.stroke();
          document.getElementById("canvas").style.display = "block";
          break;
      //6. komento "tee popup":
      }else if(komento == "tee popup") {
          var lihavoitava = "pyydetty"
          var lihavoitu = lihavoitava.bold();
          var eka = "Tässä ";
          var toka = lihavoitu;
          var kolmas = " popup";
          var kokonainen = eka.concat(toka, kolmas);
          popup.innerHTML = kokonainen;
          popup.style.display = "block";
          nappi.style.display = "block";
          break;
      //7. komento "vaihda":
      }else if(komento == "vaihda") {
          document.body.style.backgroundColor = "red";
          break;
      //8. komento "funktio":
      }else if(komento == "funktio") {
          funktio1();
          break;
      //Tuntematon komento:
      }else{
          oikea.innerHTML = "Komentoa ei tunnistettu!";
          oikea.style.display = "block";
          break;
      }
  }
}

//Siirtyy googleen:
function google() {
  var teksti = document.getElementById("oikea_teksti");
  if(teksti.innerHTML == "Siirrytäänkö googleen?") {
    window.open("https://www.google.com/");
  }
}

//Printtaa oikean komennon tekstikenttään:
function komento_tekstikenttaan(komento) {
  if(komento == "komento_1") {
    document.getElementById("text_field").value = "google";
    document.getElementById("print").click();
  }else if(komento == "komento_2") {
    document.getElementById("text_field").value = "listaa";
    document.getElementById("print").click();
  }else if(komento == "komento_3") {
    document.getElementById("text_field").value = "manu";
    document.getElementById("print").click();
  }else if(komento == "komento_4") {
    document.getElementById("text_field").value = "1";
    document.getElementById("print").click();
  }else if(komento == "komento_5") {
    document.getElementById("text_field").value = "piirrä";
    document.getElementById("print").click();
  }else if(komento == "komento_6") {
    document.getElementById("text_field").value = "tee popup";
    document.getElementById("print").click();
  }else if(komento == "komento_7") {
    document.getElementById("text_field").value = "vaihda";
    document.getElementById("print").click();
  }else if(komento == "komento_8") {
    document.getElementById("text_field").value = "funktio";
    document.getElementById("print").click();
  }
}

//Sulkee "ilmestynyt" divin:
function sulje_div() {
  var popup = document.getElementById("ilmestynyt");
  var nappi = document.getElementById("sulje_div");
  popup.style.display = "none";
  nappi.style.display = "none";
}

//Tulostus ENTER-näppäimen avulla uudella tekstikentällä:
function onko_enter_uusi(event) {
  if (event.keyCode == 13) {
     funktio2();
  }
}

//Toteutuu "funktio" komennon johdosta:
function funktio1() {  
  console.log("Funktio toimii!");
  document.getElementById("oikea_tekstikentta").style.display = "block";
  document.getElementById("suorita").style.display = "block"; 
}

//"Suorita" nappi ja ENTER-näppäin kutsuvat tätä funktiota:
function funktio2() {
  var suorita_komento = document.getElementById("oikea_tekstikentta").value;
  if(suorita_komento == "") {
    console.log("Anna komento!");
  }else if(suorita_komento == "reload") {
    location.reload();
  }else{
    console.log("Kirjoitit: " + document.getElementById("oikea_tekstikentta").value);
  }
}

