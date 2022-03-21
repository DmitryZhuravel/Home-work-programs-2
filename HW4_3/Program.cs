// Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. Оформите 
// заполнение массива и вывод в виде функции (пригодится 
// в следующих задачах)
int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random(); 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next();
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write(array[array.Length-2] + "]");
}