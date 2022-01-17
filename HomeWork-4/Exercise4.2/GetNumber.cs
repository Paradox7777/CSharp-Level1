static class GetNumber
{
    public static int GetNumberOfPairs(int[] array, int length)
    {
        string file = null;
        int amountOfPairs = 0;
        Random random = new Random();
        Console.WriteLine("Вас приветствует программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
        Console.Write("\nВ следующем массиве [ ");
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(-10000, 10001);
            Console.Write(array[i] + ", ");
            file += $"[{array[i]}] ";
        }

        for (int i = 0; i < length-1; i++)
        {
            if (array[i] % 3 == 0 || array[i+1] % 3 == 0)
            {
                amountOfPairs++;
            }
        }
        Console.WriteLine("\b\b ]\n");
        Console.WriteLine($"Количество пар: {amountOfPairs}");
        File.WriteAllText(@"text.txt", file);
        Console.WriteLine("Программа загрузила массив в файл text.txt");
        return amountOfPairs;

    }
    public static string LoadFromFile(string path)
    {
        string[] data = File.ReadAllLines(path);

        Console.WriteLine("Программа считала массив из файла");

        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine($" {data[i]} ");
        }

        return String.Join(" ", data);
    }
}