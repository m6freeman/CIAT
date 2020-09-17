from images import Image


def pasteurize(image, color = (0, 0, 0)):
    white_pixel = (255, 255, 255)
    for y in range(image.getHeight()):
        for x in range(image.getWidth()):
            (r, g, b) = image.getPixel(x, y) # maybe y, x not sure yet
            average = (r + g + b) // 3
            image.setPixel(x, y, color) if average < 128 else image.setPixel(x, y, white_pixel)

def main():
    fn = input("Enter a filename: ")
    red = int(input("Enter a digit between 0 and 255 for RED "))
    green = int(input("Enter a digit between 0 and 255 for GREEN "))
    blue = int(input("Enter a digit between 0 and 255 for BLUE "))
    image = Image(fn)
    pasteurize(image, (red, green, blue))
    image.draw()

if __name__ == "__main__":
    main()