/* Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого
числа */

Console.Clear();

Console.WriteLine("ВВедите трехзначное число  ");
int A = int.Parse(Console.ReadLine()!);

int B = ((A / 10) % 10);

Console.WriteLine($"Second number {B}");
