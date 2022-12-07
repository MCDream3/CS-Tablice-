//Tablice 2-wymiarowe
int[,] T2D = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine(T2D[i, j] + "\t");
    }
    Console.WriteLine();
}
//zadeklaruj macierz a'la sudoku
int[,] K = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9} };
for (int i = 0; i <3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(K[i, j] + "\t");
    }
}
Console.WriteLine();

//zadeklaruj macierz 4x4 z losowymi liczbami
int[,] L = new int[4, 4];
Random r = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(L[i, j] + "\t");
    }
    Console.WriteLine();
}
//wymiary macierzy
int[,] M = new int[3, 5];
Console.WriteLine(M.Length);
Console.WriteLine(M.GetLength(0));
Console.WriteLine(M.GetLength(1));

//wypełnić macierz 3x5 liczbami dwucyfrowymi korzystając z GetLength
int[,] N = new int[3, 5];
Random r = new Random();
for (int i = 0; i < N.GetLength(0); i++)
    for (int j = 0; j < N.GetLength(1); j++)
        N[i, j] = r.Next(0, 10);

for (int i = 0; i < N.GetLength(0); i++)
{
    for (int j = 0; j < N.GetLength(1); j++)
    {
        Console.WriteLine(N[i, j] + "\t");
    }
    Console.WriteLine();
}