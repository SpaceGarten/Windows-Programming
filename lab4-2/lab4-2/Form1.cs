def create_word_frequency_dict(filename):
    word_frequency = {}
    
    try:
        with open(filename, 'r') as file:
            for line in file:
                words = line.split()
                for word in words:
                    # Remove punctuation and convert to lowercase
                    word = word.strip(".,!?\"'()[]{}")
                    word = word.lower()
                    
                    if word not in word_frequency:
                        word_frequency[word] = 1
                    else:
                        word_frequency[word] += 1
    except FileNotFoundError:
        print(f"File '{filename}' not found.")
    
    return word_frequency

def display_word_frequency(word_frequency):
    for word, count in word_frequency.items():
        print(f"'{word}': {count}")

def main():
    filename = input("Enter the name of the text file: ")
    word_frequency = create_word_frequency_dict(filename)
    
    if word_frequency:
        print("Word frequency:")
        display_word_frequency(word_frequency)

if __name__ == "__main__":
    main()
