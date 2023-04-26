/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
//SumDigit();


int Read(string nun)
{
    int number;
    System.Console.WriteLine($"inpup : ");
    while ((!int.TryParse(Console.ReadLine(), out number)) || number <= 0)
    {
        System.Console.WriteLine("Not a number");
    }
    return number;
}


int number = Read("number");
int sumDigit = (SumDigit(number));


int SumDigit(int num)
{
    int result = 0;


    while (num > 0)
    {

        result += num % 10;
        num = num / 10;

    }
    return result;

}
Console.WriteLine($"Сумма чисел числа {number} = {sumDigit}");