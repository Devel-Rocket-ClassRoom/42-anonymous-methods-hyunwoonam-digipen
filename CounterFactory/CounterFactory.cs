using System;
using System.Collections.Generic;
using System.Text;


public class CounterFactory
{
    public Func<int> CreateSimpleCounter()
    {
        int count = 0;

        return delegate
        {
            count++;

            return count;
        };
    }

    public Func<int> CreateStepCounter(int step)
    {
        int count = 0;

        return delegate
        {
            count += step;

            return count;
        };
    }

    public Func<int> CreateBoundedCounter(int min, int max)
    {
        int current = min - 1;

        return delegate ()
        {
            current++;

            if (current > max)
            {
                current = min;
            }

            return current;
        };
    }

    public void CreateResettableCounter(out Action reset, out Func<int> counter)
    {
        int count = 0;

        counter = delegate ()
        {
            count++;

            return count;
        };

        reset = delegate ()
        {
            count = 0;
        };
    }
}

