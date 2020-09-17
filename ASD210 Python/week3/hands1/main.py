from random import randint, choice
import time


def chapter_six_project_one(x):
        # So I only changed this part because I wanted to practice writing a test method for it
    # x = int(input("Enter a number to find it's approximate square-root: "))
    t = 0.000001
    e = 1
    while True:
        e = (e + x / e) / 2
        d = abs(x - e ** 2)
        if d <= t:
            break
    print("Square root of", x, "=", e)

def chapter_six_project_two(x, e = 1):
    t = 0.000001
    e = (e + x / e) / 2
    d = abs(x - e ** 2)
    if d <= t: print("Square root of", x, "=", e)
    else: chapter_six_project_two(x, e)

def chapter_six_project_five(inputList):
    if inputList == [] or inputList == None:
        print(inputList, True)
        return
    else:
        prev = inputList[0]
        for num in inputList:
            if num < prev:
                print(False, "\t", inputList)
                return
            prev = num
        print(True, "\t", inputList)
        return

def printAll(seq):
    """# While this function hardly differs in terms of performance, it relies on manually
    # splicing the input string every iteration and must run through to completion before
    # anything can be performed on any values it may return. test() below leverages Python's Iterator pattern
    # Strings are sequences in Python, meaning they can be iterated over. This means a few things:
    # it has a __next__ function, which yields each value independently to be worked with. Iterators also
    # have an additional benefit which not many people are aware of: they're one way only and cannot be
    # iterated over again. This hardly EVER comes up in production needs, however you can easily test this:

    >>> nums = [1, 2, 3, 4]
    >>> squares = (num ** 2 for num in nums)
    >>> print(9 in squares)
    True
    >>> print(9 in squares)
    False

    # with large sequences that we only need to perform work on, or capture, each value once, this way
    # is far more preferable from a memory management standpoint
    # REF: https://www.youtube.com/watch?v=JYuE8ZiDPl4 (Loop better: a deeper look at iteration in Python)
    """
    if seq:
        print(seq[0])
        print("Now passing", seq[1:], "to printAll again...")       #comment this line before comparing against test()'s time
        printAll(seq[1:])
# this is only written as a control case. This is the fastest way to imitate the printAll() function,
# and after multiple tests of running 50k times each, the time differences are negligible
def test(s):
    for c in s:
        print(c)

def chapter_six_project_eight(func, times):
    start = time.time()
    for _ in range(times):
        func("Testing")
    end = time.time()
    print(end - start)

def square_test(func, times):
    for _ in range(times):
        func(randint(1, 200))

def sorted_test(func, times):
    for _ in range(times):
        randomList = [randint(1,200) for i in range(randint(4,8))]
        func(sorted(randomList) if choice([True, False]) else randomList)



print("\033[1m Ch. 6 Project 1 Newton's Approximation Algorithm\033[0m")
square_test(chapter_six_project_one, 5)

print("\n\033[1m Ch. 6 Project 2 Newton's Approximation Algorithm (Recursive)\033[0m")
square_test(chapter_six_project_two, 5)

print("\n\033[1m Ch. 6 Project 5 Ascending Order Test\033[0m")
sorted_test(chapter_six_project_five, 5)

print("\n\033[1m Ch. 6 Project 8 Testing Lee's Recursive Function\033[0m")
chapter_six_project_eight(printAll, 1)
# chapter_six_project_eight(printAll, 50000)
# chapter_six_project_eight(test, 50000)
