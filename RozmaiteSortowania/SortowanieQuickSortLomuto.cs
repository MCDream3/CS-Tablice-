void Lomuto(int lewy, int prawy)
{
    int pivot = T[prawy];
    int i = lewy;
    int Temp;
    for (int k = lewy; k < prawy; k++)
    {
        if (T[k] <= pivot)
        {
            Temp = T[i];
            T[i] = T[k];
            T[k] = Temp;
            i++;
        }
    }
    Temp = T[i];
    T[i] = T[prawy];
    T[prawy] = Temp;

    if (lewy < i - 1) Lomuto(lewy, i - 1);
    if (prawy > i + 1) Lomuto(i + 1, prawy);
}

Lomuto(0, n - 1);
