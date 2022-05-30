import sys
import datetime
from math import *
import calendar

def _001():
    print("\n\t- Write a Python program to print the following string in a specific format")
    print("Twinkle, twinkle, little star,"
          "\n\tHow I wonder what you are!"
          "\n\t\tUp above the world so high,"
          "\n\t\tLike a diamond in the sky."
          "\nTwinkle, twinkle, little star,"
          "\n\tHow I wonder what you are")
    return 0

def _002():
    print("\n\t- Write a Python program to get the Python version you are using.")
    print("- Python version")
    print(sys.version)
    print("- Version info.")
    print(sys.version_info)

def _003():
    print("\n\tWrite a Python program to display the current date and time.")
    now = datetime.datetime.now()
    print("- Current date and time : ")
    print(now.strftime("%Y-%m-%d %H:%M:%S"))

def _004():
    print("\n\t- Write a Python program which accepts the radius of a circle from the user and compute the area.")
    radius = float(input("- Radius: "))
    area = pi * radius * radius
    print("The area is: " + str(area))

def _005():
    print("\n\tWrite a Python program which accepts the user's"
          "first and last name and print them in reverse order with a space between them.")
    fn = input(" First name: ")
    ln = input(" Last name: ")

    print(ln + " " + fn)

def _006():
    print("\nWrite a Python program which accepts a sequence of comma-separated numbers"
          "from user and generate a list and a tuple with those numbers.")
    values = input("Input the numbers separated by commas: ")
    _list = values.split(",")
    _tuple = tuple(list)
    print("List: ", _list[1])
    print("Tuple: ", _tuple[-1])

def _007():
    print("\nWrite a Python program to accept a filename from the user and print the extension of that.")
    filename = input("Input the file name: ")
    f_ext = filename.split(".")
    print("The extension is: " + repr(f_ext[-1]))

def _008():
    print("\nWrite a Python program to display the first and last colors from the following list.")
    color = input("Input the colors: ")
    _list = color.split(",")
    print(_list[0] + " " + _list[-1])

def _009():
    print("\nWrite a Python program to display the examination schedule. (extract the date from exam_st_date).")
    exam_st_date = (11, 12, 2014)
    print("The examination will start from : %i / %i / %i" % exam_st_date)

def _010():
    print("\nWrite a Python program that accepts an integer (n) and computes the value of n+nn+nnn.")

    n = int(input("Insert the number to calculate n + n*n + n*n*n: "))
    _final = n + n * n + n * n * n
    _finals = str(_final)
    print("The result of n + n*n + n*n*n is " + _finals)

def _011():
    print("\nWrite a Python program to print the documents (syntax, description etc.) of Python built-in function(s).")
    print(abs.__doc__)

def _012():
    print("\nWrite a Python program to print the calendar of a given month and year.")

    print("Input the year: ")
    _012_year = int(input())
    print("Input the month: ")
    _012_month = int(input())
    print("\n" + calendar.month(_012_year, _012_month))

def _013():
    print("\nWrite a Python program to print the following 'here document'.")

    print("""
    a string that you "don't" have to escape
    This
    is a  ....... multi-line
    heredoc string --------> example
    """)

def _014():
    print("\nWrite a Python program to calculate number of days between two dates.")

    _014_year = input(print("Introduce the year of the first date: "))
    print(_014_year)
    _014_yeari = int(_014_year)
    print(_014_yeari)
    _014_month = input(print("Introduce the month of the first date: "))
    _014_monthi = int(_014_month)
    _014_day = input(print("Introduce the day of the first date: "))
    _014_dayi = int(_014_day)

    _14_date1 = datetime.date(_014_yeari, _014_monthi, _014_dayi)

    _014_year = input(print("Introduce the year of the second date: "))
    _014_yeari = int(_014_year)
    _014_month = input(print("Introduce the month of the second date: "))
    _014_monthi = int(_014_month)
    _014_day = input(print("Introduce the day of the second date: "))
    _014_dayi = int(_014_day)

    _14_date2 = datetime.date(_014_yeari, _014_monthi, _014_dayi)

    _014_difference = _14_date2 - _14_date1

    _014_differences = str(_014_difference)

    print("The difference in the dates is " + _014_differences)

def _015():
    print("\nWrite a Python program to get the volume of a sphere with radius 6.")

    print("\nInput the radius of the circle: ")
    _015_radius = int(input())

    _015_volume = (4/3) * pi * (_015_radius * _015_radius * _015_radius)

    print("\nThe volume is: ", _015_volume)

def _016():
    print("\nWrite a Python program to get the difference between a given number and 17,"
          "if the number is greater than 17 return double the absolute difference.")
    print("Insert the number: ")

    _016_number = int(input())

    if _016_number > 17:
        print("The result is: " + str(2 * (_016_number - 17)))
    else:
        print("The result is: " + str(17 - _016_number))

def _017():
    print("\nWrite a Python program to test whether a number is within 100 of 1000 or 2000.")

    print("Insert the number: ")
    _017_number = int(input())
    print(_017_number)

    if _017_number >= 900 | _017_number <= 1100:
        print("The number is within 100 of 1000.")
    elif _017_number >= 1900 | _017_number <= 2100:
        print("The number is within 100 of 2000.")
    else:
        print("The number is not within 100 of 1000 either of 2000")
    return 0

def _018():
    print("\nWrite a Python program to calculate the sum of three given numbers,"
          "if the values are equal then return three times of their sum.")

    print("Insert the first number: ")
    _018_first = int(input())
    print("Insert the second number: ")
    _018_second = int(input())
    print("Insert the third number: ")
    _018_third = int(input())

    if (_018_first == _018_second) & (_018_second == _018_first):
        _018_sum = (_018_first + _018_second + _018_third) * 3
        print("The sum is: " + str(_018_sum))
    else:
        _018_sum = _018_first + _018_second + _018_third
        print("The sum is: " + str(_018_sum))

def _019():
    print("\nWrite a Python program to get a new string from a given string where \"Is\" has been added to the front."
          "If the given string already begins with \"Is\" then return the string unchanged.")

    print("Insert the string: ")
    _019_string = input()

    _019_list = _019_string.split(" ")

    i = 0

    if _019_list[0] == 'Is':
        while i <= sys.getsizeof(_019_list):
            print(_019_list[i])
            i = i + 1
    else:
        print("Is" + _019_string)

def _020():
    print("\nWrite a Python program to get a string which is n (non-negative integer) copies of a given string.")

    print("Insert the string: ")
    _020_string = input()
    print("Insert the number of times you want the string repeated: ")
    _020_number = int(input())

    i = 0

    while i < _020_number:
        print(_020_string)
        i = i + 1


class Main:
    # print("\n\nInsert the name of the exercise you want to use: ")
    _option = int(input('Enter the exercise: '))

    while _option != 0:
        if _option == 1:
            _001()
            _option = -1
        if _option == 2:
            _002()
        if _option == 3:
            _003()
        if _option == 4:
            _004()
        if _option == 5:
            _005()
        if _option == 6:
            _006()
        if _option == 7:
            _007()
        if _option == 8:
            _008()
        if _option == 9:
            _009()
        if _option == 10:
            _010()
        if _option == 11:
            _011()
            _option = 0
        if _option == 12:
            _012()
        if _option == 13:
            _013()
            _option = 0
        if _option == 14:
            _014()
        if _option == 15:
            _015()
            _option = 0
        if _option == 16:
            _016()
        if _option == 17:
            _017()
            _option = 0
        if _option == 18:
            _018()
            _option = 0
        if _option == 19:
            _019()
        if _option == 20:
            _020()
