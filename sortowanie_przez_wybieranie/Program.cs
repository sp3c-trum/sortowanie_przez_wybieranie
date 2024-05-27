using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        string input = Console.ReadLine();
        int size = 5;
        try
        {
            size = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Zły wybór.");
        }
        int[] array = new int[size];
        WypelnijTablice(array);

        Console.WriteLine("\nTablica przed posortowaniem:");
        PrintArray(array);

        Sortowanie(array);

        Console.WriteLine("\nTablica po posortowaniu:");
        PrintArray(array);
    }

    static void WypelnijTablice(int[] array)
    {
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(1, 100);
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Sortowanie(int[] array) //"Ref" użyte aby zamienić zmienne miejscami (w innym przypadku wychodziło null w miejscach tablic)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            Zamien(ref array[i], ref array[minIndex]);
        }
    }

    static void Zamien(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}