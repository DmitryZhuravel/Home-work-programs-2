// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
Console.Write("Введите число => ");
string a =Console.ReadLine();
int[] arr = new int[a.Length];
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    arr[i] = int.Parse(a[i].ToString());
    sum+=arr[i];
}    
Console.WriteLine(sum);