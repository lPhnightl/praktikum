//Почувствуй себя интерном
// 0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет



int squareNumber(int arg)
{
    return arg * arg;
}


Console.WriteLine("Квадрат числа:");
Console.WriteLine(squareNumber(5));
Console.WriteLine();

int a = 4;
int b = 2;
Console.WriteLine("Является ли первое квадратом второго:");
{
    if (a == b * b)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}
Console.WriteLine();
Console.WriteLine("Большее и меньшее:");
int NumberMax(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine($"Max = {num1} Min = {num2}");
        return num1;
    }
    else
    {
        Console.WriteLine($"Max = {num2} Min = {num1}");
        return num2;
    }
}

Console.WriteLine(NumberMax(16, 28));

// Console.WriteLine("Введите номер дня недели");
// int day = Convert.ToInt16(Console.ReadLine());
// string DayName( int number)
// {
//     string result = string.Empty;
//     if(number == 1) result = result + "Monday";
//     if(number == 2) result = result + "Tuesday";
//     if(number == 3) result = result + "Wednesday";
//     if(number == 4) result = result + "Thursday";
//     if(number == 5) result = result + "Friday";
//     if(number == 6) result = result + "Saturday";
//     if(number == 7) result = result + "Sunday";
//     return result;
// }
// if (day < 1 || day > 7 )
//     {
//         Console.WriteLine("ТЫ БАРАН.");
//         return;
//     }
//     else
//     {
//     Console.WriteLine($"Этот день недели на английском будет называться {DayName(day)}");
//     }


int MaxNumber(int num1, int num2, int num3)
{
    int max = num1;
    if (max < num2) max = num2;
    if (max < num3) max = num3;
    return max;
}

Console.WriteLine();
Console.WriteLine("Максимальное из трёх:");
Console.WriteLine(MaxNumber(4, 8, 1));

double Function(int a, int P)
{
    double sinAngle = Math.Pow(Math.Sin(a), P);
    return sinAngle;
}
Console.WriteLine();
Console.WriteLine("y=f(a):");
Console.WriteLine(Function(4, 6));
Console.WriteLine();
Console.WriteLine("Проверяем число на чётность:");
int even = 5;
if (even % 2 == 0)
{
    Console.WriteLine("True");

}
else
{
    Console.WriteLine("False");
}

void Method3(int numbers)
{
    int startNumbers = -numbers;
    for (int index = -numbers; index <= numbers; index++)
    {
        Console.Write($" {startNumbers} ");
        startNumbers++;
    }
}
Console.WriteLine();
Console.WriteLine("Числа от -N до N:");
Method3(100);