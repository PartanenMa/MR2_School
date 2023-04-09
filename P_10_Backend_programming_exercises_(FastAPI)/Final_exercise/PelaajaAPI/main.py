#Imports:
from fastapi import FastAPI, status, HTTPException
from logic import get_player_index
from data import players, PlayerBase1, PlayerBase2, PlayerDB1, PlayerNew, EventBase
from typing import Optional

#App:
app = FastAPI()

#Endpoints:
@app.get("/players", response_model = list[PlayerBase1], status_code = status.HTTP_200_OK)
def get_players():
    if len(players) == 0:
        return []
    return players

@app.get("/players/{id}", response_model = PlayerDB1)
def get_player(id: int):
    player_id = get_player_index(id)
    return players[player_id]

@app.get("/players/{id}/events", response_model = list[EventBase], status_code = status.HTTP_200_OK)
def get_player_events(id: int, type: Optional[str] = None):
    player = next((p for p in players if p["id"] == id), None)
    if player is None:
        raise HTTPException(status_code = status.HTTP_404_NOT_FOUND, detail = "Player not found!")
    events = player.get("events", [])
    if type:
        if type not in ["level_started", "level_solved"]:
            raise HTTPException(status_code = status.HTTP_400_BAD_REQUEST, detail = "Unknown event type!")
        events = [e for e in events if e["type"] == type]
    return events

@app.get("/events", response_model = list[EventBase], status_code = status.HTTP_200_OK)
def get_events(type: Optional[str] = None):
    events = []
    for player in players:
        player_events = player.get("events", [])
        if type:
            if type not in ["level_started", "level_solved"]:
                raise HTTPException(status_code = status.HTTP_400_BAD_REQUEST, detail = "Unknown event type!")
            player_events = [e for e in player_events if e["type"] == type]
        events.extend(player_events)
    return events

@app.post("/players", response_model = PlayerNew, status_code = status.HTTP_201_CREATED)
def create_player(player: PlayerBase2):
    if not player.name:
        raise HTTPException(status_code = status.HTTP_422_UNPROCESSABLE_ENTITY, detail = "Player name cannot be empty!")
    player_id = max(p["id"] for p in players) + 1 if players else 0
    new_player = PlayerNew(id = player_id, name = player.name)
    players.append(new_player.dict())
    return new_player


@app.post("/players/{id}/events", status_code = status.HTTP_201_CREATED)
def create_player_event(id: int, event: EventBase):
    player = next((p for p in players if p["id"] == id), None)
    if player is None:
        raise HTTPException(status_code = status.HTTP_404_NOT_FOUND, detail = "Player not found!")
    if event.type not in ["level_started", "level_solved"]:
        raise HTTPException(status_code = status.HTTP_400_BAD_REQUEST, detail = "Unknown event type!")
    player.setdefault("events", []).append(event.dict())
    return None