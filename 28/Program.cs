/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int number()
{
    System.Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int N = number();
Print(N);

int Mult(int N)
{
    int Mult = 1;

    for (int i = 1; i <= N; i++)
    {

        Mult = Mult * i;
    }
    return Mult;
}
void Print (int X)
{
System.Console.WriteLine($"Произведение равно {Mult (X)}");
}

/* int GetSmth<T>(T smth, T anth) where T : IComparable
{
return smth.CompareTo(anth);
}
 */