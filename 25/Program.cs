/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


 

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberB = Convert.ToInt32(Console.ReadLine());


{
int expon = Expon(numberA);
Console.WriteLine($"Степень чисела  {numberA} = {expon}");


int Expon(int num)
{
int expo = 1;
for (int i = 0; i < numberB; i++)
{
   expo *= numberA; 
   
}
return expo;
}
}
