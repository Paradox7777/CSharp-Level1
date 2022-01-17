/*
                                     Самойлов Р.А.
                                    
7.
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
//Вариант: а)
/*
Console.WriteLine("Введите число (от которого начнется рекурсивный метод)");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число (на котором закончится рекурсивный метод)");
int b = int.Parse(Console.ReadLine());
while(a <= b)
{
   
    Console.WriteLine(a);
    a++;
}
*/
// Вариант: b)

Console.WriteLine("Введите число (от которого начнется рекурсивный метод)");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число (на котором закончится рекурсивный метод)");
int b = int.Parse(Console.ReadLine());
int result = 0;

while (a <= b)
{
    result += a;
    Console.WriteLine(a);
    a++;
}
Console.WriteLine($"Сумма чисел рекурсии от a до b: {result}");