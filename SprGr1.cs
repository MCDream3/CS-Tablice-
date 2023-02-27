using System;
using System.Collections;

// int n = int.Parse(Console.ReadLine());
// ArrayList A= new ArrayList();

// for(int i=1; i<=n;i++)
// {
//     if (n%i == 0)
//     {
//         A.Add(i);
//     }
// }

// foreach(var item in A)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("\n");
int n = int.Parse(Console.ReadLine())
ArrayList A = new ArrayList()

for(int i = 1; i <= n; i++)
{
    if(n%i == 0)
    {
        A.Add(i)
    }
}
foreach(var item in A)
{
    Console.Write(item)
}


// bool czyPierwsza(int n)
// {
//     for (int i = 2; i < n; i++)
//         if (n % i == 0)
//             return false;
//     return true;
// }

// int[] T = new int[20];
// Random r = new Random();
// int n = 0, x;
// while (n < 20)
// {
//     x = r.Next(100, 1000);
//     if (czyPierwsza(x) == false && x % 2 != 0 && x%3 != 0)
//     {
//         T[n] = x;
//         n++;
//     }
// }
// Console.WriteLine("\n");
bool czyPierwsza(int n)
{
  for(int i = 2; i < n; i++)
  if(n%i == 0)
    return true;
  return false;
}

int[]T = new int[20];
Random r = new Random();
int n = 0, x;
while(n < 20)
{
    x = r.Next(100,1000)
    if(czyPierwsza(x) == false && n%2 == 0 && n%3)
    {
        T[n] = x;
        n++
    }
}


ArrayList B = new ArrayList();
Random r = new Random();

for (int k = 0; k < 40; k++) B.Add(r.Next(10, 100));
{
    int licznik = 0;
    foreach(int item in B)
    {
        if(item == i)
        {
            licznik++;
        }
    }
}
if (licznik == 2)
{
    suma += i;
}



Random r = new Random();
int[]M = new int[11,11];

for (int l = 0; l < 11; l++)
{
    for (int m = 0; m < M.Length(1); m++)
    {
        M[l, m] = r.Next(0, 10);
		if (l == m || l + m == 10)
		{
			suma += M[l, m];
		}
    }
}