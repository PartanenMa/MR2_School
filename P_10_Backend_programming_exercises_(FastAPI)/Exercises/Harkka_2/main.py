from fastapi import FastAPI, status, HTTPException
from pydantic import BaseModel

app = FastAPI()

class BookBase(BaseModel):
    name: str

class BookDB(BookBase):
    id: int

books = [{"id": 0, "name": "kirja1", "author": "author1"},
         {"id": 1, "name": "kirja2", "author": "author2"},
         {"id": 2, "name": "kirja3", "author": "author3"}
]

def get_book_index(id):
    book_id = None
    for index, book in enumerate(books):
        if book["id"] == id:
            book_id = index
            break
    if book_id == None:
        raise HTTPException(status_code = 404, detail = "Not found!")
    return book_id

@app.get("/books/", response_model = list[BookDB])
def get_books():
    return books

@app.get("/books/{id}", response_model = BookDB,)
def get_book(id: int):
    book_id = get_book_index(id)
    return books[book_id]

@app.post("/post", response_model = BookDB, status_code = status.HTTP_201_CREATED)
def post_book(book_in: BookBase):
    new_id = len(books)
    book = BookDB(**book_in.dict(), id = new_id)
    books.append(book.dict())
    return

@app.delete("/delete/{id}")
def delete_book(id: int):
    book_id = get_book_index(id)
    del books[book_id]
    return {"message": "Book deleted succesfully!"}