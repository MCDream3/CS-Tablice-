
void scalaj(int lewy, int prawy)
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++) pom[a] = T[a];
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy;
    i_lewy = lewy;
    i_prawy = srodek;

    while(i_lewy <= srodek && i_prawy <= prawy) 
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else
        {
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
    {
        while(i_prawy <= prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    }
else
    {
        while (i_lewy <= srodek)
        {
            T[i] = pom[i_lewy];
            i_lewy++;
            i++;
        }
}

void sortuj(int lewy, int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < srodek)
    {
        sortuj(lewy, srodek);
    }
    if (srodek + 1 < prawy)
    {
        sortuj(srodek + 1, prawy);
    }
    scalaj(lewy, prawy);
}

sortuj(0, n-1);
