/*
                                     Самойлов Р.А.
                                    
4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел 
(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
написать программу: пользователь вводит логин и пароль, программа пропускает его дальше 
или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.                                 
 */

string log, pass;
int i = 0;
int j = 3;
const string a = "root";
const string b = "GeekBrains";

do
{
    Console.WriteLine("Введите логин для входа");
    log = Console.ReadLine();
    Console.WriteLine("Введите пароль для входа");
    pass = Console.ReadLine();

    i++;
    j--;

    if (log == a && pass == b)
    {
        Console.WriteLine("Вы ввели верный логин и пароль");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.WriteLine($"Вы ввели неверный логин или пароль. У Вас осталось {j} попытки(ок)");

        if (j == 0)
        {
            Console.WriteLine($"Лимит попыток исчерпан");

        }
        Console.ReadKey();
    }

}
while (i < 3);