from pydantic import BaseModel
from typing import List, Dict, Union, Optional

class PlayerBase1(BaseModel):
    id: int
    name: str

class PlayerBase2(BaseModel):
    events: list

class PlayerBase3(BaseModel):
    name: str

class PlayerDB1(PlayerBase1):
    events: list

class PlayerDB2(PlayerBase3):
    id: int

class PlayerNew(PlayerBase3):
    id: int
    events: List[Dict[str, Union[int, str]]] = []

class EventBase(BaseModel):
    type: str
    detail: Optional[str] = None

class EventCreate(EventBase):
    timestamp: str

class PlayerEventCreate(EventCreate):
    player_id: int

class Event(EventCreate):
    id: int
    player_id: int

database = {
    "players": {},
    "events": [],
    "next_event_id": 1
}

players = [{"id": 0, "name": "player1", "events": [
            {
            "id": 0,
            "type": "level_started",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 12:01:22",
            "player_id": 0
            },
            {
            "id": 1,
            "type": "level_solved",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 15:01:52",
            "player_id": 0
            }
          ]},
           {"id": 1, "name": "player2", "events": [
            {
            "id": 0,
            "type": "level_started",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 12:01:43",
            "player_id": 1
            },
            {
            "id": 1,
            "type": "level_solved",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 13:01:47",
            "player_id": 1
            }
          ]},
           {"id": 2, "name": "player3", "events": [
            {
            "id": 0,
            "type": "level_started",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 12:03:32",
            "player_id": 2
            },
            {
            "id": 1,
            "type": "level_solved",
            "detail": "level_1212_001",
            "timestamp": "2023-01-13 14:03:56",
            "player_id": 2
            }
          ]}
]