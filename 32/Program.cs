/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */
 
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

int[] GetOppositivMarks(int[] numbers)
{
    int [] array = numbers.ToArray();
    for (int i = 0; i < numbers.Length; i++)
    {
        array[i]= -numbers[i];
        
    }
   return array;
}

int Length = Num("введите длину массива");

int min = Num("введите минимум");
int max = Num("введите максимум");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers); 
PrintArray(GetOppositivMarks(numbers));

