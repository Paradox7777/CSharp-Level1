/*                       
                          Самойлов Р.А.
1.Написать программу «Анкета». Последовательно задаются вопросы 
(имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку: 
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
 
*/

// Вариант: a)
/*
string firstName, lastName, age, height, weight;
Console.WriteLine("Анкета");
Console.WriteLine("Введите свое имя");
firstName = Console.ReadLine();
Console.WriteLine("Введите свою фамилию");
lastName = Console.ReadLine();
Console.WriteLine("Введите свой возраст");
age = Console.ReadLine();
Console.WriteLine("Введите свой рост");
height = Console.ReadLine();
Console.WriteLine("Введите свой вес");
weight = Console.ReadLine();
Console.WriteLine("Имя: " + firstName + ", Фамилия: " + lastName + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);
*/

// Вариант: б)
/*
string firstName, lastName, age, height, weight;
Console.WriteLine("Анкета");
Console.WriteLine("Введите свое имя");
firstName = Console.ReadLine();
Console.WriteLine("Введите свою фамилию");
lastName = Console.ReadLine();
Console.WriteLine("Введите свой возраст");
age = Console.ReadLine();
Console.WriteLine("Введите свой рост");
height = Console.ReadLine();
Console.WriteLine("Введите свой вес");
weight = Console.ReadLine();
Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", firstName, lastName, age, height, weight);
*/

// Вариант: в)

string firstName, lastName, age, height, weight;

Console.WriteLine("Анкета");

Console.WriteLine("Введите свое имя");
firstName = Console.ReadLine();
Console.WriteLine("Введите свою фамилию");
lastName = Console.ReadLine();
Console.WriteLine("Введите свой возраст");
age = Console.ReadLine();
Console.WriteLine("Введите свой рост");
height = Console.ReadLine();
Console.WriteLine("Введите свой вес");
weight = Console.ReadLine();
Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age}, Рост: {height}, Вес: {weight}");