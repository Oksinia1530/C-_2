/* Напишите программу, которая принимает на вход два
числа и проверяет, является ли одно число квадратом
другого */
Console.Clear();
Console.WriteLine("enter A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter B");
int B = int.Parse(Console.ReadLine()!);

if (B * B == A | A * A == B) 
{

    Console.WriteLine("YES");

}
else 
{

    Console.WriteLine("No");

}
