"""
Program: sum.py
Project 3.9

Computes the sum and average of a series of EVEN input numbers.
"""

theSum = 0
count = 0
while True:
    number = input("Enter a number or press Enter to quit: ")
    if number == "":
        break
    theSum += float(number) if float(number) % 2 == 0 else 0 # well just apply a ternary conditional to the increment-assignment
    count += 1 if float(number) % 2 == 0 else 0              # this is just because the average at the bottom is weird without doing it here too

print("The sum of even numbers entered is", theSum)
if count > 0:
    print("The average of even numbers entered is", theSum / count)
