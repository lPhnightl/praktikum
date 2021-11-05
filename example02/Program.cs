//Задача 2
//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
//Создать на его основе масив B, отбрасывая те, которые нарушают порядок

//возрастания
//элементы, больше 8
//знакочередования

int index = 0;

int[] array = new int[10];

while (index < 10)
{
    array[index] = new Random().Next(-20, 20); 
    index++;
}

index = 0;

Console.WriteLine("Рандомный массив:");
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;

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


Console.WriteLine();
Console.WriteLine("Элементы меньше 8:");
index = 0;

while (index < array.Length)
{
    if (array[index] < 8)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}

Console.WriteLine();
Console.WriteLine("Исключающие взаимочередование:");
index=0;
int currentElements = array[index];
index = 1;
while (index < array.Length)
{
    if (currentElements > 0 && array[index] < 0 || currentElements < 0 && array[index] > 0)
    {
        Console.WriteLine(array[index]);
        currentElements = array[index];
    }
    index++;
}