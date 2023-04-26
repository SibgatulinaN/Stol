/* /* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20. */






 int[] CreateArray(int Length, int min, int max)
{
    int[] numbers = new int[Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max + 1);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.Write(numbers[numbers.Length - 1] + "]");
}

int Num(string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int PositivSum(int[] numbers)
{
    int Sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            Sum += numbers[i];
        }
    }
    return Sum;
}

int NegativSum(int[] numbers)
{
    int Sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            Sum += numbers[i];
        }
    }
    return Sum;
}
int Length = Num("введите длину массива");

int min = Num("введите минимум");
int max = Num("введите максимум");
int [] number = CreateArray(Length, min, max);
PrintArray(number); 
System.Console.WriteLine(PositivSum(number));
System.Console.WriteLine(NegativSum(number)); 