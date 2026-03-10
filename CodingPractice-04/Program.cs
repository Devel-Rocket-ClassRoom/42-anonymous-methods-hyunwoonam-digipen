using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 표현식 구문: 람다식만 가능");

    Calculator anonymous = delegate (int x) { return x * x; };
    Calculator lambda = x => x * x;

    Console.WriteLine($"익명 메서드: {anonymous(4)}");
    Console.WriteLine($"람다식: {lambda(4)}");
}

Console.WriteLine();

{
    Console.WriteLine("2. 조건부 필터링");

    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    List<int> Filter(int[] source, Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        foreach (int item in source)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    List<int> evens = Filter(numbers, delegate (int n) { return n % 2 == 0; });
    List<int> greaterThan5 = Filter(numbers, delegate (int n) { return n > 5; });

    Console.WriteLine("짝수: " + string.Join(", ", evens));
    Console.WriteLine("5보다 큰 수: " + string.Join(", ", greaterThan5));
}

Console.WriteLine();

{
    Console.WriteLine("3. 정적 익명 메서드 (C# 9.0)");

    int factor = 10;

    Func<int, int> normalMethod = delegate (int n) { return n * factor; };
    Func<int, int> staticMethod = static delegate (int n) { return n * 2; };

    Console.WriteLine(normalMethod(5));
    Console.WriteLine(staticMethod(5));
}

delegate int Calculator(int n);

