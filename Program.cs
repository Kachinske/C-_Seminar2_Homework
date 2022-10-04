//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

Console.WriteLine("Введите трехзначное число");
int Task10Number = int.Parse(Console.ReadLine()!);
if((Task10Number < 100) || (Task10Number > 999))
{
    Console.WriteLine("Введенное число не является трехзначным");
}
else
{
    int MiddleNumber = Task10Number / 10 % 10;
    Console.WriteLine($"Посерединке цифра {MiddleNumber}");
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем

int Task13Number = new Random().Next(0,100000);
if(Task13Number<100)
{
     Console.WriteLine($"В числе {Task13Number} третья цифра куда то потерялась)");
}
else
{
    if(Task13Number < 1000)
    {
        Console.WriteLine($"Ищу в числе {Task13Number} ... вот, нашел {Task13Number % 10}");
    }
    else
    {
        if(Task13Number < 10000)
        {
            Console.WriteLine($"Ищу в числе {Task13Number} ... вот, нашел {Task13Number / 10 % 10}");
        }
        else
        {
            Console.WriteLine($"Ищу в числе {Task13Number} ... вот, нашел {Task13Number / 100 % 10}");
        }
    }
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7

Console.WriteLine("Какой сегодня день недели?");
int DayOfWeek = int.Parse(Console.ReadLine()!);
if((DayOfWeek >= 1) && (DayOfWeek <= 7))
{
    if((DayOfWeek ==6) || (DayOfWeek == 7))
    {
       Console.WriteLine("Ура! Выходной!"); 
    }
    else
    {
        Console.WriteLine("Снова на работу("); 
    }
}
else
{
    Console.WriteLine("Разве в неделе не 7 дней? Подумай еще");
}
