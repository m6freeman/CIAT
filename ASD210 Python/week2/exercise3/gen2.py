sentences = [
    [
        "It was so noisy in there, ",
        "My grandfather gets up early, ",
        "I wish I would've been more aware of what was going to happen, ",
        "The ship sailed through the Suez Canal, ",
        "My father is so old that he can't work, ",
        "Tom seldom laughed at Mary's jokes, ",
        "How many of us are there, ",
        "She lost weight, ",
        "What a nightmare, ",
        "I know you can help us, "
    ],
    [
        "in other words, it takes all sorts of people to make a world.",
        "I can't go with you. I have an engagement.",
        "Tom's quick thinking saved the day.",
        "what you have said doesn't apply to you.",
        "I confessed my sin.",
        "when's that going to happen?",
        "Tom is extremely arrogant.",
        "Tom failed to do that.",
        "Tom and I go cycling together.",
        "we lost it."
    ]
]

from random import randint
print("Welcome to the most incoherent chat-bot ever!")
print("Go ahead, ask it something...")
while True :
    if input(">> ") == ' ':
        break
    else :
        print("\033[32m<<<<", sentences[0][randint(0, 9)], sentences[1][randint(0, 9)], "\033[0m")