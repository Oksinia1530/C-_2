/* Напишите программу, которая выводит третью
цифру заданного числа или сообщает,
что третьей цифры нет.*/

Console.Clear();

Console.WriteLine("Enter a number ");
int A = int.Parse(Console.ReadLine()!);
int A2 = A % 10;
if (A2 > 0)
{
Console.WriteLine ($"{A2}");
}
else if (A2 < 0)
{
    Console.WriteLine ("No");
}