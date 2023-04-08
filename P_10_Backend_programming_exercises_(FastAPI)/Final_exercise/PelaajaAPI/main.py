#Imports:
from fastapi import FastAPI, status, HTTPException
from logic import get_player_index
from data import players, PlayerBase1, PlayerBase2, PlayerBase3, PlayerDB1, PlayerDB2, PlayerNew, PlayerEventCreate, Event, database

#Creations:
app = FastAPI()

#Endpoints:
@app.get("/players", response_model = list[PlayerBase1]) #Returns the id and name all players.
def get_players():
    return players

@app.get("/players/{id}", response_model = PlayerDB1) #Returns all of the specific player's info.
def get_player(id: int):
    player_id = get_player_index(id)
    return players[player_id]

@app.get("/players/{id}/events", response_model = PlayerBase2) #Returns all of the specific player's events.
def get_player_events(id: int):
    player_id = get_player_index(id)
    return players[player_id]

@app.get("/events/{id}/{event_type}", response_model = PlayerBase2) #Returns all of the specific events of a specific player.
def get_player_specific_events(id: int, event_type: str):
    player = next((p for p in players if p["id"] == id), None)
    if player:
        event = next((e for e in player["events"] if e["id"] == id and e["type"] == event_type), None)
        if event:
            return {"events": [event]}
        else:
            raise HTTPException(status_code = 404, detail = "Event not found!")
    else:
        raise HTTPException(status_code = 404, detail = "Player not found!")

@app.get("/events", response_model = list[PlayerBase2]) #Returns all events.
def get_events():
    return players

@app.get("/events/{event_type}", response_model = list[PlayerBase2]) #Returns all events of a specific type.
def get_specific_events(event_type: str):
    specific_events = []
    for player in players:
        events = [event for event in player["events"] if event["type"] == event_type]
        if events:
            specific_events.append({"name": player["name"], "events": events})
    return specific_events

@app.post("/players", response_model = PlayerNew, status_code = status.HTTP_201_CREATED) #Creates a new player.
def create_player(player: PlayerBase3):
    #Check if a player with the same name already exists:
    if any(p["name"] == player.name for p in players):
        raise HTTPException(status_code = status.HTTP_422_UNPROCESSABLE_ENTITY, detail = "Player already exists!")
    #Create a new player with a unique id:
    player_id = max(p["id"] for p in players) + 1
    new_player = PlayerNew(id = player_id, name = player.name)
    #Add the new player to the players list:
    players.append(new_player.dict())
    #Return the newly created player:
    return new_player

@app.post("/players/{id}/events", status_code = status.HTTP_201_CREATED) #Creates a new event for a player.
def create_player_event(id: int, event: PlayerEventCreate):
    #Check if player exists:
    if id not in database["players"]:
        raise HTTPException(status_code = 404, detail = "Player not found!")
    #Check if event type is valid:
    valid_event_types = ["level_started", "level_solved"]
    if event.type not in valid_event_types:
        raise HTTPException(status_code = 400, detail = f"Invalid event type '{event.type}'")
    #Create new event object:
    new_event = Event(
        id=database["next_event_id"],
        player_id=id,
        type=event.type,
        detail=event.detail,
        timestamp=event.timestamp
    )
    #Add event to database:
    database["events"].append(new_event.dict())
    database["players"][id]["events"].append(new_event.dict())
    #Update next event id:
    database["next_event_id"] += 1
    #Return created event:
    return new_event.dict()