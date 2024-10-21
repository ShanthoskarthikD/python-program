def convert_to_words(number):
    digits = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
    return ' '.join(digits[int(digit)] for digit in str(number))
number = 357546
print(f"Output: {convert_to_words(number)}")