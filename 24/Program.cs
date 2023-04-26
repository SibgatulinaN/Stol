/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */


int Start()
{
System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
return a;
}

int a = Start();

int Summ(int a)
{
int result = 0;
for (int i=1; i<=a; i++)
{
result +=i;
}
return result;
}

int result = Summ(a);
System.Console.WriteLine(result);