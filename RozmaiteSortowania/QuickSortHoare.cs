void Hoare(int lewy, int prawy)
{
    int i = lewy;
    int j = prawy;
    int temp;
    int pivot = T[(lewy + prawy) / 2];

    while (i <= j)
    {
        while (T[i] < pivot) i++;
        while (T[j] > pivot) j--;
        if (i <= j)
        {
            temp = T[i];
            T[i] = T[j];
            T[j] = temp;
            i++;
            j--;
        }
    }
    if (lewy < j) Hoare(lewy, j);
    if (prawy > i) Hoare(i, prawy);
}

Hoare(0, n - 1);
