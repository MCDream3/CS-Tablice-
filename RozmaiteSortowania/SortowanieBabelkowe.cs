
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
