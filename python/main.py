import random #importing a multiple modules (kinda like a libraries...)
import sys
import os

print("Hello World!")
Name = "Magnus"
Age = 19
print("They called the man " + Name + ", and he was " + str(
    Age) + " years old.\nSome say he might just become a good Python Programmer")
# Single line comment
print("this is a print without ", end="")
print("newline")
anw = input("?>") #input/output
print(anw)
print(sys.exc_info())
###############################################################
# Lists
###############################################################
groceryList = ['Eggs', 'Juice', "Bacon"]
weekendPlans = ["mow the lawn", "wash the car"]
todoList = [groceryList, weekendPlans]
print("first item: ", groceryList[0])
groceryList[2] = "Extra Bacon"
print(groceryList[0:3])
print(todoList)
print((todoList[1][0]))
groceryList.append("Milk")
groceryList.insert(1, "Apple Juice")
groceryList.sort()
groceryList.reverse()
del groceryList[3]
print(len(groceryList))
###############################################################
# tuples (kinda like lists but for more static data
###############################################################
piTup = (3, 1, 4, 1, 5, 9)
tupToList = list(piTup)
listToTup = tuple(tupToList)
print(len(piTup) + min(piTup) + max(piTup))
###############################################################
# sets (like list but can be in random order cuz why not...)
fruits = {"Banana", "Apple", "Strawberry", "Pineapple", "Pear", "Avocado", "Peach"}
print(fruits)
fruits.remove("Strawberry") # you don't belong here... Note: .remove may cause an error, if so use .discard
###############################################################
###############################################################
# maps/dictionary
###############################################################
cphTemp = {"Monday": 4,
           "Tuesday": 7,
           "Wednesday": 3,
           "Thursday": -1,
           "Friday": 2,
           "Saturday": 10,
           "Sunday": 7}
print("Mondays Weather: " + str(cphTemp["Monday"]) + " Celsius")
Names = {"Lilly": "Monroe",
         "James": "Johnson",
         "Victor": "Freeman"}
del Names["James"]
Names["Lilly"] = "Freeman"
print(Names.get("Victor"))
print(Names.keys())
print(Names.values())
###############################################################
# string manipulation
###############################################################
string = "hello everybody!"
print("String in uppercase", string.upper())
print("String in lowercase " + string.lower())
print("Capitalized string:", string.capitalize())
print(string[0:5]) # prints out 0 to 5th character in the string.
print(string[-5:]) # prints out the last 5 character in the string.
print(string.find("every")) # finds the index for every (case sensitive)
print(string.isalpha())
print(string.isalnum())
print(len(string))
print(string.capitalize().replace("everybody", "y'all"))
print(string.strip()) #removes whitespace
stringList = string.split(" ")
print(stringList)
###############################################################
# if else elif
###############################################################
if Age >= 16:
    print("you are allowed to drink low % alcohol")

elif Age >= 18:
    print("you can drink everything")
else:
    print("you are not allowed to drink!")

if Name is "Magnus":
    print("you are " + Name)
elif Name is not "Magnus":
    print("you are not + " + Name)

if (Name is "Magnus") and (Age is 19):
    print("all of the information is true!")
else:
    print("something went wrong")
###############################################################
# Loops!!!!!!!!!!!!!!!!!!!!!!
###############################################################
for i in range(10, 15):
    print(i)
print("groceryList:")
for y in groceryList:
    print(y) #no groceryList[y] like in many other languages..
randNum = random.randrange(0, 100)
while randNum is not 30:
    print(randNum)
    randNum = random.randrange(0, 100)
    if randNum is 30:
        print("30 was found!")
###############################################################
# Functions (out can't spell functions without fun.
###############################################################
def addNumbers(fNum, lNum): # this is a classical return function
    sumNum = fNum + lNum # these variables does not exits outside of the function (eg. out of scope)
    return sumNum


print("10 + 12 = ", addNumbers(10, 12))
###############################################################
# Files
###############################################################
testFile = open("test.txt", "wb")
print(testFile.mode)
print(testFile.name)
testFile.write(bytes("Hello, World!\n", 'UTF-8'))
testFile.close()

testFile = open("test.txt", "r+")
print(testFile.read())

os.remove("test.txt")
###############################################################
# classes
###############################################################
class Animal:
    __name = None # double __ means that the variable is private (eg. needs to be changed in a function) this is called encapsulation
    __height = 0
    __weight = 0
    __sound = 0
    __location = "" # "" can be used instead of None

    def __init__(self, name, height, weight, sound, location):
        self.__name = name
        self.__height = height
        self.__weight = weight
        self.__sound = sound
        self.__location = location

    def setName(self, name):
        self.__name = name

    def getName(self):
        return self.__name

    def setHeight(self, height):
        self.__height = height

    def getHeight(self):
        return self.__height

    def setSound(self, sound):
        self.__sound = sound

    def getSound(self):
        return self.__sound

    def setLocation(self, location):
        self.__location = location

    def getLocation(self):
        return self.__location

    def getType(self):
        print("Animal")

    def toString(self):
        return "{} is {} cm tall and {} kg and say {} and is from {}".format(self.__name,
                                                                             self.__height,
                                                                             self.__weight,
                                                                             self.__sound,
                                                                             self.__location)


cat = Animal("Silke", 30, 10, 'Meow', "home")
print(cat.toString())

class Cat(Animal): # example of class inheritance
    __owner = ""

    def __init__(self, name, height, weight, sound, location, owner):
        self.__owner = owner
        super().__init__(name, height, weight, sound, location) # should be super(Cat, self).__init__(...)

    def setOwner(self, owner):
        self.__owner = owner

    def getOwner(self):
        return self.__owner

    def getType(self):
        print("Cat")

    def toString(self):
        return "{} is {} cm tall and {} kg and say {} and is from {} and the owner is {}".format(self.__name,
                                                                                                 self.__height,
                                                                                                 self.__weight,
                                                                                                 self.__sound,
                                                                                                 self.__location,
                                                                                                 self.__owner)

    def multipleSounds(self, howMany=None):
        if howMany is None:
            print(self.getSound())
        else:
            print(self.getSound() * howMany)


Luca = Cat("Luca", 33, 7, "Meow", "Hvidovre", "No none")
print(Luca.toString)
