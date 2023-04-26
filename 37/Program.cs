/* Задача 37: Найдите произведение пар чисел в одномерном
массиве. Парой считаем первый и последний элемент, второй
и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


int[] CreateArray(int Length, int min, int max)
{
int[] array = new int [Length];
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min,max + 1);
}
return array;
}

void PrintArray(int[] number)
{
System.Console.Write("[ ");
for (int i = 0; i < number.Length-1; i++)
{
System.Console.Write(number[i] + "; ");
}
System.Console.WriteLine($"{number[number.Length - 1]} ]");
}

int ReadInt(string argument)
{
System.Console.WriteLine($"Input {argument}: ");
return int.Parse(Console.ReadLine());
}

int[] Product(int[] array)
{
int[] newArray = new int[array.Length/2];
for (int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[array.Length - 1 - i] * array[i];
}
return newArray;
}

int length = ReadInt("a length array");
int min = ReadInt("a min number of array");
int max = ReadInt("a max number of array");
int [] arr = CreateArray(length, min, max);
PrintArray(arr);
PrintArray(Product(arr));