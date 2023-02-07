// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Enter the number of the day of the week ");
int A = int.Parse(Console.ReadLine()!);
if (A == 1 || A == 2 || A == 3 || A == 4 || A == 5)
{
    Console.WriteLine("Go to work ");
}

else if (A == 6 || A == 7)
{

 Console.WriteLine("Hooray!Day off");

}
else if (A >=8)

{

 Console.WriteLine("Error");

}