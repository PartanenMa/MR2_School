from fastapi import FastAPI, status, HTTPException
from pydantic import BaseModel

app = FastAPI()

class ShoeBase(BaseModel):
    name: str

class ShoeDB(ShoeBase):
    id: int

shoes = [
    {"id": 0, "name": "Hoka"},
    {"id": 1, "name": "VJ Sport"},
]

def get_shoe_index(id):
    shoe_id = None
    for index, shoe in enumerate(shoes):
        if shoe["id"] == id:
            shoe_id = index
            break
    if shoe_id == None:
        raise HTTPException(status_code = 404, detail = f"Shoe with id {id} not found!")
    return shoe_id

@app.get("/shoes", response_model = list[ShoeDB])
def get_shoes(count: int = 10):
    return shoes[0:count]

@app.get("/shoes/{id}", response_model = ShoeDB)
def get_shoe(id: int):
    shoe_id = get_shoe_index(id)
    return shoes[shoe_id]

@app.post("/shoes", response_model = ShoeDB, status_code = status.HTTP_201_CREATED)
def create_shoe(shoe_in: ShoeBase):
    new_id = len(shoes)
    shoe = ShoeDB(**shoe_in.dict(), id = new_id)
    shoes.append(shoe.dict())
    return shoe

@app.delete("/shoes/{id}")
def delete_shoe(id: int):
    shoe_id = get_shoe_index(id)
    del shoes[shoe_id]
    return {"message": "Shoe deleted succesfully!"}