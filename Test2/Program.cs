/*
    Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые
числа в промежутке от -N до N.
Примеры:
    4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
    2 => -2, -1, 0, 1, 2
*/

// Вариант 1:

// int n = -4;

// if (n < 0 )
// {
//     n = -n;
// }
// int i = -n;
// while (i<=n)
// {
//     System.Console.Write(i);
//     System.Console.Write(' ');
//     i++;
// }

// Вариант 2:


Console.WriteLine("Enter a number:  ");
int n = int.Parse(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    System.Console.Write(i + " ");
}

Console.ReadKey();