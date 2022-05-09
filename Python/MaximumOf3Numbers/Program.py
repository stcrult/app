def checkNumbers(firstNumber, secondNumber, thirdNumber):
    if (firstNumber > secondNumber):
        if (firstNumber > thirdNumber):
            print("First number is the greatest number")
        elif (thirdNumber > firstNumber):
            print("Third number is the greatest number")
        else:
            print("First and Third numbers are equal and greater than Second number")
    elif (secondNumber > firstNumber):
        if (secondNumber > thirdNumber):
            print("Second number is the greatest number")
        elif (thirdNumber > secondNumber):
            print("Third number is the greatest number")
        else:
            print("Second and Third numbers are equal and greater than First number")
    else:
        if (thirdNumber > firstNumber):
            print("Third number is the greatest number")
        elif (firstNumber > thirdNumber):
            print("First and Second numbers are equal and greater than Third number")
        else:
            print("Numbers are equal")
