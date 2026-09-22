using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net;

internal partial class Session07
{

    static int[] InitializingRandomArray(int[] arr, int n)
    { 
        Random rnd = new Random();
        for (int i=0; i < n; i++)
        {
            arr[i] = rnd.Next(1,101);
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.Write($"Output array: ");
        foreach (int v in arr)
        {
            Console.Write($"{v} ");
        }
        Console.WriteLine("\n");
    }
    
    /// <summary>
    /// 1. to calculate the average value of array elements.
    /// </summary>
    /// <param name="args"></param>
    static float CalcAvg(int[] arr)
    {
        int sum = 0;
        foreach (int v in arr)
        {
            sum += v;
        }
        return (float) sum/ arr.Length;
    }
    
    /// <summary>
    /// 2. to test if an array contains a specific value.
    /// </summary>
    /// <param name="args"></param>
    static bool ContainSpecificValue(int[] arr, int val)
    {
        foreach (int v in arr)
        {
            if (v == val)
            return true;
        }
        return false;
    }

    /// <summary>
    /// 3. to find the index of an array element.
    /// </summary>
    /// <param name="args"></param>
    static int FindingIndex(int[] arr, int n, int val)
    {
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == val)
            return i;
        }
        return -1;
        
    }
    
    // 4. to remove a specific element from an array.
    // 5. to find the maximum and minimum value of an array.
    // 6. to reverse an array of integer values.
    // 7. to find duplicate values in an array of values.
    // 8. to remove duplicate elements from an array.
    private static void Main(string[] args)
    {
        Console.Write("Input number of elements: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        InitializingRandomArray(arr, n);
        PrintArray(arr);

        // Excercise 1
        // float avg = CalcAvg(arr);
        // Console.WriteLine($"The average of the above array is {avg:F2}");

        // Excercise 2
        // Console.Write("Input a number you want to check!: "); int val = int.Parse(Console.ReadLine());
        // bool cond = ContainSpecificValue(arr, val);
        // if (cond) Console.WriteLine($"The array contains value {val}!!");
        // else Console.WriteLine($"Sorry...The array does not contain value {val}");

        // Excercise 3
        Console.Write("Input the number you want to find: "); int val = int.Parse(Console.ReadLine());
        int idx = FindingIndex(arr, n, val);
        if (idx != -1)
        Console.WriteLine($"The index of {val} in the array is {idx}");
        else Console.WriteLine($"Cannot find the number {val} in the array");




        



    }
}