// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Middle(int number)
{
    int digit = number / 10 % 10;
    return digit;
}
Console.WriteLine("Введите трехзначное число:");
int Numb = Convert.ToInt32(Console.ReadLine());
int Nam = Middle(Numb);
Console.WriteLine($" Число по середине: {Nam}");
*/
    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int IsTherd(int number)
{
    int digit = number;
        int s = 1;
        if (number > 99)
    {
            while (digit > 0)
                digit = digit / 10;
                s = s * 100;
            int res = number;
            s = s / 10;
            res = res / s;
            res = res % 10;  
            return res;  
    }
        else
    {    
            return -1;
    }
}
Console.WriteLine("Введите число:");
int Numb = Convert.ToInt32(Console.ReadLine());
int Nam = IsTherd(Numb);
Console.WriteLine($"Третья цифра: {Nam}");
*/
// Console.WriteLine("третьей цифры нет")
// int Tamp = Convert.ToInt32(Math.Pow(10, (i - 3))); 


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Week(int number)     
    {
        if (number == 6 | number == 7) Console.WriteLine("Сегодня выходной");
        else Console.WriteLine("Сегодня рабочий день");
    }
 Console.Write("Введите день недели с 1-го по 7-е:"); 
 int numWeek = Convert.ToInt32(Console.ReadLine());
 Week(numWeek);
*/