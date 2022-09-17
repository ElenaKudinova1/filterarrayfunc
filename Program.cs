string[] unFilteredArray = {"1234", "1567", "-2", "computer science"};

void GetFilteredArray(string[] Arr) {
    Console.WriteLine ("Введите массив: ");
    string str = Console.ReadLine();
    string[] arrayFromString = str.Split(' ');
    string[] filteredArray = arrayFromString.Where(str => str.Length <= 3).ToArray();
    for (int i = 0; i < filteredArray.Length; i ++) {
        Console.WriteLine(filteredArray[i]);
    }
}
GetFilteredArray(unFilteredArray);