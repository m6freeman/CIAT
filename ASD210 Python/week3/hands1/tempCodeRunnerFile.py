def printAll(seq):
    if seq:
        print(seq[0])
        print("Passing", seq[1:], "through again")
        printAll(seq[1:])

printAll("Testing")