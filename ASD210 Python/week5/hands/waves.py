import matplotlib.pylab as plt
import numpy as np

# plt.xkcd()
# plt.style.use("fivethirtyeight")

x = np.linspace(-np.pi, np.pi)

plt.plot(x, np.sin(x), label="Sine Wave", linestyle="--", linewidth=2)
plt.plot(x, np.cos(x), label="Cosine Wave", linestyle=":", linewidth=2)

sq = 0
for i in range(1, 50):
    sq = sq + ((np.sin(2 * np.pi * ((2 * i) - 1) * x) / ((2 * i) - 1)))
    sum_sq = (4 / np.pi) * sq
plt.plot(x, sum_sq, label="Square Wave", linewidth=2)


plt.title("Week 5 Hands On")
plt.xlabel("Time")
plt.ylabel("Amplitute")
plt.axis("tight")
plt.legend(loc="best")
plt.grid(True)

plt.show()
