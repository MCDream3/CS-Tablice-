//Sortowania przez porównanie

//stworzenie tablicy 10 losowych liczb <1;20>
int n = 10;
Random r = new Random();
int[] T = new int[n];
for (int i = 0; i < 20; i++)
    T[i] = r.Next(1, 20);

//1. Sortowanie bąbelkowe                   <-- bubble sort -->
//~Casual~

static void
BubbleSort(IComparable[] a)
{
    int n = a.Length;
    for(int i = 0; i < n; i++)
        for (int j = n - 1; j >= i; j--)
            if (a[j - 1].CompareTo(a[j]) > 0)
            {
                IComparable x = a[j - 1];
                a[j - 1] = a[j];
                a[j] = x;
            }
}

//~TP_POpr method XD~

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
//casual nie działa
//~Casual~

//int Max(int n)
//{
//    int max = 0;
//    for (int i = 1; i < n; i++)
//        if (T[i] > T[max])
//            max = i;
//    return max;
//}

//void Sel_sort(int n)
//{
//    for (int i = n; i >= 2; i--)
//    {
//        int max = Max(i);
//        if(max != i - 1)
//            swap(T[i - 1], T[max]);
//    }
//}

//~TP_POpr method~
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
//~Casual~

void Ins_sort(int []tab, int size)
{
    int temp, j;
    for (int i = 1; i < size; i++)
    {
        temp = tab[i];
        for (int k = i - 1; k >= 0 && tab[j] > temp; j--)
            tab[k + 1] = tab[k];
        tab[j + 1] = temp;
    }
}

//~TP_POpr method~

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
//~Casual~    "ChYbA DzIaŁa"

static void CountingSort(int[] Array)
{
    int n = Array.Length;
    int max = 0;
    for (int i = 0; i < n; i++)
    {
        if (max < Array[i])
        {
            max = Array[i];
        }
    }

int[] frequence = new int[max + 1];
for (int i = 0; i < max + 1; i++)
{
    frequence[i] = 0;
}
for (int i = 0; i < n; i++)
{
    frequence[Array[i]]++;
}
for (int i = 0, j = 0; i <= max; i++)
{
    while (frequence[i] > 0)
    {
        Array[j] = i;
        j++;
        frequence[i]--;
    }
}
}
static void PrintArray(int[] Array)
{
    int n = Array.Length;
    for (int i = 0; i < n; i++)
        Console.Write(Array[i] + " ");
    Console.Write("\n");
}

//5. Sortowanie kubełkowe               <-- bucket sort -->
//~Casual~

class BucketSort
{
    public static List<int> Sort(params int[] x)
    {
        List<int> sortedArray = new List<int>();
        int numOfBuckets = 10;
        List<int>[] buckets = new List<int>[numOfBuckets];
        for (int i = 0; i < numOfBuckets; i++)
        {
            buckets[i] = new List<int>();
        }
        for (int i = 0; i < x.Length; i++)
        {
            int bucket = (x[i] / numOfBuckets);
            buckets[bucket].Add(x[i]);
        }
        for (int i = 0; i < numOfBuckets; i++)
        {
            List<int> temp = InsertionSort(buckets[i]);
            sortedArray.AddRange(temp);
        }
        return sortedArray;
    }
//Wstawienie Insertion Sort
public static List<int> InsertionSort(List<int> input)
{
    for (int i = 1; i < input.Count; i++)
    {
        int currentValue = input[i];
        int pointer = i - 1;
        while (pointer >= 0)
        {
            if (currentValue < input[pointer])
            {
                input[pointer + 1] = input[pointer];
                input[pointer] = currentValue;
            }
            else break;
        }
    }
    return input;
}
}

//6. Sortowanie przez scalanie          <-- merge sort -->


//<-- Sortowania szybkie -->

//7. Sortowanie Quicksort Hoare

//8. Sortowanie Quicksort Lomuto


//wyświetlanie posortowanej tablicy

for (int i = 0; i < 20; i++)
    Console.Write(T[i] + " ");
