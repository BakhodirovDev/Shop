import json
from pyrogram import Client

# API ma'lumotlaringizni yuklab oling
api_id = '6031312'
api_hash = '9098c9ccc1185098251c457ab85b655f'

# Botni yaratish
app = Client("my_bot", api_id=api_id, api_hash=api_hash)

# JSON fayldan javoblar lug'atini yuklab oling
with open('api.json', 'r', encoding='utf-8') as f:
    responses = json.load(f)

@app.on_message()
def handle_message(client, message):
    text = message.text.lower()
    chat_id = message.chat.id
    # Agar matn lug'atda mavjud bo'lsa, javobni yuboring
    if text in responses:
        client.send_message(chat_id, responses[text])
    else:
        client.send_message(chat_id, "Kechirasiz, men sizning so'rovingizga javob berolmayman.")

app.run()
