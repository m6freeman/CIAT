import random


# Request the input
dollars = int(input("How many dollars do you have? "))


# Initialize variables
maxDollars = dollars
countAtMax = 0
count = 0


# Loop until the money is gone
while dollars > 0:
    count += 1
    # Roll the dice
    die1 = random.randint(1, 6)  # 1-6
    die2 = random.randint(1, 6)  # 1-6
    #Calculate the winnings or losses
    if die1 + die2 == 7:
        dollars += 4

    else:
        dollars -= 1
        #If this is a new maximum, remember it
        if dollars > maxDollars:
            maxDollars = dollars
            countAtMax = count

            # Display the results
            print("You are broke after " + str(count) + " rolls.\n" +
                  "You should have quit after " + str(countAtMax) +
                  " rolls when you had $" + str(maxDollars) + ".")
