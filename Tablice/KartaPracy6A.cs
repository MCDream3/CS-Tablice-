using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
//Zad1
int x = int.Parse(Console.ReadLine());
int wynik = 0;
while (x > 0)
{
   wynik += x % 10;
   x %= 10;
}
Console.Write(wynik);

//Zad2
int a = int.Parse(Console.ReadLine());
int temp = 0;
for (int i = 2; i < a; i++)
{
   if (a % i == 0)
   {
       temp += 1;
   }
   if (temp > 3)
   {
       Console.Write("Chyba tak");
   }
   else
   {
       Console.Write("No nie");
   }
}
//Zad3
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < n; i++)
{
   if (n%i == 0)
   {
       suma += i;
   }
   if (suma == n)
   {
       Console.Write("jest doskonała");
   }
   else
   {
       Console.Write("you idoit its not");
   }
}
//Zad4
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
while (x!= y)
{
   if (x > y) ; x -= y;
   if (y > x) ; y -= x;
   if (x == 1)
   {
       Console.Write("liczby są względnie pierwsze");
   }
   else
   {
       Console.Write("liczby takie nie są");
   }
}
