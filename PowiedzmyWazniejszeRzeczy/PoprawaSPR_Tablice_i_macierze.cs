//Zadanie 1

int f = int.Parse(Console.ReadLine());
int g = int.Parse(Console.ReadLine());
int roznica = f - g;
int[] o = new int[900/roznica];
int indeks = 0;
for (int i = roznica; i < 900; i+= roznica)
{
    o[i] = 1;
    indeks++;
}
Console.WriteLine("tablica wielokrotności różnicy f - g:");
for (int i = 0; i < o.Length; i++)
{
    Console.WriteLine(o[i]);
}

//Zadanie 2

Random r = new Random();
int[] l = new int[20];
int index = 0;

while (index < 20)
{
    int Lrandomowe = r.Next(100, 1000);
    if (Lrandomowe % 2 == 0 && Lrandomowe % 10 != 0)
    {
        l[index] = Lrandomowe;
        index++;
    }
}
Console.WriteLine("Wylosowane liczby to:");
foreach (int i in l)
{
    Console.WriteLine(l);
}

//Zadanie 3

Random p = new Random();
int[] m = new int[1200];
int suma  = 0;
int zlicz = 0;

for (int i = 0; i < 1200; i++)
{
    int mRandomowe = p.Next(100, 1000);
    m[i] = mRandomowe;
    suma += mRandomowe;
    zlicz++;
}
Console.WriteLine("Suma liczb:" + suma);
Console.WriteLine("ilość liczb:" + zlicz);

//Zadanie 4

int N = 5; //<-- wielkość macierzy
int[,] n = new int[N, N];
Random q = new Random();
for (int i = 0;i < N;i++)
{
    for (int j = 0; j < N; j++)
    {
        n[i, j] = q.Next(0, 10);
    }
}


Console.WriteLine("Macierz:");
for (int i = 0;i<N;i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.WriteLine(n[i,j] + " ");
    }
    Console.WriteLine();
}


int frSum = 0;
int frStart = 1;  //<-- pierwszy elem ramki
int frEnd = N - 2;  //<-- ostatni elem ramki
for (int i = frStart; i <= frEnd; i++)
{
    frSum += n[frStart, i];
    frSum += n[frEnd, i];
}
for (int i = frStart; i <= frEnd; i++)
{
    frSum += n[i, frStart];
    frSum += n[i, frEnd];
}
Console.WriteLine("Suma cyfr w macierzy: " + frSum);
