/* Задача 22: Напишите программу,
которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел от 1 до
N.
5 -> 1, 4, 9, 16, 25
2 -> 1,4 */

/* int Read(string argument)
{
int number;
System.Console.WriteLine($"inpup {argument}: ");
while((!int.TryParse(Console.ReadLine(), out number)) || number < 0)
{
System.Console.WriteLine("Not a number");
}
return number;
}

void Line()
{
int N = Read("N");
for(int i = 1; i <= N; i++)
{
double Square = Math.Pow(i,2);
System.Console.Write($" {Square};");
}
} */

Line();

int Read(string argument)
{
int number;
System.Console.WriteLine($"inpup {argument}: ");
while((!int.TryParse(Console.ReadLine(), out number)) || number < 0)
{
System.Console.WriteLine("Not a number");
}
return number;
}

void Line()
{
int N = Read("N");
for(int i = 1; i <= N; i++)
{
double Square = Math.Pow(i,2);
System.Console.Write($" {Square};");
}
}

