// Рубежная контрольная работа
// **Задача**: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using static System.Console;
Console.Clear();

string[] array = {"1234", "1567", "-2", "computer science"};

WriteLine(String.Join(" ", MakeNewArray(array, NumberOfElements(array))));



int NumberOfElements (string[] arr) { // Подсчет числа элементов <= 3
    int count = 0;
    foreach (string element in arr) {
        if (element.Length <= 3) count++;
    }
    return count;
}

string[] MakeNewArray (string[] arr, int len) { // Заполняем новый массив.
    string[] newarray = new string[len];
    int index = 0;
    foreach (string element in arr) {
        if (element.Length <= 3) {
            newarray[index] = element;
            index++;
        }
    }
    return newarray;
}