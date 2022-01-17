﻿/*
                                     Самойлов Р.А.
                                    
 С клавиатуры вводятся числа, пока не будет введен 0. 
Подсчитать сумму всех нечетных положительных чисел.                                  
 */

int result = 0;
int i = 0;

do
{
    Console.WriteLine("Введите любое число для подсчета суммы всех нечетных положительных чисел");
    i = int.Parse(Console.ReadLine());

    if (i > 0 && i % 2 == 1)
    {
        result += i;
    }
    else
    {
        continue;
    }
}
while (i != 0);

Console.WriteLine($"Cумма всех нечетных положительных чисел ровна: {result}");