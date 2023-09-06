//                                                                                            !_____PRZED DIAGNOZĄ_____!

//                                                                                               <<<\\Algorytmy//>>>

//Napisz i przetestuj algorytm Euklidesa odejmowanie

int euklidesOdejm(int a, int b)
{
    while(a!= b)
    {
        if (a > b) a -= b;
        if (a < b) b -= a;
    }
    return a;
}

int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
Console.WriteLine(euklidesOdejm(x, y));

//Napisz i przetestuj algorytm Euklidesa modulo

int euklidesMod(int a, int b)
{
    int pom;
    while(b > 0)
    {
        pom = b;
        b = a % b;
        a = pom;
    }
    return a;
}

int v, w;
v = int.Parse(Console.ReadLine());
w = int.Parse(Console.ReadLine());
Console.WriteLine(euklidesMod(v, w));

//Napisz i przetestuj algorytm sortowania bąbelkowego na tablicy

void BubbleSort(int[] T)
{
    int pom;
    int n = T.Count();
    for (int i = n-1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (T[j] > T[j+1])
            {
                pom = T[j];
                T[j] = T[j + 1];
                T[j + 1] = pom;
            }
        }
    }
}

Random r = new Random();
int n = 20;
int[] T = new int[20];

for (int i = 0; i < n; i++) T[i] = r.Next(1, 100);

for (int i = 0; i < n; i++) Console.WriteLine(T[i] + " ");

Console.WriteLine("\n");
BubbleSort(T);

for (int i = 0; i < n; i++) Console.WriteLine(T[i] + " ");
//wypisz wszystkie pary liczb zaprzyjaźnionych z przedziału od 1 do 10000

int sumaDzielWlasciwych(int m)
{
    int suma = 0;
    for (int i = 1; i <= m / 2; i++)
        if (m % i == 0)
            suma += i;
    return suma;
}

int pom;
for (int i = 1; i < 10000; i++)
{
    pom = sumaDzielWlasciwych(i);
    if(i == sumaDzielWlasciwych(pom))
    {
        Console.WriteLine(i + " " + pom);
    }
}

//                                                                                               <<<\\Listy-Tablice-Macierze//>>>

//znajdź ilość wielokrotności liczby 17(zapisz te listy do listy wynikowej

Random s = new Random();
int o = 30;
int[] U = new int[o];

for (int i = 0; i < o; i++) U[i] = s.Next(1, 100);

for (int i = 0; i < o; i++) Console.WriteLine(U[i] + " ");

Console.WriteLine("\n");
List<int> list = new List<int>();
ArrayList al = new ArrayList();

foreach(var t in U)
{
    if (t % 17 == 0) list.Add(t);
}

foreach(var l in list)
{
    Console.WriteLine(l + " ");
}

//wypisz sumę kolejnych ramek w macierzy kwadratowej o "p" parzystym

Random c = new Random();
int d = 8;
int[,] M = new int[d, d];

for (int i = 0; i < d; i++)
    for (int j = o; j < d; j++)
        M[i, j] = s.Next(1, 10);

for (int i = 0;i < d; i++)
{
    for (int j = 0; j < d; j++)
        Console.WriteLine(M[i, j] + " ");
    Console.WriteLine("");
}

//solution 1 - przez sumy podmacierzy

List<int> S = new List<int>();
int suma;
for (int i = 0; i < d/2; i++)
{
    suma = 0;
    for (int j = d / 2 - i; j < d/2 + i; j++)
    {
        for (int k = d / 2 - i; k < d / 2 + i; k++)
        {
            suma = suma + M[j, k];
        }
    }
    S.Add(suma);
}

Console.WriteLine("\n");
foreach (var q in S)
{
    Console.WriteLine(q);
}

int[] R = S.ToArray();
Console.WriteLine("\n" + T[0]);

for (int i = 0; i < S.Count; i++)
{
    Console.WriteLine();
}
