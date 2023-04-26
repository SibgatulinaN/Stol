/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateArray(int Length)
{
    int[] numbers = new int[Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-1000, 1000);
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

void Even(int[] numbers)
{
    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2)
    {
         sum += numbers[i];

        
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях {sum}");
}


int Length = Num("введите длину массива");
int[] numbers = CreateArray(Length);
PrintArray(numbers);
System.Console.WriteLine(" ");
Even(numbers);


