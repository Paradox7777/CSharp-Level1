/*
                                      Самойлов Р.А.
1.  Дан  целочисленный  массив  из 20 элементов.  
Элементы  массива  могут принимать  целые  
значения  от –10 000 до 10 000 включительно. 
Заполнить случайными числами.  
Написать программу, позволяющую найти и вывести количество пар элементов массива, 
в которых только одно число делится на 3. 
В данной задаче под парой подразумевается 
два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
*/

const int arrayLength = 20;
int[] myArray = new int[arrayLength];
Random random = new Random();
int amountOfPairs = 0;

for (int i = 0; i < arrayLength-1; i++)
{
    if (myArray[i] % 3 == 0 || myArray[i+1] % 3 == 0)
    {
        amountOfPairs++;
    }
}

Console.WriteLine("Вас приветствует программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
Console.Write("\nВ следующем массиве [ ");

for (int i = 0; i < arrayLength; i++)
{
    myArray[i] = random.Next(-10000, 10001);
    Console.Write(myArray[i] + ", ");
}

Console.WriteLine("\b\b ]\n");
Console.WriteLine($"Количество пар: {amountOfPairs}");
Console.ReadKey();