/* Напишите программу, которая выводит
 случайное число из отрезка [10, 99] 
 и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8 */
Main();

void Main() 
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = System.Console.ReadLine();
        switch (a) 
        {
            case "y":task1();break;
            case "n": Work = false; break;
        }

    }
}

void task1()
{
    System.Console.WriteLine("1 порог");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("2 порог");
    int num2 = int.Parse(Console.ReadLine());
    int number = GetRandom(num1, num2);
    System.Console.WriteLine($"Рандомное число - {number}");
    System.Console.WriteLine($"Наибольшая цифра - {FindTheBig(number)}");
}
int GetRandom (int num1, int num2)
{
    return new Random().Next(num1, num2+1 );
}
int FindTheBig (int number)
{
    int LastNumb = number % 10;
    int FirstNumb = number / 10;
    if (LastNumb > FirstNumb) return LastNumb;
    return FirstNumb;
}