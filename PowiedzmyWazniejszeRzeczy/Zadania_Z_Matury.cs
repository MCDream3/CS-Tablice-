using System;

class Program {
  public static void Main (string[] args);
}

StreamReader sr = new StreamReader("C:\\Taisiia\\przyklad.txt");
int[] T = new int[500];
for (int i = 0; i < 500; i++)
{
    T[i] = int.Parse(sr.ReadLine());
}

//for (int i = 0; i < 500; i++)
//{
//    Console.Write(T[i] + "\t");
//}

//while (!sr.EndOfStream) ;
//{
//    Console.WriteLine(sr.ReadLine() + " ");
//}

int[] P = new int[] { 1, 3, 9, 27, 81, 243, 729, 2197, 6561, 19683, 59049 };
int ilosc = 0;
for (int i = 0; i < 500; i++)
{
    for (int j = 0; j < 11; j++)
    {
        if (T[i] == P[j])
        {
            ilosc++;
            break;
        }
    }
}
Console.WriteLine(ilosc);
