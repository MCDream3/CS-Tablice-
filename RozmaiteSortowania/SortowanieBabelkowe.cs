//1. Sortowanie bąbelkowe                   <-- bubble sort -->
//~Casual "jako moja metoda"~

static void
BubbleSort(IComparable[] a)                     //<--Comparable czyli porównywalny
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

//~TP_POpr method XD~       od prawej rosnąco*

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
