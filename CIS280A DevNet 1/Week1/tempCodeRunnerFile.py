#[9:04 PM] Alwin Lau
    
# import requests library
import requests


#import json library
import json


accessToken = "OWEyMzc3ZjUtYWZjYi00OWRjLTg5MDktNzM1NDQzYjZhNWJkM2MxM2E4N2MtZmVi_P0A1_669cd3ac-f150-48ef-a1a3-06be3c70e2a0" #put your access token here between the quotes.


def setHeaders():         
    accessToken_hdr = 'Bearer ' + accessToken
    webex_teams_header = {​​​​​​​'Authorization': accessToken_hdr, 'Content-Type': 'application/json; charset=utf-8'}​​​​​​​
    return webex_teams_header


def getRooms(theHeader):    
    uri = 'https://api.ciscospark.com/v1/rooms'
    resp = requests.get(uri, headers=theHeader)    
    return resp.json()


def parseData(value):
    value = json.dumps(value['items'])
    for values in value:
        print(values)


header=setHeaders()
value=getRooms(header)
print (json.dumps(value, indent=4, separators=(',', ': ')))
parseData(value)








