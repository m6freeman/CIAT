import threading
import time

def func():
    print('ran')
    time.sleep(1)
    print('done')
    print(threading.activeCount(), "in func")

x = threading.Thread(target=func)
print(threading.activeCount(), "first")
x.start()
print(threading.activeCount(), "last")


