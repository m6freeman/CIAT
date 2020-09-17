def chapterTwoProjectSix() :
    mass = float(input("Enter the mass of an object: "))
    velocity = float(input("Enter the velocity of an object: "))
    momentum = mass * velocity
    kineticEnergy = 0.5 * mass * (velocity ** 2)
    print("Mass\tVelocity\tMomentum\tKinetic Energy\n" \
        + str(mass) + "\t" + str(velocity) + "\t\t" + str(momentum) + "\t\t" + str(kineticEnergy))

def chapterTwoProjectTen() :
    hourlyWage = float(input("Enter your hourly wage: "))
    regularHours = float(input("Enter the number of regular hours worked: "))
    overtimeHours = float(input("Enter the number of overtime hours worked: "))
    print("Earned: $", (regularHours * hourlyWage) + (overtimeHours * (hourlyWage * 1.5)))

def chapterThreeProjectEight(x, y) :
    print("Is y(", y, ") = 0?")
    if(y == 0) : 
        print("Return x(", x, ").")
        return x 
    else: 
        print("If not, compute the remainder of dividing x(", x, ") by y(", y, ") = ", x % y)
        print("Then replace x(", x, ") with y(", y, ") and y(", y, ") with the remainder(", x % y, ").")
        return chapterThreeProjectEight(y, x % y) 


def chapterThreeProjectNine() :
    from statistics import mean
    lst = list(map(int, input("Enter numbers (seperated by spaces): ").split()))
    print("Sum = ", sum(lst), "\nAverage = ", mean(lst))

def chapterThreeProjectTen() :
    price = float(input("Enter purchase price: "))
    balance = price - (price * 0.1)
    payment = balance * 0.05
    month = 1
    print('\033[1m%-15s%-15s%-15s%-15s%-15s%-15s\033[0m' % ("Month", "Full Balance", "Interest", "Principal", "Payment", "Next Balance"))
    while (balance > 0):
        print('%-15i%-15.2f%-15.2f%-15.2f%-15.2f%-15.2f' % (month, balance, balance * 0.12 / 12, payment - (balance * 0.12 / 12), payment, balance - payment))
        month += 1
        balance -= payment


# Ch. 2 Project 6
print("\033[1m Ch. 2 Project 6\033[0m")
chapterTwoProjectSix()
print("\n")

# Ch. 2 Project 10
print("\033[1m Ch. 2 Project 10\033[0m")
chapterTwoProjectTen()
print("\n")

# Ch. 3 Project 8
print("\033[1m Ch. 3 Project 8\033[0m")
print(str(chapterThreeProjectEight(66, 48)))
print("\n")

# Ch. 3 Project 9
print("\033[1m Ch. 3 Project 9\033[0m")
chapterThreeProjectNine()
print("\n")

# Ch. 3 Project 10
print("\033[1m Ch. 3 Project 10\033[0m")
chapterThreeProjectTen()
print("\n")