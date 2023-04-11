// Написать программу, которая из имеющегося массива строк, формирует массив из строк,
// длина которых меньше либа равна 3 символа. Первоначальный массив можно ввести с клавиатуры
// или задать на старте выполнения алгоритма. При решении не рекомнуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.


//Решение

string[] array1 = new string[6] { "hello", "computer science", "67p", "wrd", "fw", "work" };
string[] array2 = new string[array1.Length];
void ArraySecond(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArraySecond(array1, array2);
PrintArray(array2);