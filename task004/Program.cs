/* Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно
7 и 23.*/

Console.Clear();

Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine()!);


if  (A % 7 == 0 && A % 23 == 0)
{

    Console.WriteLine("YES");

}
else 
{

    Console.WriteLine("No");

}