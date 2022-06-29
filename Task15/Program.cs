// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
namespace Task15;
class Days
{
    static void Main ()
    {
        int WeekDay (int number)
        {
            if (number > 7)
            {
                if (number % 7 == 0)
                number = 7;
                else
                number = number % 7;       
            }
            return number;
        }
        string [] days = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
        Console.WriteLine("Введите цифру: ");
        int index = WeekDay(Convert.ToInt32(Console.ReadLine()))-1;
        if (index<0)
            Console.WriteLine("Ошибка при вводе данных, повторите попытку.");
        else
            Console.WriteLine(days[index]);
    }
}