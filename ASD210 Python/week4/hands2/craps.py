"""
File: craps.py
This module studies and plays the game of craps.
"""
from die import Die
from random import randint


class Player(object):
    def __init__(self):
        """Has a pair of dice and an empty rolls list."""
        all_dice = [Die() for _ in range(5)]
        self.die1 = all_dice.pop(randint(0, len(all_dice) - 1))
        self.die2 = all_dice.pop(randint(0, len(all_dice) - 1))
        self.rolls = []
        self.rollsCount = 0
        self.atStartup = True
        self.winner = False
        self.loser = False

    def __str__(self):
        """Returns the string rep of the history of
        rolls."""
        result = ""
        for (v1, v2) in self.rolls:
            result = result + str((v1, v2)) + " " + \
                str(v1 + v2) + "\n"
        return result


    def rollDice(self):
        if self.atStartup == True:
            self.die1.roll()
            self.die2.roll()
            (v1, v2) = (self.die1.getValue(), self.die2.getValue())
            self.rolls.append((v1, v2))
            self.atStartup = False
            initialSum = v1 + v2
            if initialSum in (2, 3, 12):
                self.loser = True
            elif initialSum in (7, 11):
                self.winner = True
        while not self.winner and not self.loser:
            self.die1.roll()
            self.die2.roll()
            (v1, v2) = (self.die1.getValue(), self.die2.getValue())
            self.rolls.append((v1, v2))
            laterSum = v1 + v2
            if laterSum == 7:
                self.loser = True
            elif laterSum == initialSum:
                self.winner = True


    def getRollsCount(self):
        return len(self.rolls)


    def isWinner(self):
        return self.winner


    def isLoser(self):
        return self.loser






# Functions that interact with the user to play the games


def playOneGame():
    """Plays a single game and prints the results."""
    player = Player()
    player.rollDice()
    print(player)
    if player.isWinner():
        print("You win!")
    else:
        print("You lose!")


def playManyGames(number):
    """Plays a number of games and prints statistics."""
    wins = 0
    losses = 0
    winRolls = 0
    lossRolls = 0
    for _ in range(number):
        player = Player()
        player.rollDice()
        rolls = player.getRollsCount()
        print("Game", _ + 1)
        print(player)
        if player.isWinner():
            wins += 1
            winRolls += rolls
            print("You win!")
        else:
            losses += 1
            lossRolls += rolls
            print("You lose!")
    print("The total number of wins is", wins)
    print("The total number of losses is", losses)
    print("The average number of rolls per win is %0.2f" % (winRolls / wins))
    print("The average number of rolls per loss is %0.2f" % (lossRolls / losses))
    print("The winning percentage is %0.3f" % (wins / number))


def main():
    """Plays a number of games and prints statistics."""
    playOneGame()
    playManyGames(int(input("Enter the number of games: ")))


if __name__ == "__main__":
    main()
