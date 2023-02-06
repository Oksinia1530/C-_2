/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, топрограмма выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно 8 */
 
Console.Clear();

Console.WriteLine("Enter first");
int first = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second");
int second = int.Parse(Console.ReadLine()!);


int ost = first % second;
if (ost == 0) Console.WriteLine($"Число {first} кратное {second}");
else Console.WriteLine($"Остаток от деления {ost}");