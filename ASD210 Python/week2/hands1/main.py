
class chapterFour :
    def __init__(self) : print("\033[1m\tChapter Four\033[0m")
    class ProjectOne :
        def __init__(self) : print("\033[4m\tProject One\033[0m")
        def caesar(self, plain_text, shift, classic_mode=False) :
            rv = ''
            for i in plain_text :
                if classic_mode :
                    if i == ' ' : rv += i
                    elif i.isupper() : rv += chr((ord(i) + shift - 65) % 26 + 65)
                    else : rv += chr((ord(i) + shift - 97) % 26 + 97)
                else : rv += chr((ord(i) + shift))
            print(rv)

    class ProjectFive :
        def __init__(self) : print("\n\033[4m\tProject Five\033[0m")
        def shiftLeft(self, bit_string, shift) :
            print(bit_string[abs(shift):] + bit_string[:abs(shift)])
        def shiftRight(self, bit_string, shift) :
            print(bit_string[abs(shift) * -1:] + bit_string[:abs(shift) * -1])

    class ProjectEight :
        def __init__(self) : print("\n\033[4m\tProject Eight\033[0m")      
        def cp(self, file1, file2) :
            path = "/home/matt/Documents/CIAT/ASD210 Python/week2/hands1/"
            try :
                from os import chdir, getcwd
                if getcwd() != path : chdir(path)
                with open(file1, 'r') as f1 :
                    with open(file2, 'a+') as f2 :
                        print("\033[1m", f1.name, "\033[0m")
                        for line in f1 :
                            print(line)
                            f2.write(line)
                with open(file2, 'r') as f2 :
                    print("\033[1m", f2.name, "\033[0m")
                    for line2 in f2 : print(line2)
            except : print("Correct your path and try again.")
            finally : return

class ChatperFive :
    def __init__(self) : print("\033[1m\tChapter Five\033[0m")
    class ProjectFive() :
        def __init__(self) : print("\n\033[4m\tProject Five\033[0m")
        hexDict = {
        '0' : 0,
        '1' : 1,
        '2' : 2,
        '3' : 3,
        '4' : 4,
        '5' : 5,
        '6' : 6,
        '7' : 7,
        '8' : 8,
        '9' : 9,
        'A' : 10,
        'B' : 11,
        'C' : 12,
        'D' : 13,
        'E' : 14,
        'F' : 15
        }
        def repToDecimal(self, num, base) : 
            # Y we no use int(num, base) !?
            decimal = 0
            exp = len(num) - 1
            for digit in num :
                decimal += self.hexDict.get(digit) * base ** exp
                exp -= 1
            print(num, "base", base, "=", decimal)


    class ProjectSeven() :
        def __init__(self) : print("\n\033[4m\tProject Seven\033[0m")
        def sortedFileWords(self, file) : 
            from itertools import chain
            from os import chdir, getcwd
            path = "/home/matt/Documents/CIAT/ASD210 Python/week2/hands1/"
            if getcwd() != path : chdir(path)
            try :
                with open(file) as f :
                    print(sorted(set(chain(*(line.split() for line in f if line)))))
            except : print("Correct your path and try again.")
            finally : return

def main() :
    x = chapterFour()
    x.ProjectOne().caesar(input("Enter your message: "), 13)
    x.ProjectOne().caesar(input("Enter your message: "), 13, classic_mode=True)
    x.ProjectFive().shiftLeft("1101", 1)
    x.ProjectFive().shiftRight("1101", 1)
    x.ProjectEight().cp(str(input("Copy from: (example \"1.txt\") ")), "2.txt")

    x = ChatperFive()
    x.ProjectFive().repToDecimal("0F", 16)
    x.ProjectFive().repToDecimal("107", 8)
    x.ProjectFive().repToDecimal("1101", 2)
    x.ProjectSeven().sortedFileWords('1.txt')

if __name__ == "__main__" : main()