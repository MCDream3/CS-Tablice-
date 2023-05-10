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
