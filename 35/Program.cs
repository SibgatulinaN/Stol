/* Задача 35: Задайте одномерный массив из 123 случайных
чисел. Найдите количество элементов массива, значения
которых лежат в отрезке [10,99]. ОТ -100 ДО 200
Пример для массива из 5, а не 123 элементов. В своём решении сделайте
для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int CreateArray()
{
    System.Console.Write("Введите длину массива: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int[] Array = new int[CreateArray()];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-100, 201);
    System.Console.Write($"{Array[i]}; ");
}

void Task(int[] Array)
{

    int count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= 10 && Array[i] <= 99)
        {
            count++;
        }
    }

    System.Console.WriteLine(count);

}
System.Console.WriteLine(" ");
Task(Array);