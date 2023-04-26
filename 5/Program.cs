/* 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */
 Main();
void Main()
{
    System.Console.WriteLine("Введите число a");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число b");
int num2 = int.Parse(Console.ReadLine());

bool magic = Magic(num1, num2)||Magic(num2,num1);
if (magic)Console.WriteLine( "да");
else Console.WriteLine( "нет");
}

bool Magic (int num1, int num2)
{
    return  num1 * num1 == num2;
 }

