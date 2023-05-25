int[] L = new int[20];

for (int i = 0; i < n; i++)
{
    L[T[i]]++;
}

for (int i = 0; i < L.Length; i++)
{
    Console.Write(L[i] + " ");
}

int q = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        for (int s = 0; s < L[i]; s++)
        {
            T[q] = i;
            q++;
        }
    }
}
