using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 7, 2, 8, 5, 1, 4, 9, 3, 6 };
        Console.WriteLine("Nieposortowana tablica:");
        WypiszListe(array);
        CombSort(array);
        Console.WriteLine("Posortowana tablica:");
        WypiszListe(array);
    }

    static void CombSort(int[] array)
    {
        int n = array.Length;
        int gap = n;
        bool swapped = true;
        while (gap > 1 || swapped)
        {
            gap = Math.Max((gap * 10) / 13, 1);
            swapped = false;
            for (int i = 0; i < n - gap; i++)
            {
                if (array[i] > array[i + gap])
                {
                    Swap(ref array[i], ref array[i + gap]);
                    swapped = true;
                }
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void WypiszListe(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
