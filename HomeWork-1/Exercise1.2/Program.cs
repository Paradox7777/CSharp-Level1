/*                       
                             Самойлов Р.А.
2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/

double I, m, h;

Console.WriteLine("Введите Ваш вес и рост для расчета индекса массы тела (ИМТ)");

Console.WriteLine("Введите Ваш вес");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Ваш рост");
h = Convert.ToDouble(Console.ReadLine());

I = m / (h * h);

Console.WriteLine($"Ваш индекс массы тела равен: {I:F10}");