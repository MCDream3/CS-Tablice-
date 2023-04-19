//3. Sortowanie przez wstawianie          <--insertion sort-->            sortowania w czasie liniowym
//~Casual~

void InsertSort(int []tab, int size)
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
