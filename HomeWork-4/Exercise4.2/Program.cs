﻿/*
                                    Самойлов Р.А.
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
*/

const int arrayLength = 20;
int[] myArray = new int[arrayLength];

GetNumber.GetNumberOfPairs(myArray, arrayLength);
Console.ReadKey();
GetNumber.LoadFromFile("text.txt");