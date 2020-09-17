"""
File: ccurve.py
Project 7.2

This program prompts the user for the level of
a c-curve and draws a c-curve of that level.

Draws the line segments in random colors.
"""

import turtle
from random import randint
from inspect import signature


def cCurve(t, x1, y1, x2, y2, level):

    def drawLine(x1, y1, x2, y2):
        """Draws a line segment between the endpoints,
        using a random color."""
        s = turtle.Screen()
        s.colormode(255)
        t.pencolor(randint(0, 255) for _ in range(3))
        t.pensize(5)
        t.up()
        t.goto(x1, y1)
        t.down()
        t.goto(x2, y2)

    if level == 0:
        drawLine(x1, y1, x2, y2)
    else:
        xm = (x1 + x2 + y1 - y2) // 2
        ym = (x2 + y1 + y2 - x1) // 2
        cCurve(t, x1, y1, xm, ym, level - 1)
        cCurve(t, xm, ym, x2, y2, level - 1)

def main():
    level = int(input("Enter the level (0 or greater): "))
    t = turtle.Turtle()
    t.hideturtle()
    t.speed("fastest")
    cCurve(t, 100, -10, 100, 100, level)
    turtle.done()


if __name__ == "__main__":
    main()
