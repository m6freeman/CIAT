def chapterOneProjectTwo(name, address, phone) :
    print(name + "\n" + address + "\n" + str(phone))

def chapterOneProjectSix() :
    from math import pi
    radius = float(input("Enter a radius: "))
    area = pi * (radius ** 2)
    print("The area of a circle with radius " + str(radius) + " = " + str(area))

def chapterOneProjectSeven() :
    name = str(input("Enter your name: ")).capitalize()
    age = int(input("Enter your age: "))
    print(name + " is " + str(age) + " years old.")

def chapterTwoProjectTwo() :
    edge = int(input("Enter the length of an edge of a cube: "))
    area = 6 * (edge ** 2)
    print("The area of a cube with edge length " + str(edge) + " = " + str(area))


def chapterTwoProjectFour() :
    from math import pi
    radius = float(input("Enter the radius of a sphere: "))
    diameter = 2 * radius
    circumference = 2 * pi * radius
    surfaceArea = 4 * pi * (radius ** 2)
    volume = float(4/3) * pi * (radius ** 3)
    print("The diameter of a sphere with radius " + str(radius) + " = " + str(diameter))
    print("The circumference of a sphere with radius " + str(radius) + " = " + str(circumference))
    print("The surface area of a sphere with radius " + str(radius) + " = " + str(surfaceArea))
    print("The volume of a sphere with radius " + str(radius) + " = " + str(volume))


# Ch. 1 Project 2
print("\033[1m Ch. 1\tProject 2\033[0m")
chapterOneProjectTwo("Matt", "123 Main St. San Diego CA", 1234567890)
print("\n")

# Ch. 1 Project 6
print("\033[1m Ch. 1\tProject 6\033[0m")
chapterOneProjectSix()
print("\n")

# Ch. 1 Project 7
print("\033[1m Ch. 1\tProject 7\033[0m")
chapterOneProjectSeven()
print("\n")

# Ch. 2 Project 2
print("\033[1m Ch. 2\tProject 2\033[0m")
chapterTwoProjectTwo()
print("\n")

# Ch. 2 Project 4
print("\033[1m Ch. 2\tProject 4\033[0m")
chapterTwoProjectFour()
print("\n")