/* 12. Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. Если число 2 
не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

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
            case "y": Osn(); break;
            case "n": Work = false; break;
        }

    }
}
void Osn()
{
    Console.WriteLine("Введите первое число");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = int.Parse(Console.ReadLine());

    int a = Magic(num1, num2);
    if (a == 0)
        System.Console.WriteLine($"Число {num1} кратно {num2}");
    else
        System.Console.WriteLine($"Число {num1} не кратно {num2}, остаток {a}.");
}
int Magic(int number1, int namber2)
{
    int a = number1 % namber2;
    return a;
}

