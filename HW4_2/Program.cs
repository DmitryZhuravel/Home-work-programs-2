// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
//Console.Write("Введите число => ");
//string a =Console.ReadLine();

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int a = Prompt("Введите число => ");
int[] arr = new int[a.Length];
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    arr[i] = int.Parse(a[i].ToString());
    sum+=arr[i];
}    
Console.WriteLine(sum);
//string inputString = "";
//    do
//{
//    Console.WriteLine("Введите слово длиной в 7 символов");
//    inputString = Console.ReadLine();
//}
//while (inputString.Length != 7);
//int a = int.Parse(Console.ReadLine());
//            int s = 0;
//            while (a > 0)
//            {

//                s = s + a % 10;
//                a = a /10 ;

//            }
//Console.WriteLine(s);


//int[] arr = Prompt("Введите число => ");
//int answer=Main((int[])arr);
//static void Main(string[] args)
//{
//    Console.WriteLine(Sum(5));
//}
//static int Sum(int value)
//{
//    int result = 0;
//    result += value % 10;
//    value /= 10;
//    if (value > 0)
//    {
//        result += Sum(value);
// ///   }
//    return result;
//}
//int a=Main();
//int[] Prompt(string message)
//{
 //   Console.Write(message);
 //   string strInput = Console.ReadLine();
 //   int[] arr = new int[strInput.Length];
 //   for (int i = 0; i < strInput.Length; i++)
 //   {
//        arr[i] = Convert.ToInt32(strInput.Substring(i, 1));
 //   }
 //   return (int[])arr;
//}
//int a = Prompt("Введите число => ");
//int sum=Sum(a);
//Console.WriteLine(sum);

//int Prompt(string message)
//{
//    Console.Write(message);
//    string strInput = Console.ReadLine();
//    int answer = int.Parse(strInput);
//    return answer;
//}

//int Sum(int value)
//{
 //   int result = 0;
 //   result += value % 10;
 //   value /= 10;
 //   if (value > 0)
 //   {
  //      result += Sum(value);
  //  }
 //   return result;
//}