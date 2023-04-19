//2. Sortowanie przez wybór               <-- selection sort -->
//jeszcze trzeba dopracować bo nie ma funkcji "swap" w c# ALE JEST W C++!       ;---;
//~Casual~

//int Max(int n)
//{
//    int max = 0;
//    for (int i = 1; i < n; i++)
//        if (T[i] > T[max])
//            max = i;
//    return max;
//}

//void SelectionSort(int n)
//{
//    for (int i = n; i >= 2; i--)
//    {
//        int max = Max(i);
//        if(max != i - 1)
//            swap(T[i - 1], T[max]);
//    }
//}

//~TP_POpr method~       wybieramy najmniejszy i wstawiamy na początek*

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

//wybieramy najmniejszy i wstawiamy na koniec

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
