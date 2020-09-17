"""
OOPS! Didn't realize there was a starter file for this until after I completed
this entire thing from scratch... hope you don't mind this one! If it isn't
acceptable, please let me know and I'll submit the one from the template.
SORRY!!!
"""

import tkinter as tk
from random import choice

root = tk.Tk()
root.title("Guessing Game")
low = 0
high = 100


def too_low(guess):
    global low
    low = guess + 1
    play()


def too_high(guess):
    global high
    high = guess - 1
    play()


def correct():
    title_label["text"] = "Enter another number to play again!"
    comp_guess["text"] = ""
    play_btn["state"] = tk.NORMAL
    correct_btn["state"] = tk.DISABLED
    user_num.delete(0, tk.END)
    global low, high
    low = 0
    high = 100


def guess():
    try:
        return choice(range(low, high))
    except:
        return low


def play():
    play_btn["state"] = tk.DISABLED
    if not user_num.get().isdigit():
        user_num.delete(0, tk.END)
        user_num.insert(0, "Enter a number: " + str(low) + " - " + str(high))
        play_btn["state"] = tk.NORMAL
    elif int(user_num.get()) > high or int(user_num.get()) < low:
        correct()
        too_high_btn["state"] = tk.DISABLED
        too_low_btn["state"] = tk.DISABLED
        title_label["text"] = "HEY! No cheating. Let's restart..."
        return None
    else:
        too_high_btn["state"] = tk.NORMAL
        too_low_btn["state"] = tk.NORMAL
        title_label["text"] = choice(("Hmm, is it...", "Let's try...", "Ok, what about..."))
        comp_guess["text"] = guess()
        if comp_guess["text"] == int(user_num.get()):
            title_label["text"] = "I got it! Your number is..."
            correct_btn["state"] = tk.NORMAL
            too_high_btn["state"] = tk.DISABLED
            too_low_btn["state"] = tk.DISABLED


###     Widget Setup    ###
title_label = tk.Label(root, text = "I bet I can guess your number!")
comp_guess = tk.Label(root, text = "")
user_num_label = tk.Label(root, text = "your secret number", fg = "gray", font = ("Times", 8, "italic"))
user_num = tk.Entry(root, width = 25, justify = tk.CENTER)
user_num.insert(0, "Enter a number: " + str(low) + " - " + str(high))
too_low_btn = tk.Button(root, text = "Too low!",
                        state = tk.DISABLED,
                        command = lambda: too_low(comp_guess["text"]))
too_high_btn = tk.Button(root, text = "Too high!",
                         state = tk.DISABLED,
                         command = lambda: too_high(comp_guess["text"]))
play_btn = tk.Button(root, text = "Play",
                     state = tk.NORMAL,
                     command = play)
correct_btn = tk.Button(root, text = "Correct!",
                        state = tk.DISABLED, width = 25,
                        command = correct)

###     Widget Placement    ###
title_label.grid(row = 0, column = 0, columnspan = 3)
comp_guess.grid(row = 1, column = 0, columnspan = 3)
user_num_label.grid(row = 2, column = 0, columnspan = 3)
user_num.grid(row = 3, column = 0, columnspan = 3)
too_low_btn.grid(row = 4, column = 0)
play_btn.grid(row = 4, column = 1)
too_high_btn.grid(row = 4, column = 2)
correct_btn.grid(row = 5, column = 0, columnspan = 3)


root.mainloop()
