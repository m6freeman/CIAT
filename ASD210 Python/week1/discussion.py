# Let's start by importing external modules we need for later
import os

# Here we'll set up a few custom data-types (classes)
# Food is defined to keep track of the constant values for each food option the user has
class Food :
    # While not necessary, it's common convention to CAPITALIZE constant variables
    # Python doesn't have a 'const' keyword, so we need to declare these variables
    # at the class level, effectively making them static and constant (since all 
    # python variables are immutable)
    APPLE = 0.85
    BREAD = 2.50
    CHEESE = 1.25

# The cart class is defined so we can keep track of individual instances of a user's cart
class Cart :
    # Obviously, we want to track the food in their cart
    apples = 0
    bread = 0
    cheese = 0
    # and we want to track this user's budget
    balance = 0
    # and here we'll maintain a bool indicating whether or not we want to keep shopping
    shopping = True
    
    # this is how python handles constructors (class methods called upon object instantiation)
    # all we want to do is assign the balance the user provides to their cart
    def __init__(self, balance):
        self.balance = balance

# The next few functions aren't necessarily cart or food specific, but we do want to
# do something with those types, so we'll declare them globally
def display_chart(cart) :
    # ok, here's where we're utilizing that module we imported earlier
    # this will check the operating system the program is running on, and clear the console
    # according to that OS's clear command. We want to clear the console every time so it
    # appears as though we're refreshing the user's screen
    os.system('cls' if os.name == 'nt' else 'clear')
    
    # Alright, I know this looks nuts, but it's actually not that bad
    # The first part each print() is doing is formatting, followed by what we want to format
    # \033[1m and \033[0m turns BOLD on and off
    # %-8s means format, left align, 8 characters wide, and apply to a string. Then we repeat that
    # however many times we want (in this case, 5 because that's how many tables headers we want)
    print('\033[1m%-8s%-8s%-8s%-8s%-8s\033[0m' % ("", "Apples", "Bread", "Cheese", "Budget"))
    # instead of formatting to a string for the numeric values, we use .2f to represent a floating
    # point value restricted to 2 decimal places (for money)
    # Then we insert those constant values we delcared earlier, by calling it from the static 
    # class (we never instantiated an object for Food)
    print('%-8s%-8.2f%-8.2f%-8.2f' % ("", Food.APPLE, Food.BREAD, Food.CHEESE))
    # and finally display the information currently in the user's cart
    print('\033[1m%-8s\033[0m%-8i%-8i%-8i%-8.2f' % ("Cart", cart.apples, cart.bread, cart.cheese, cart.balance))

# We will display options available when shopping that the user can enter based on what they want
def display_options() :
    print("\nWhat would you like to add?")
    print(" [A] Apples\t", " [B] Bread")
    print(" [C] Cheese\t", " [x] Go to check-out -->")

# Now we want to modify the user's cart based on their selection
def modify_cart(cart) :
    # because python doesn't utilize a switch-case statement, we can make our own with a Dictionary
    # with the unique indices cooresponding to the choices we gave earlier. Depending on what the user
    # picks, that will assign the appropriate food as their choice.
    choice = {
        'a' : Food.APPLE,
        'A' : Food.APPLE,
        'b' : Food.BREAD,
        'B' : Food.BREAD,
        'c' : Food.CHEESE,
        'C' : Food.CHEESE,
        'x' : False,
        'X' : False
    # and we'll pass in the user's input (casted into a string to match the above dictionary indices)
    }[str(input())]
    
    # Now remember, we may wish to stop shopping before we've blown our budget, so if we chose
    # to Continue to check-out, that will break our While loop and exit the program.
    if choice == False : 
        cart.shopping = False
        return None
    else : 
        # but if the choice wasn't to exit, let's ask how many items the user wants
        qty = int(input("How many?"))
        # and then adjust their balance accordingly
        cart.balance -= choice * qty
        # finally, we'll add the items to their cart
        if choice == Food.APPLE :
            cart.apples += qty
        elif choice == Food.BREAD :
            cart.bread += qty
        elif choice == Food.CHEESE :
            cart.cheese += qty

# And that's it for set up. So far, nothing has actually run yet. That will happen below.
# Let's ask the user how much money they have to spend, and pass that to their individual
# Cart's constructor
user_cart = Cart(float(input("Enter your budget: ")))

# Here's where all the heavy lifting is actually happening. While the user wishes to continue shopping
# AND their balance remains above 0, we will display the chart (remember the first thing that does is
# clears the console so it can print all the updated info), then display the options the user can make.
# Finally, we'll call modify_cart to actually change values. Then the While loop checks again, and so on and so forth
while (user_cart .shopping == True and user_cart.balance > 0) :
    display_chart(user_cart)
    display_options()
    modify_cart(user_cart)

# and after everything is said and done, we want to display the latest state of the user's cart info
display_chart(user_cart)
