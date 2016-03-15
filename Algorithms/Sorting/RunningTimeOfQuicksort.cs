using System;
// try to use the strategy pattern
public class Sorting
{
    private ISortingType _sortingType;
    private int[] _ar;
    public Sorting(int[] ar, ISortingType sortingType)
    {
        _sortingType = sortingType;
        _ar = (int[])ar.Clone(); ;
    }
    public void SetSortingType(int[] ar, ISortingType sortingType)
    {
        _sortingType = sortingType;
        _ar = (int[])ar.Clone(); ;
    }
    public int GetD()
    {
        return _sortingType.GetD(_ar);
    }
}

public interface ISortingType
{
    void Sort(int[] ar);
    int GetD(int[] ar);
}

public class Quick : ISortingType
{
    private int _swaps = 0;
    public void Sort(int[] ar)
    {
        _swaps = 0;
        Quicksort(ar, 0, ar.Length - 1);
    }
    // Get number of quicksort swaps
    public int GetD(int[] ar)
    {
        Sort(ar);
        return _swaps;
    }
    private int Partition(int[] array, int start, int end)
    {
        int marker = start;
        for (int i = start; i <= end; i++)
        {
            if (array[i] <= array[end])
            {
                int temp = array[marker];
                array[marker] = array[i];
                array[i] = temp;
                _swaps = _swaps + 1;
                marker += 1;
            }
        }
        return marker - 1;
    }

    private void Quicksort(int[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int bound = Partition(array, start, end);
        Quicksort(array, start, bound - 1);
        Quicksort(array, bound + 1, end);
    }
}

public class Insertion : ISortingType
{
    private int _shifts = 0;
    public void Sort(int[] ar)
    {
        _shifts = 0;
        Insertionsort(ar);
    }
    // Get number of insertion sort shifts
    public int GetD(int[] ar)
    {
        Sort(ar);
        return _shifts;
    }
    private void Insertionsort(int[] ar)
    {
        _shifts = 0;
        var j = 0;
        for (var i = 1; i < ar.Length; i++)
        {
            var value = ar[i];
            j = i - 1;
            while (j >= 0 && value < ar[j])
            {
                ar[j + 1] = ar[j];
                _shifts = _shifts + 1;
                j = j - 1;
            }
            ar[j + 1] = value;
        }
    }
}

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[n];
        string elements = Console.ReadLine();
        string[] split_elements = elements.Split(' ');
        for (int i = 0; i < n; i++)
            ar[i] = Convert.ToInt32(split_elements[i]); 

        Sorting insertion = new Sorting(ar, new Insertion());
        int d1 = insertion.GetD();
        Sorting quick = new Sorting(ar, new Quick());
        int d2 = quick.GetD();
        Console.WriteLine("{0}", d1-d2);
    }
}