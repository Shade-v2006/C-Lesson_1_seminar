/* // Первая задача:

int firstNumber = 3;
int secondNumber = 3;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("первое число больше");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine("второе число больше");
        }
        else
        {
            Console.WriteLine("числа равны");
        }
*/

/* // /Вторая задача

using System;

public class Answer
{

    static int FindMax(int a, int b, int c)
    {
        // Введите свое решение ниже
        int FindMax = a;
        if (FindMax > b)
        {
            if (FindMax > c)
            {
                FindMax = a;
            }
            else
            {
                FindMax = c;
            }
        }
        else
        {
            if (b > c)
            {
                FindMax = b;
            }
            else
            {
                FindMax = c;
            }
        }

        return FindMax;

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            a = 5;
            b = 6;
            c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}
*/

/* // Третья задача Чет не чет

using System;

class Answer
{
    static void CheckIfEven(int number)
    {
        // Введите свое решение ниже
       if ((number%2) > 0)
        {
            Console.WriteLine("нечетное");
        }
        else
        {
            Console.WriteLine("четное");
        }


    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 7;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}
*/

// Четвертая задача
using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже
        for (int i = 0; i <= number; i++)
        {
            if (i > 0)
            {
                if ((i % 2) == 0)
                {
                    System.Console.Write(i);
                    System.Console.Write(" ");
                }
            }

        }




    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
