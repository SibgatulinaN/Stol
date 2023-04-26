/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
task(Read());
int Read()
{
    System.Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine());
    return number;
}



void task(int n)
{
    int a = 0;
    while (n > 1)
    {

        a++;
        n = n / 10;
    }

    System.Console.WriteLine(a);
}


/* task(Read());

int Read()
{
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
return number;
}



void task(int n)
{

int a = 0;
while(n > 1)
{
a++;
n = n/10;

}
Console.WriteLine(a);
}  */