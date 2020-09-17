"""
File: viewfiles.py
Project 6.7

Allows the user to visit all of the files in the current path and view them.

"""

import os, os.path
from pathlib import Path

def main():
    displayFiles(os.getcwd())

def displayFiles(path) :
    if os.path.isfile(path) :
        print("\033[1;35mFile name: " + path, "\033[0m")
        try :
            with open(path, 'r') as f :
                print(f.read())
        except : print("\033[1;37;41m" + f.name + " could not be read.\033[0m")
        
    else :
        print("\033[1;35mDirectory name: " + path, "\033[0m")
        for file in os.listdir(path) : 
            displayFiles(os.path.join(path, file))

# def displayFiles(path):
#     """Visits all of the files and directories in
#     path and displays the files' contents."""
#     if os.path.isfile(path):
#         print("File name: " + path)
#         f = open(path, 'r')
#         print(f.read())
#     else:
#         print("Directory name: " + path)
#         lyst = os.listdir(path)
#         for element in lyst: displayFiles(element)

if __name__ == "__main__" :
    main()
