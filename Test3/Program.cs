/*
    Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
    456 => 10
    782 => 9
    918 => 17
*/

// Вариант_1:
/*
int a = 918;

int a1 = a / 100;
int a2 = a % 10;

int sum = a1 + a2;
System.Console.WriteLine(sum);
*/

// Вариант_2:
/*
int n = 10;
double double_n = n;

Console.WriteLine(n % 3); // Получаем остаток от деления 1
Console.WriteLine(n / 3); // Делим на три целочисленную переменную получаем 3
Console.WriteLine(double_n / 3); // делим на 3 дробную переменную получаем 3.33333333
*/

// Вариант_3
/*
int n = 12345;

Console.WriteLine(n % 10); // Получаем остаток от деления 5
Console.WriteLine(n / 10);

Console.WriteLine();

Console.WriteLine(n / 100);
Console.WriteLine(n % 100);
*/

// Вариант_4: В цикле While с подсчетом количества цифр
/*
int n = 12345;
int count = 0;

while (n > 0)
{
    count ++;
    int perm = n % 10;          // (а эту строку удалить)Переменную если она ни где не используется можно поместить  -
    Console.WriteLine(perm);    // Console.WriteLine(n % 10);

    n /= 10;
    
}
Console.WriteLine();
Console.WriteLine(count);
*/

// Вариант_4: В цикле For

int n = 78965;
int count = 0;

for (; n > 0; n /= 10)
{
    Console.WriteLine(n % 10);
    count++;
}
Console.WriteLine(count);