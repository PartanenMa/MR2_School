Venv-asennus:
Ole hakemistossa PelaajaAPI
Ctrl+Shift+p
Create Environment
Venv
Python

Venv-käynnistys:
(Windows): .venv/Scripts/Activate.ps1
(Linux): .venv/bin/activate

FastAPI-sennus:
pip install fastapi uvicorn

Ohjelman runnaaminen:
uvicorn main:app --reload