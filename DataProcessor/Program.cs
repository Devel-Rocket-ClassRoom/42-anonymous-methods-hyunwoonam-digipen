using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

DataProcessor processor = new DataProcessor(numbers);

int[] doubled = processor.Transform(delegate (int n)
{
    return n * 2;
});

List<int> evens = processor.Filter(delegate (int n)
{
    return n % 2 == 0;
});

int result = processor.Reduce(delegate (int sum, int n)
{
    return sum + n;
}, 0);

Console.WriteLine("=== 원본 배열 출력 ===");

processor.ForEach(delegate (int n)
{
    Console.Write($"{n} ");
});

Console.WriteLine("\n\n=== 2배로 변환 ===");

foreach (int n in doubled)
{
    Console.Write($"{n} ");
}

Console.WriteLine("\n\n=== 짝수만 필터링 ===");

foreach (int n in evens)
{
    Console.Write($"{n} ");
}

Console.WriteLine("\n\n=== 합계 계산 ===");

Console.WriteLine("합계: " + result);