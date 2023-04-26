/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */


    int Read(string argument)
{
int number;
System.Console.WriteLine($"inpup {argument}: ");
while((!int.TryParse(Console.ReadLine(), out number)))
{
System.Console.WriteLine("Not a number");
}
return number;
}

double Legth()
{
int x1 = Read("x1");
int y1 = Read("y1");
int x2 = Read("x2");
int y2 = Read("y2");
double Length = Math.Round(Math.Sqrt(Math.Pow( x1 - x2, 2 ) + Math.Pow( y1 - y2, 2 )), 3);
return Length;
}

void Answer()
{
double L = Legth();
System.Console.WriteLine($"Segment length = {L}");
}

Answer();
