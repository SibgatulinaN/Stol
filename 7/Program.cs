/* Задача 18: Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y). */





  /*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

int Read()
{
    System.Console.WriteLine("Ведите номер четверти: ");
    int number = int.Parse(Console.ReadLine());
   /* if (number<1 || number>4)
    {
        System.Console.WriteLine("неверный номер четверти");
    }*/
    return number;
}

int number = Read();


string Coordinats(int number)
{
    if (number == 1)
    {
       return "x>0, y>0";  
    } 
    else if (number == 2) return "x<0, y>0";
    else if (number == 3) return "x>0, y<0";
    else return "x<0, y<0";
}

if (number<1 || number>4) System.Console.WriteLine("неверный номер четверти");
else System.Console.WriteLine($"Координаты в диапазоне - {Coordinats(number)}");  