// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
int a = Prompt("Введите число A => ");
int b = Prompt("Введите число B => ");
int level=Level(a, b);
Console.WriteLine(level);

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Level (int a, int b)
{
    int pow=1;
    for (int i = 0; i < b; i++) pow *= a;
    return pow;
}

