//~Casual~    "ChYbA DzIaŁa"    to tylko początek i być może moja nie działająca wersja...      *bro I just had to try ok?*

static void CountingSort(int[] Array)
{
    int n = Array.Length;
    int max = 0;
    for (int i = 0; i < n; i++)
    {
        if (max < Array[i])
        {
            max = Array[i];
        }
    }

int[] frequence = new int[max + 1];
for (int i = 0; i < max + 1; i++)
{
    frequence[i] = 0;
}
for (int i = 0; i < n; i++)
{
    frequence[Array[i]]++;
}
for (int i = 0, j = 0; i <= max; i++)
{
    while (frequence[i] > 0)
    {
        Array[j] = i;
        j++;
        frequence[i]--;
    }
}
}
static void PrintArray(int[] Array)
{
    int n = Array.Length;
    for (int i = 0; i < n; i++)
        Console.Write(Array[i] + " ");
    Console.Write("\n");
}
