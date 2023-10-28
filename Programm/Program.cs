string[] getEditedArray(string[] array, int maxLength) {
    int counter = 0;
    int length = array.Length;
    int[] indicators = new int[length];

    for (int i = 0; i < length; i++) {
        if (array[i].Length <= maxLength) {
            indicators[i] = 1;
            counter++;
        }
    }

    string[] result = new string[counter];
    for (int i = length - 1; i >= 0; i--) {
        if (indicators[i] == 1) {
            counter--;
            result[counter] = array[i];
        }
    }
    return result;
}

void PrintArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($" {array[i]}");
    }
}

string[] numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

Console.Write("Измененный массив:");
PrintArray(getEditedArray(numbers, 3));