"""
File: buttondemo.py
"""

from breezypythongui import EasyFrame
from matplotlib.colors import rgb2hex
import random

class ButtonDemo(EasyFrame):
    """Illustrates command buttons and user events."""

    def __init__(self):
        """Sets up the window, label, and buttons."""
        EasyFrame.__init__(self, title = "Button Demo")

        # A single label in the first row.
        self.label = self.addLabel(text = "Hello world!",
                                   row = 0, column = 0,
                                   columnspan = 3, sticky = "NSEW"
                                   )

        # Two command buttons in the second row.
        self.clearBtn = self.addButton(text = "Clear",
                                       row = 1, column = 0,
                                       command = self.clear)

        self.changeColorBtn = self.addButton(text = "Change Color",
                                             row = 1, column = 1,
                                             command = self.change_color,
                                             state = "normal")

        self.restoreBtn = self.addButton(text = "Restore",
                                         row = 1, column = 2,
                                         command = self.restore,
                                         state = "disabled")

    # Methods to handle user events.
    def clear(self):
        """Resets the label to the empty string and
        the button states."""
        self.label["text"] = ""
        self.clearBtn["state"] = "disabled"
        self.changeColorBtn["state"] = "disabled"
        self.restoreBtn["state"] = "normal"

    def restore(self):
        """Resets the label to 'Hello world!'and sets
        the state of the buttons."""
        self.label["fg"] = "black"
        self.label["text"] = "Hello world!"
        self.clearBtn["state"] = "normal"
        self.restoreBtn["state"] = "disabled"
        self.changeColorBtn["state"] = "normal"

    def change_color(self):
        """Changes the forground color of the text
        value of a Label"""
        self.label["fg"] = random.choice(("red", "blue", "green", "yellow", "gray", "pink"))
        self.restoreBtn["state"] = "normal"


def main():
    """Instantiate and pop up the window."""
    ButtonDemo().mainloop()

if __name__ == "__main__":
    main()
