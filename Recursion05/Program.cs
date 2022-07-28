int[] integerValues1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
Console.WriteLine($"Count = {RecursionCount(integerValues1)}");

int[] integerValues2 = { 1, 2, -1, 3, 4, 5, -3 };
Console.WriteLine($"Sum = {RecursionSum(integerValues2)}");

static int RecursionCount(ICollection<int> arr)
    => arr.Count <= 0 ? 
        0 : 
        1 + RecursionCount(arr.Skip(1).ToList());

static int RecursionSum(ICollection<int> arr)
    => arr.Count <= 0 ? 
        0 : 
        arr.First() + RecursionSum(arr.Skip(1).ToList());