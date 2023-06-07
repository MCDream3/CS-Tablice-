//Zadanie 1: Odwróć tablicę
//Napisz program, który przyjmuje tablicę liczb całkowitych i odwraca jej kolejność. Na przykład, jeśli tablica wejściowa to [1, 2, 3, 4, 5], program powinien zwrócić [5, 4, 3, 2, 1].

Console.WriteLine("Zadanie 1");

int[] n = { 1, 2, 3, 4, 5 };

Console.WriteLine("oryginalna tablica");
PrintArr(n);

RevArr(n);

Console.WriteLine("odwrócona tablica");
PrintArr(n);

static void RevArr(int[] array)
{
    int lewo = 0;
    int prawo = array.Length - 1;

    while(lewo < prawo)
    {
        int temp = array[lewo];
        array[lewo] = array[prawo];
        array[prawo] = temp;
        lewo++;
        prawo--;
    }
}
static void PrintArr(int[] array)
{
    foreach(int liczba in array)
    {
        Console.WriteLine(liczba + " ");
    }
    Console.WriteLine();
}

////Zadanie 2: Suma elementów tablicy
////Napisz program, który oblicza sumę wszystkich elementów w tablicy liczb całkowitych. Na przykład, dla tablicy [1, 2, 3, 4, 5], program powinien zwrócić wartość 15.


Console.WriteLine("Zadanie 2");

int[] o = { 1, 2, 3, 4, 5 };
int suma = CalculateSum(o);
Console.WriteLine("suma wszystkich elementów w tablicy: " + suma);

static int CalculateSum(int[] array)
{
    int suma = 0;
    foreach(int liczba in array)
    {
        suma += liczba;
    }
    return suma;
}
Console.WriteLine();

//Zadanie 3: Największy element w tablicy
//Napisz program, który znajduje największy element w tablicy liczb całkowitych. Na przykład, dla tablicy [10, 5, 7, 15, 3], program powinien zwrócić wartość 15.

Console.WriteLine("Zadanie 3");

int[] p = { 0, 5, 7, 15, 3 };
int max = NAJWIEKSZA(p);
Console.WriteLine("Największy element w tablicy:" + max);

static int NAJWIEKSZA(int[] array)
{
    if(array == null || array.Length == 0)
    {
        throw new ArgumentException("Tablica jest pusta");
    }
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
Console.WriteLine();

//Zadanie 4: Liczba wystąpień elementu w tablicy
//Napisz program, który liczy liczbę wystąpień określonego elementu w tablicy liczb całkowitych. Na przykład, dla tablicy [1, 2, 2, 3, 4, 2, 5] i szukanego elementu 2, program powinien zwrócić wartość 3.

Console.WriteLine("Zadanie 4");

int[] q = { 1, 2, 2, 3, 4, 2, 5 };
int mainElement = 2;
int zlicz = CountOccurences(q, mainElement);
Console.WriteLine("liczba wystąpień elementu" + mainElement + "w tablicy:" +  zlicz);

static int CountOccurences(int[] array, int target)
{
    int zlicz = 0;
    foreach(int liczba in array)
    {
        if(liczba == target)
        {
            zlicz++;
        }
    }
    return zlicz;
}
Console.WriteLine();

//Zadanie 5: Sortowanie tablicy
//Napisz program, który sortuje tablicę liczb całkowitych w kolejności rosnącej lub malejącej. Możesz użyć dowolnego algorytmu sortowania, np. sortowanie bąbelkowe, sortowanie przez wstawianie lub sortowanie szybkie.

Console.WriteLine("Zadanie 5");

int[] r = { 5, 2, 8, 3, 1 };
Console.WriteLine("wybierz kolejność sortowania");
Console.WriteLine("rosnąco(w konsoli wpisz 1):");
Console.WriteLine("malejąco(w konsoli wpisz 2):");

int wybor = Convert.ToInt32(Console.ReadLine());
if(wybor == 1)
{
    SortRosnacy(r);
    Console.WriteLine("tablica po sortowaniu rosnącym:");
}
else if(wybor == 2)
{
    SortMalejacy(r);
    Console.WriteLine("tablica po sortowaniu malejącym:");
}
else
{
    Console.WriteLine("nieprawidłowy wybór");
    return;
}
PrintArray(r);

static void SortRosnacy(int[] array)
{
    Array.Sort(array);
}
static void SortMalejacy(int[] array)
{
    Array.Sort(array);
    Array.Reverse(array);
}

static void PrintArray(int[] array)
{
    foreach(int liczba in array)
    {
        Console.WriteLine(liczba + " ");
    }
    Console.WriteLine();
}
