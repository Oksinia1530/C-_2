/* Напишите программу, которая выводит третью
цифру заданного числа или сообщает,
что третьей цифры нет.*/

Console.Clear();

Console.WriteLine("Enter a number ");
int A = int.Parse(Console.ReadLine()!);
int A2 = A % 10;
if (A < 100)
{
    Console.WriteLine("No third digit");

}

else
{
    Console.WriteLine($"Third digit {A2}");
}
