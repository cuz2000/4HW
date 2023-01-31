// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число для возведения в степень");
int.TryParse(Console.ReadLine(), out int n);

if (n < 1)
{
    Console.WriteLine("Число должно быть положительным");
    return;
}

Console.WriteLine("Введите натуральное число степени");
int.TryParse(Console.ReadLine(), out int y);

if (y < 1)
{
    Console.WriteLine("Число должно быть положительным");

}

int Degree(int n, int y)
{
    int result = 1;
    int counter = 0;
    while (counter <= y)
    {
        result *= n;
        counter++;

    }

    return result;
}
int result = Degree(n,y);
Console.WriteLine($"Результат: {result/n}");


// в 38 строке костыль, тк так и не додумалась до нужной формулы(