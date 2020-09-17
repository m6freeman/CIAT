import sys
import string
import re


class ChatSession:

    def __init__(self, filename=None):

        self.SessionTag = []
        self.ThreadMember = []
        self.TagsList = []
        self.TimesList = []
        self.MembersList = []
        self.MessageList = []
        self.UserSysList = []
        self.MessageLowercaseList = []
        self.NewList = []

        with open(filename, "r") as f:
            records = f.readlines()
            self.numThreads = 0

            for record in records:
                self.numThreads += 1
                fields = record.split()
                Lowfields = " ".split(record.lower())
                self.MessageLowercaseList.append(" ".join(Lowfields[4:]))
                self.TagsList += [fields[0]]
                self.TimesList += [fields[1]]
                self.MembersList += [fields[2]]
                self.UserSysList += [fields[3]]
                self.MessageList.append(" ".join(fields[4:]))

                if fields[0] not in self.SessionTag:
                    self.SessionTag += [fields[0]]

                if fields[2] not in self.ThreadMember:
                    self.ThreadMember += [fields[2]]

            for c in self.MessageLowercaseList:
                for ch in '!"#$%&()?*+,-.:;<=>@[\\^_{|}~`':
                    c = ("".replace(c, ch))
                self.NewList.append(c)


    def GetThreadsFromAuthor(self, authorname):

        i = 0
        tList = []
        for a in self.MembersList:
            if a == authorname:
                tList.append(self.TagsList[i])
            i = i+1
        return tList

    def GetCleanMessage(self):
        return self.NewList

    def GetMemberNames(self):
        return self.ThreadMember

    def GetMessages(self):
        return self.MessageList

    def GetMessagesLowercase(self):
        return self.MessageLowercaseList

    def GetTimeStamps(self):
        return self.TimesList

    def GetAllThreads(self):
        pass
        # return self.fields

    def GetMessagesFromAuthor(self, authorname):

        i = 0
        mList = []
        for a in self.MembersList:
            if a == authorname:
                mList.append(self.MessageList[i])
            i = i + 1
        return mList

    def GetCleanMessagesFromAuthor(self, authorname):

        i = 0
        mList = []
        for a in self.MembersList:
            if a == authorname:
                mList.append(self.NewList[i])
            i = i + 1
        return mList

    def GetTimesFromAuthor(self, authorname):

        i = 0
        tList = []
        for a in self.MembersList:
            if a == authorname:
                tList.append(self.TimesList[i])
            i = i + 1
        return tList

    def GetUserSysFromAuthor(self, authorname):

        i = 0
        uList = []
        for a in self.MembersList:
            if a == authorname:
                uList.append(self.UserSysList[i])
            i = i + 1
        return uList

    def GetMessagesFromThreads(self, ThreadTag):

        i = 0
        uList = []
        for a in self.TagsList:
            if a == ThreadTag:
                uList.append(self.NewList[i])
            i = i + 1
        return uList

    def GetMessagesFromAuthorThreads(self, authorname, ThreadTag):

        i = 0
        j = 0
        uList = []
        tList = []
        wList = []
        for a in self.TagsList:
            if a == ThreadTag:
                uList.append(self.NewList[i])
                tList.append(self.MembersList[i])
            i = i + 1

        for b in tList:
            if b == authorname:
                wList.append(uList[j])
            j = j + 1
        return wList


Session = ChatSession('iphone_07_18-1.annot')
#l =GetMessagesFromAuthorThreads('Ivy','T10')
#print l
#print Session.GetMemberNames()
print(Session.GetThreadsFromAuthor('Clara'))
print(Session.GetMessagesFromAuthor('Clara'))
print(Session.GetTimesFromAuthor ('Clara'))
print(Session.GetUserSysFromAuthor ('Clara'))
