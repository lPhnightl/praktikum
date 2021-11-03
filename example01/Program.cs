// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// Задать массив



int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив
Console.WriteLine("Рандомный массив:");
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
Console.WriteLine("Отсортированный массив по возростанию:");
Console.WriteLine(currentElement);
while (index <= 9)
{
    if (array[index] > currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}


index = 0;
int sum = 0;

while (index < array.Length)
{
    sum = sum + array[index];
    index++;
}

int aref = sum / array.Length;
Console.WriteLine();
Console.WriteLine($"Среднее арефмитическое: {aref}");
Console.WriteLine();

index = 0;
Console.WriteLine("Меньше среднего ареф. массива А");
while (index < array.Length)
{
    if (aref > array[index])
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
Console.WriteLine();

index = 0;
Console.WriteLine("Нечетные:");
while (index < array.Length)
{
    if (array[index] % 2 != 0)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}

