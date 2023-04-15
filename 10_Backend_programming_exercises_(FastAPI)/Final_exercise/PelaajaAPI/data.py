#Imports:
from pydantic import BaseModel
from typing import List, Dict, Union

#Classes:
class PlayerBase1(BaseModel):
    id: int
    name: str

class PlayerBase2(BaseModel):
    name: str

class PlayerDB1(PlayerBase1):
    events: List

class PlayerNew(PlayerBase2):
    id: int
    events: List[Dict[str, Union[int, str]]] = []

class EventBase(BaseModel):
    id: int
    type: str
    detail: str
    timestamp: str
    player_id: int

#Database:
players = []