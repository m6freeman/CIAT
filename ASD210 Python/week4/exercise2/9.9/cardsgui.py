"""
File: cardsgui.py
Project 9.9
Pops up a window that allows the user to view a deck of cards.
"""

from breezypythongui import EasyFrame
from tkinter import PhotoImage
from cards import Deck


class CardsGUI(EasyFrame):

    def __init__(self):
        """Creates the deck, and sets up the image and label
        for the card to be displayed, and the two command buttons."""
        EasyFrame.__init__(self, title="Cards Demo")
        # Instantiate the model.
        self.deck = Deck()
        # Add labels and buttons to the view.
        self.imageLabel = self.addLabel("", row=0, column=0,
                                        sticky="NSEW",
                                        columnspan=3)
        self.stateLabel = self.addLabel("", row=1, column=0,
                                        sticky="NSEW",
                                        columnspan=3)
        self.dealBtn = self.addButton(row=2, column=0,
                                      text="Deal",
                                      command=self.deal)
        self.addButton(row=2, column=1,
                       text="Shuffle",
                       command=self.shuffle)
        self.addButton(row=2, column=2,
                       text="New deck",
                       command=self.newDeck)
        # Helper method takes the file name as an argument.
        self.refreshImage("DECK/b.gif")

    def deal(self):
        """Rolls the dice and updates the view with
        the results."""
        card = self.deck.deal()
        self.stateLabel["text"] = str(card)
        fileName = "DECK/" + str(card.rank).lower() + str(card.suit[0]).lower() + ".gif"
        self.refreshImage(fileName)
        if len(self.deck) == 0:
            self.dealBtn["state"] = "disabled"

    def shuffle(self):
        """Shuffles the deck."""
        self.deck.shuffle()

    def newDeck(self):
        """Create a new craps game and updates the view."""
        self.deck = Deck()
        self.stateLabel["text"] = ""
        self.refreshImage("DECK/b.gif")
        self.dealBtn["state"] = "normal"

    def refreshImage(self, fileName):
        """Updates the card's image in the window."""
        self.image = PhotoImage(file=fileName)
        self.imageLabel["image"] = self.image


def main():
    CardsGUI().mainloop()


if __name__ == "__main__":
    main()
