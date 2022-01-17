/*
                                              Самойлов Р.А.
3.
а) Написать программу, которая подсчитывает расстояние между точками 
   с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
   Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/

//Вариант:a)

double x1, y1, x2, y2, result;

Console.WriteLine("Введите координаты точки x1");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки x2");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2");
y2 = Convert.ToDouble(Console.ReadLine());

result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"Расстояние между точками: {result}");
