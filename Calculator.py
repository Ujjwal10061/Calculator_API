def add(a, b):
    return a + b

def subtract(a, b):
    return a - b

def multiply(a, b):
    return a * b

def divide(a, b):
    if b == 0:
        print("Division by zero!")  # Issue: Should raise an exception instead of printing
        return None
    return a / b

def calculate():
    operation = input("Enter operation (+, -, *, /): ")
    num1 = input("Enter first number: ")
    num2 = input("Enter second number: ")
    
    # Intentional error: inputs are not converted to float
    if operation == '+':
        result = add(num1, num2)  
    elif operation == '-':
        result = subtract(num1, num2)
    elif operation == '*':
        result = multiply(num1, num2)
    elif operation == '/':
        result = divide(num1, num2)
    else:
        print("Invalid operation")
        return

    print(f"Result: {result}")

calculate()
