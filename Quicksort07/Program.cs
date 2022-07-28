int[] integerValues = { 5, 8, 1, 3, 7, 9, 2, 4};
Console.WriteLine(string.Join(" | ", integerValues));
Sort(integerValues);
Console.WriteLine(string.Join(" | ", integerValues));

static void Sort(IList<int> arr)
{
    QuickSort(arr, 0, arr.Count - 1);
}

static void QuickSort(IList<int> arr, int lower, int upper)
{
    if (lower < upper)
    {
        var part = Partition(arr, lower, upper);
        QuickSort(arr, lower, part);
        QuickSort(arr, part + 1, upper);
    }
}

static int Partition(IList<int> array, int lower, int upper)
{
    var pivot = array[lower];

    // all elements lower than pivot on the left, all elements greater than pivot on the right
    do
    {
        while (array[lower] < pivot) // 1) find 'array[lower] > pivot'
            lower++;
        while (array[upper] > pivot) // 2) find 'array[upper] < pivot'
            upper--;
        if (lower >= upper)  
            break; 
        Swap(array, lower, upper); // 3) Swap them, do it while 'lower < upper'
    }
    while (lower < upper);
    
    return upper;
}

static void Swap(IList<int> arr, int first, int second)
    => (arr[first], arr[second]) = (arr[second], arr[first]);