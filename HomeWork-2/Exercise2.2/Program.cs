/*
                                     Самойлов Р.А.
                                    
 2. Написать метод подсчета количества цифр числа.                                   
 */

Console.WriteLine("Введите число для подсчета количества цифр");

int a = int.Parse(Console.ReadLine());
int i = 0;

while (a > 0)
{
    i++;
    a = a / 10;
}

Console.WriteLine($"Количество цифр введенного числа : {i}");
Console.ReadLine();