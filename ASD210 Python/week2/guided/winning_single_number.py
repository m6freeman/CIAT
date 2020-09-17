from random import randint  # imports the randint function from the random class

number_of_tickets =  5
numbers_per_ticket = 5
guesses_per_number = 10 
upper_number = 99           
lower_number = 1                       
tickets = [[randint(lower_number, upper_number) for i in range(numbers_per_ticket)] for i in range(number_of_tickets)]
correct = [[] for _ in range(number_of_tickets)]
print(correct)
print(tickets)
print("\033[1;31mWELCOME TO THE WORLD'S EASIEST LOTTERY!\033[0m")
print("\n\033[31;2;3mYou will be given 5 numbers to guess")
print("with 10 tries per number. Good luck!\033[0m\n")

for i, ticket in enumerate(tickets) :
    for j, number in enumerate(ticket) :
        print("\033[1;4mTicket", i + 1, "Number", j + 1, "\033[0m")
        low, high = lower_number, upper_number
        for guess_count in range(guesses_per_number) :
            guess = randint(low, high)
            if guess == number :     
                print("\t", "You got it! Adding", number, "to Winning Ticket", i + 1)
                correct[i].append(number)
                print("\t", "The number of tries was:", guess_count + 1)
                break
            elif guess > number : 
                high = guess
                print("\t\033[1m", guess, "\033[0mis too high...")
            elif guess < number : 
                low = guess
                print("\t\033[1m", guess, "\033[0mis too low...")
        else :
            print("\t", "Sorry, you ran out of guesses for this number!") 
            correct[i].append(0)
print(correct)

