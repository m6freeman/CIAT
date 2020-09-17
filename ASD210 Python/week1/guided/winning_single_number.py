from random import randint  # imports the randint function from the random class

numbers = 5
guesses_per_number = 10 
upper_number = 99           
lower_number = 1                       
tickets = [randint(lower_number, upper_number) for i in range(numbers)]                 
correct = []

print("\033[1;31mWELCOME TO THE WORLD'S EASIEST LOTTERY!\033[0m")
print("\n\033[31;2;3mYou will be given 5 numbers to guess")
print("with 10 tries per number. Good luck!\033[0m\n")

for index, ticket in enumerate(tickets) :
    print("\033[1;4mTicket", index + 1, "\033[0m")
    for count in range(guesses_per_number) :      # iterates through each number in the list of lottery numbers
        guess = int(input("Guess " + str(count + 1) + ": "))
        if guess == ticket :     
            print("\t", "You got it! Adding", ticket, "to Winning Lottery Ticket")
            correct.append(ticket)
            print("\t", "The number of tries was:", count + 1)
            break
        elif guess > ticket : print("\t\033[1m", guess, "\033[0mis too high...")
        elif guess < ticket : print("\t\033[1m", guess, "\033[0mis too low...")
        if count > guesses_per_number:         # if we reach the max number of tries then quit
            print("\t", "Sorry, you ran out of guesses for this ticket!") 
            correct.append(0)
print(correct)

