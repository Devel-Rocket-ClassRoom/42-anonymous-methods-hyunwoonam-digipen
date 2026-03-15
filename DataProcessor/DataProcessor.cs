using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



public class DataProcessor
{
    private int[] intArray;

    public DataProcessor(int[] intArray)
    {
        this.intArray = intArray;
    }
    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            action(intArray[i]);
        }
    }

    public int[] Transform(Func<int, int> transformer)
    {
        int[] result = new int[intArray.Length];

        for (int i = 0; i < intArray.Length; i++)
        {
            result[i] = transformer(intArray[i]);
        }

        return result;
    }

    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < intArray.Length; i++)
        {
            if (predicate(intArray[i]))
            {
                result.Add(intArray[i]);
            }
        }

        return result;
    }

    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int result = initialValue;

        for (int i = 0; i < intArray.Length; i++)
        {
            result = reducer(result, intArray[i]);
        }

        return result;
    }


}

