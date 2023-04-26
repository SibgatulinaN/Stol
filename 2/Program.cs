 /* 11. Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
 */
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

void task1 ()
{
    Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(TwoNumber(number));
}

int TwoNumber (int number)
{
    int a = number / 100;
    int b = number % 10;
    return a*10 + b;
}
 
 int i = GetRandom();
System.Console.WriteLine(i);
;

int GetRandom()
{
    return new Random().Next(100, 1000);
}

int RemoveSecondDigit(int number)
{
    int lastNumber = number % 10;
    int firstNumber = number / 100;
    int result = firstNumber*10+lastNumber;
    return result;
} 