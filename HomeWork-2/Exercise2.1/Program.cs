/*
                                     Самойлов Р.А.
                                    
 1. Написать метод, возвращающий минимальное из трёх чисел.                                    
 */

int a = 6, b = 8, c = 5;

if (a < b && a < c)
{
    Console.WriteLine(a);
}
else if (b < a && b < c)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}