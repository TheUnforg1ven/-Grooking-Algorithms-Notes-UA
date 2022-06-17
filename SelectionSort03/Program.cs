int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
Console.WriteLine(string.Join(" | ", integerValues));
SelectionSort(integerValues);
Console.WriteLine(string.Join(" | ", integerValues));

static void SelectionSort(IList<int> arr)
{
    for (var i = 0; i < arr.Count - 1; i++)
    {
        var minValue = arr[i];
        var minIndex = i;

        for (var j = i + 1; j < arr.Count; j++)
        {
            if (arr[j] < minValue)
            {
                minValue = arr[j];
                minIndex = j;
            }
        }
        
        Swap(arr, i, minIndex);
    }
}

static void Swap(IList<int> arr, int first, int second)
    => (arr[first], arr[second]) = (arr[second], arr[first]);