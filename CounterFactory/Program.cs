using System;

// README.md를 읽고 아래에 코드를 작성하세요.

CounterFactory counterFactory = new CounterFactory();

Action reset;
Func<int> counter;

Func<int> simpleCounter = counterFactory.CreateSimpleCounter();
Func<int> stepCounter = counterFactory.CreateStepCounter(3);
Func<int> boundedCounter = counterFactory.CreateBoundedCounter(1, 3);

counterFactory.CreateResettableCounter(out reset, out counter);

Console.WriteLine("=== 단순 카운터 ===");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{simpleCounter()} ");
}

Console.WriteLine("\n\n=== 스텝 카운터 (step=3) ===");

for (int i = 0; i < 4; i++)
{
    Console.Write($"{stepCounter()} ");
}

Console.WriteLine("\n\n=== 범위 카운터 (1~3) ===");

for (int i = 0; i < 7; i++)
{
    Console.Write($"{boundedCounter()} ");
}

Console.WriteLine("\n\n=== 리셋 가능 카운터 ===");

Console.Write($"호출: ");

for (int i = 0; i < 3; i++)
{
    Console.Write($"{counter()} ");
}

reset();

Console.Write($"\n리셋 후: ");

for (int i = 0; i < 2; i++)
{
    Console.Write($"{counter()} ");
}