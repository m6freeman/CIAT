"""
File: average.py
Project 6.9
Prints the average of the numbers in a text file
"""

with open(input("Enter the input file name: "), 'r') as f:
# Read the numbers as strings into a list
    list_from_file = []
    for line in f:
        list_from_file.extend(line.split())

# Convert all the strings in the list to numbers
list_from_file = list(map(float, list_from_file))

def getAverage(inputList):
    print("The average is", 0 if len(inputList) == 0 else sum(inputList) / len(inputList))

def getMin(inputList):
    print("The min is", min(inputList))

def getMax(inputList):
    print("The max is", max(inputList))


getAverage(list_from_file)
getMax(list_from_file)
getMin(list_from_file)
