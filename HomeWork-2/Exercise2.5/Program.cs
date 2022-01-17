/*
                                     Самойлов Р.А.
                                    
5.
а) Написать программу, которая запрашивает массу и рост человека, 
вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/

// Вариант: а)

Console.WriteLine("Введите ваш вес для вычисления индекса массы");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ваш рост для вычисления индекса массы в виде");
double growth = double.Parse(Console.ReadLine());
double index;

growth = growth / 100;
index = weight / (growth * growth);

if (index < 16.5)
{
    Console.WriteLine("Выраженный дефицит массы");
}
else if (16.5 < index && index < 18.49)
{
    Console.WriteLine("Недостаточная (дефицит) масса тела");
}
else if (18.5 < index && index < 24.99)
{
    Console.WriteLine("Норма");
}
else if (25 < index && index < 29.99)
{
    Console.WriteLine("Избыточная масса тела (предожирение)");
}
else if (30 < index && index < 34.99)
{
    Console.WriteLine("Ожирение первой степени");
}
else if (35 < index && index < 39.99)
{
    Console.WriteLine("Ожирение второй степени");
}
else
{
    Console.WriteLine("Ожирение третьей степени (морбидное)");
}