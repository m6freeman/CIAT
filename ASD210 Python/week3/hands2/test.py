# import tkinter as tk
# from tkinter import ttk


# window = tk.Tk()

# window.title("Test window")
# window.configure(background="gray")

# button1 = ttk.Button(window, text="Click here")
# button1.grid(column=0, row=0)

# button2 = tk.Button(window, text="Click here")
# button2.grid(column=1, row=0)

# window.mainloop()


def one():
    print("physical layer stuff")

def two():
    print("data link layer stuff")

def three():
    print("network layer stuff")


functions = {
    1 : one(),
    2 : two(),
    3 : three()
}

for f in functions:
    f


