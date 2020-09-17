"""
File: navigate.py
Project 5.2

Allows the user to navigate to any line in a text file.
"""

# Take the input file name
inName = input("Enter the input file name: ")

# Open the input file and read the text
inputFile = open(inName, 'r')
lines = []
for line in inputFile:
    lines.append(line)

# Loop for line numbers from the user until she enters 0
# and prints the line's number followed by the line
while True:
    print("The file has", len(lines), "lines.")
    if len(lines) == 0:
        break
    lineNumber1, lineNumber2 = int(input("Enter a line number [0 to quit]: ")) - 1, int(input("Enter the second line to join: ")) - 1
    if lineNumber1 < 0 or lineNumber2 < 0:
        break
    elif lineNumber1 >= len(lines) or lineNumber2 >= len(lines) :
        print("ERROR: line number must be less than", len(lines))
    else:
        from itertools import chain
        new_line = lines[lineNumber1] + lines[lineNumber2]
        new_chars = set(chain(*(word.split() for word in new_line)))
        new_words = set(new_line.split())
        print(lineNumber1 + 1, "&", lineNumber2 + 1, " : ", new_line) 
        print("# of unique characters:", len(new_chars))
        print(sorted(new_chars))
        print("# of unique words: ", len(new_words))
        print(sorted(new_words))
        print("\n")
