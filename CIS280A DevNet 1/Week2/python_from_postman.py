import requests

url = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=6"

payload={}
headers = {
  'Authorization': 'Bearer NDk5MjU4MWItYzY2Ni00Y2VlLWJkOGMtOGJiMjdiZTBmNzI1OTM5Nzk4YjMtNWU4_P0A1_d2c22ef8-905b-4ab9-b9c6-81bc98924b65',
  'Content-Type': 'application/json; charset=utf-8',
  'Cookie': '__cfduid=d11830dc529301af9a1d19bb055751b151613482592'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)


deck = response.json()
deck_id = deck['deck_id']
print(deck_id)