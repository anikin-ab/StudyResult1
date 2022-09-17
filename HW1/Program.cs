/*
Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
Console.WriteLine("введите размер массива: ");
int size = int.Parse(Console.ReadLine());

string [] NewArray = GetArray(size);

string [] GetArray(int size1) //создаем метод ручного ввода элем массива
{
    string [] arr = new string[size1];
    for (int i=0; i<size; i++)
    {
        Console.WriteLine("input text:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
Console.WriteLine("начальный массив:");
Console.WriteLine($"[{String.Join(",", NewArray)}]");
Console.WriteLine();


Console.WriteLine("массив, в котором длина элемента менее 4 символов:");
string [] NewArray1 = Fillarray2(NewArray); //инициализация нового массива

string [] Fillarray2 (string [] array) // метод поиска длины нового массива и его заполнения
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length < 4 )
        {
            count++;
        }
    }
    int size2 = count;
    string [] array2 = new string [size2];
        for (int i = 0, j=0; i < size; i++)
    {
        if (array[i].Length < 4 )
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}
Console.WriteLine($"[{String.Join(", ", NewArray1)}]");
