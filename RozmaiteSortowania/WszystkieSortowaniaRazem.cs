//Sortowania przez porównanie

//stworzenie tablicy 10 losowych liczb <1;20>
int n = 10;
Random r = new Random();
int[] T = new int[n];
for (int i = 0; i < 20; i++)
    T[i] = r.Next(1, 20);

//1. Sortowanie bąbelkowe                   <-- bubble sort -->

int Temp;
for (int i = n-1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (T[j] > T[j+1])
        {
            Temp = T[j];
            T[j] = T[j+1];
            T[j+1] = Temp;
        }
    }
}

//2. Sortowanie przez wybór               <-- selection sort -->
//Wybieramy najmniejszy i wstawiamy: na Początek

int l;
int Tempo;
for (int i = 0; i < n; i++)
{
    l = i;
    for (int j = i + 1; j < n; j++)
        if (T[j] < T[l]) l = j;
        Tempo = T[i];
        T[l] = Tempo;
}

//: na Koniec

int l2;
int Tempix;     //th fck XD
for (int i = n - 1; i > 0; i--)
{
    l2 = i;
    for (int j = 0; j < i; j++)
        if (T[j] < T[l2]) l2 = j;
    Tempix = T[i];
    T[i] = T[l2];
    T[l2] = Tempix;
}

//3. Sortowanie przez wstawianie          <--insertion sort-->

int j, TEMP;
for (int i = 1; i < n; i++)
{
    TEMP = T[i];
    j = i - 1;
    while(j > 0 && TEMP < T[j] )
    {
        T[j] = T[j - 1];
        j--;
    }
    T[j - 1] = TEMP;
}

//4. Sortowanie przez zliczanie         <-- counting sort -->

int[] L = new int[20];

for (int i = 0; i < n; i++)
{
    L[T[i]]++;
}

for (int i = 0; i < L.Length; i++)
{
    Console.Write(L[i] + " ");
}

int q = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        for (int s = 0; s < L[i]; s++)
        {
            T[q] = i;
            q++;
        }
    }
}

//5. Sortowanie kubełkowe               <-- bucket sort -->



//6. Sortowanie przez scalanie          <-- merge sort -->

void scalaj(int lewy, int prawy)
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++) pom[a] = T[a];
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy;
    i_lewy = lewy;
    i_prawy = srodek;

    while(i_lewy <= srodek && i_prawy <= prawy) 
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else
        {
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
    {
        while(i_prawy <= prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    }
else
    {
        while (i_lewy <= srodek)
        {
            T[i] = pom[i_lewy];
            i_lewy++;
            i++;
        }
}

void sortuj(int lewy, int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < srodek)
    {
        sortuj(lewy, srodek);
    }
    if (srodek + 1 < prawy)
    {
        sortuj(srodek + 1, prawy);
    }
    scalaj(lewy, prawy);
}

sortuj(0, n-1);
    
//Sortowanie grzebieniowe           <-- comb sort -->

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

//<-- Sortowania szybkie -->

//8. Sortowanie Quicksort Hoare

void Hoare(int lewy, int prawy)
{
    int i = lewy;
    int j = prawy;
    int temp;
    int pivot = T[(lewy + prawy) / 2];

    while (i <= j)
    {
        while (T[i] < pivot) i++;
        while (T[j] > pivot) j--;
        if (i <= j)
        {
            temp = T[i];
            T[i] = T[j];
            T[j] = temp;
            i++;
            j--;
        }
    }
    if (lewy < j) Hoare(lewy, j);
    if (prawy > i) Hoare(i, prawy);
}

Hoare(0, n - 1);
    
//9. Sortowanie Quicksort Lomuto

void Lomuto(int lewy, int prawy)
{
    int pivot = T[prawy];
    int i = lewy;
    int Temp;
    for (int k = lewy; k < prawy; k++)
    {
        if (T[k] <= pivot)
        {
            Temp = T[i];
            T[i] = T[k];
            T[k] = Temp;
            i++;
        }
    }
    Temp = T[i];
    T[i] = T[prawy];
    T[prawy] = Temp;

    if (lewy < i - 1) Lomuto(lewy, i - 1);
    if (prawy > i + 1) Lomuto(i + 1, prawy);
}

Lomuto(0, n - 1);
    
//wyświetlanie posortowanej tablicy

for (int i = 0; i < 20; i++)
    Console.Write(T[i] + " ");
