from fastapi import HTTPException
from data import players

def get_player_index(id):
    player_id = None
    for index, player in enumerate(players):
        if player["id"] == id:
            player_id = index
            break
    if player_id == None:
        raise HTTPException(status_code = 404, detail = "Player not found!")
    return player_id