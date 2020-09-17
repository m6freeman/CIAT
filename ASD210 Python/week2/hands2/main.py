def dictionary_concatenater(*args) :
    d = dict()
    for arg in args :
        d.update(arg)
    return d

def checkKey(query, search) :
    return query in search

def buildSquaredDict(start, end) :
    d = dict()
    for x in range(start, end + 1) :
        d.update({x : x*x})
    return d

dic1={1:10,2:20}
dic2={3:30,4:40}
dic3={5:50,6:60}

print("\033[1m#1\033[0m")
print(dictionary_concatenater(dic1, dic2, dic3))

print("\033[1m#2\033[0m")
print(checkKey(5, dictionary_concatenater(dic1, dic2, dic3)))

print("\033[1m#3\033[0m")
print(buildSquaredDict(1, 50))
