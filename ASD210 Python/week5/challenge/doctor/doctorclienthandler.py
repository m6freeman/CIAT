"""
File: doctorclienthandler.py
Project 10.4
Client handler for providing non-directive psychotherapy.
Patient provides a user name, and client attempts to load
that patient's doctor from a file. If the file does not
exist, a new doctor is created. The doctor is saved to a
file when the client disconnects.
"""

from codecs import decode
from threading import Thread
from doctor import Doctor
import os.path
import pickle

BUFFSIZE = 1024
CODE = "ascii"

class DoctorClientHandler(Thread):
    """Handles a session between a doctor and a patient."""
    def __init__(self, client):
        Thread.__init__(self)
        self.client = client

    def run(self):
        self.filename = decode(self.client.recv(BUFFSIZE), CODE) + ".dat"
        if os.path.exists(self.filename):
            fileObj = open(self.filename, "rb")
            self.dr = pickle.load(fileObj)
        else:
            self.dr = Doctor()
        self.client.send(bytes(self.dr.greeting(), CODE))
        while True:
            message = decode(self.client.recv(BUFFSIZE), CODE)
            if not message:
                print("Client disconnected")
                self.client.close()
                fileObj = open(self.filename, "wb")
                pickle.dump(self.dr, fileObj)
                fileObj.close()
                break
            else:
                self.client.send(bytes(self.dr.reply(message), CODE))


