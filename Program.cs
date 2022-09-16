string[] unFilteredArray = {"1234", "1567", "-2", "computer science"};

static string[] GetFilteredArray(string[] Arr) {
    Console.WriteLine ("Введите массив: ");
    string str = Console.ReadLine();
    string[] arrayFromString = str.Split(' ');
    Console.WriteLine(arrayFromString);
    string[] filteredArray = arrayFromString.Where(str => str.Length <= 3).ToArray();
    return filteredArray;
}
