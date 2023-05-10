//Sortowania przez porównanie

//stworzenie tablicy 10 losowych liczb <1;20>
int n = 10;
Random r = new Random();
int[] T = new int[n];
for (int i = 0; i < 20; i++)
    T[i] = r.Next(1, 20);

//1. Sortowanie bąbelkowe                   <-- bubble sort -->

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

//5. Sortowanie kubełkowe               <-- bucket sort -->



//6. Sortowanie przez scalanie          <-- merge sort -->

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

//ta częśc jeszcze jest niedokończona
void sortuj(int lewy, int prawy)
{
    int srodek = (lewy + prawy) / 2;
    if (lewy < srodek)
    {
        sortuj(lewy, srodek);
       if (srodek + 1 < prawy)
    }
}


//<-- Sortowania szybkie -->

//7. Sortowanie Quicksort Hoare

//8. Sortowanie Quicksort Lomuto


//wyświetlanie posortowanej tablicy

for (int i = 0; i < 20; i++)
    Console.Write(T[i] + " ");
