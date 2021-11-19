import torch
import os
from pymongo import MongoClient
import datetime



name = '71.43255345,51.43255345.jpg'

idx = 0
for i in range(len(name) - 1, -1, -1):
        if name[i] == '.':
                idx = i
                break

print(name[0:idx].split(','))

coordinates = name[0:idx].split(',')

client = MongoClient('mongodb+srv://developer1:hyunsoo97@qple-core.jxnch.mongodb.net/myFirstDatabase?retryWrites=true&w=majority')
db = client['Lemmefind']
obj = db['Objects']

post = {
                "objectName": "MooYaHo",
                "longitude": float(coordinates[0]),
                "latidude": float(coordinates[1]),
        }

post_id = obj.insert_one(post).inserted_id