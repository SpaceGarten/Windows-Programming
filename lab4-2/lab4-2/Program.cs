def is_prime(num):
    if num <= 1:
        return False
    if num <= 3:
        return True
    if num % 2 == 0 or num % 3 == 0:
        return False
    i = 5
    while i * i <= num:
        if num % i == 0 or num % (i + 2) == 0:
            return False
        i += 6
    return True

def display_prime_numbers(start):
    print(f"Prime numbers greater than or equal to {start}:")
    count = 0
    num = start
    while True:
        if is_prime(num):
            print(num, end=" ")
            count += 1
        if count == 10:  # Change this number to display a different count of prime numbers per line
            print()       # Print a new line after displaying the specified count of prime numbers
            count = 0
        num += 1

if __name__ == "__main__":
    try:
        n = int(input("Enter an integer greater than 1: "))
        if n <= 1:
            print("Please enter an integer greater than 1.")
        else:
            display_prime_numbers(n)
    except ValueError:
        print("Invalid input. Please enter a valid integer.")
