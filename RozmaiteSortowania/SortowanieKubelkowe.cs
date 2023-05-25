//~Casual~

class BucketSort
{
    public static List<int> Sort(params int[] x)
    {
        List<int> sortedArray = new List<int>();
        int numOfBuckets = 10;
        List<int>[] buckets = new List<int>[numOfBuckets];
        for (int i = 0; i < numOfBuckets; i++)
        {
            buckets[i] = new List<int>();
        }
        for (int i = 0; i < x.Length; i++)
        {
            int bucket = (x[i] / numOfBuckets);
            buckets[bucket].Add(x[i]);
        }
        for (int i = 0; i < numOfBuckets; i++)
        {
            List<int> temp = InsertionSort(buckets[i]);
            sortedArray.AddRange(temp);
        }
        return sortedArray;
    }
//Wstawienie Insertion Sort
public static List<int> InsertionSort(List<int> input)
{
    for (int i = 1; i < input.Count; i++)
    {
        int currentValue = input[i];
        int pointer = i - 1;
        while (pointer >= 0)
        {
            if (currentValue < input[pointer])
            {
                input[pointer + 1] = input[pointer];
                input[pointer] = currentValue;
            }
            else break;
        }
    }
    return input;
}
}


//kolejny sposób ALE dużo nie działa

static int[] BucketSort(int lista, dynamic listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
        for (int j = 0; j < listInput.Count; j++)
        {
            if (listInput[i] < listInput[j])
            {
                var TeMp = listInput[i];
                listInput[i] = listInput[j];
                listInput[j] = TeMp;
            }
        }
    }
    return listInput.ToArray();
}
int[] sortuj(int[] array)
{
    int sortedList = new int();
    var minWartosc = array[0];
    var maxWartosc = array[0];

    if (array == null || array.Length <= 1)
    {
        return array;
    }

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxWartosc)
            maxWartosc = array[i];
        if (array[i] < minWartosc)
            minWartosc = array[i];
    }
    
    var numberOfBuckets = maxWartosc - minWartosc + 1;
    int[] wiaderko = new int[numberOfBuckets];

    for (int i = 0; i < numberOfBuckets; i++) 
    {
        wiaderko[i] = new int();
    }
       
    for (int i = 0; i < array.Length; i++)
    {
        var wybrany = (array[i] / numberOfBuckets);
        wiaderko[wybrany].Add(array[i]);
    }

    for (int i = 0; i < numberOfBuckets; i++)
    {
        int[] temp = BucketSort(wiaderko[i]);
        sortedList.AddRange(temp);
    }

    return sortedList.ToArray;
}
