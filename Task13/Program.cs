// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
namespace Task13;
class Numbers
{
    static void Main ()
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine()!;
        char [] array = number.ToCharArray();
        string ending = "";
        if (array.Length>2)
        {
            Console.WriteLine($"Третья цифра {array[2]}");
        }
        else
        {
            if (array.Length==0)
                ending = "ов";
            if (array.Length==1)
                ending = "";
            if (array.Length==2)
                ending = "а";
            Console.WriteLine($"Введенное число содержит {array.Length} разряд{ending}, третьей цифры нет.");
        }
    }
}