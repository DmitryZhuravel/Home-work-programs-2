// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Proisv(int Value)
{
    int fact = 1;
    if (Value < 1)
    {
        for (int i = 1; i >= Value; i--)
        {
            fact *= i;
        } 
    }
        else if (Value > 1)
        {
            for (int i = 1; i <= Value; i++)
            {
                fact *=i;
            }
        }
return fact;
}

    int N = Prompt("Введите число => ");
    int F = Proisv(N);
    Console.WriteLine($"Произведение числе от 1 до {N} равно {F}");