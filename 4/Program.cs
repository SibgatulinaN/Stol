/* 4. Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */



System.Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());


bool Isfor7and23(int number)
{
return number %7 == 0 && number % 23 == 0;
}

if(Isfor7and23 (a))
{
System.Console.WriteLine("Да");
}
else
{

System.Console.WriteLine("нет");
}