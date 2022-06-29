// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
namespace Task10;
class Numbers
{
    static void Main ()
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine()!;
        char [] array = number.ToCharArray();
        if (array.Length>1)
        {
            Console.WriteLine(array[1]);
        }
        else
            Console.WriteLine("Введенные данные не соответсвуют условиям, попробуйте еще раз");
    }
}