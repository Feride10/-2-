﻿Console.Clear();
Console.Write ("Введите день недели: ");
int n = Convert.ToInt32 (Console.ReadLine ());
while (n < 1 || n > 7)
{
    Console.Write ("Ошибка! Введите день недели: ");
    n = Convert.ToInt32 (Console.ReadLine ());
}
if (n == 1)
Console.WriteLine ("нет");
else if (n == 2)
Console.WriteLine ("нет");
else if (n == 3)
Console.WriteLine ("нет");
else if (n == 4)
Console.WriteLine ("нет");
else if (n == 5)
Console.WriteLine ("нет");
else if (n == 6)
Console.WriteLine ("да");
else if (n == 7)
Console.WriteLine ("да");
