import turtle
from random import randint, choice

colors = ["red", "blue", "green", "yellow", "cyan", "white"]
t = turtle.Turtle()
# t.speed("fastest")

x = 360 // 8


def loop(angle):
    for i in range(10):
        t.forward(100)
        t.left(angle)
        loop(x=x-1)


loop(x)


turtle.Screen().exitonclick()
