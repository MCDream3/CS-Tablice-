//deklaracja
using System;
using System.Collections;
Random r = new Random();
//1 Wygeneruj tablicę z 15 losowymi liczbami dwucyfrowymi nie parzystymi

int[] F = new int[15];
for (int i = 0; i < F.Length; i++)
{
    F[i] = r.Next(5, 50) * 2 + 1;
    Console.Write(F[i] + " ");
}
Console.WriteLine();

foreach ( var item in F)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine();

//2 Wygeneruj tablicę 20 dowolnych liczb dwucyfrowych i potem zaokrąglij każdą w górę do pełnej dziesiątki

int[]T= new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
    Console.Write(T[i] + " ");

    if (T[i] % 10 != 0)
    {
        T[i] = T[i] - (T[i] % 10) + 10;
    }
    Console.WriteLine(T[i]);
}
Console.WriteLine();

//3 Wygeneruj listę 12 losowych liczb dwucyfrowych podzielnych przez 7

int[] Q = new int[12];
for(int i = 0;i < Q.Length;i++)
{
    Q[i] = r.Next(2, 13) * 7;
    Console.Write(Q[i] + " ");
}


//ZADANIA DODATKOWE
//1 Wygeneruj losową tablicę 20 elementową składającą się z cyfr 1,2,3.
//Znajdź najdłuższy podciąg identycznych cyfr. Jeśli jets więcej tak samo długich to wypisz ostatni z nich

//2 Algorytm Kadene-a ???           when you don't understand anything but you're having fun  >:D

//3 Listy dwuwymiarowe... Wygeneruj listę 10x10 losowych liczb. Znajdź w ilu miejscach występują tacy sami sąsiedzi (lewo-prawo, góra-dół)