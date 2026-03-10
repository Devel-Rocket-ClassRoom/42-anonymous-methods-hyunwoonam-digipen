using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 익명 메서드로 대리자 인스턴스 생성");

    Calculator calc = delegate (int x) { return x * x; };

    Console.WriteLine(calc(5));
}

Console.WriteLine();

{
    Console.WriteLine("2. 기본 캡처");

    int factor = 3;

    Func<int, int> multiplier = delegate (int n) { return n * factor; };

    Console.WriteLine(multiplier(10));
}

Console.WriteLine();

{
    Console.WriteLine("3. 캡처된 변수의 변경");

    int factor = 2;

    Func<int, int> multiplier = delegate (int n) { return n * factor; };

    Console.WriteLine($"factor = 2일 때: {multiplier(5)}");

    factor = 10;

    Console.WriteLine($"factor = 10일 때: {multiplier(5)}");
}

Console.WriteLine();

{
    Console.WriteLine("4. 익명 메서드 내부에서 외부 변수 수정");

    int counter = 0;

    Action increment = delegate 
    {
        counter++;

        Console.WriteLine($"현재 카운터: {counter}");
    };

    increment();
    increment();
    increment();

    Console.WriteLine($"최종 카운터: {counter}");
}

Console.WriteLine();

{
    Console.WriteLine("5. 클로저 활용: 상태 유지");

    Func<int> counter1 = CreateCounter();
    Func<int> counter2 = CreateCounter();

    Func<int> CreateCounter()
    {
        int count = 0;

        return delegate 
        {
            count++;

            return count;
        };
    }

    Console.WriteLine($"counter1: {counter1()}");
    Console.WriteLine($"counter1: {counter1()}");
    Console.WriteLine($"counter1: {counter1()}");
    Console.WriteLine($"counter2: {counter2()}");
    Console.WriteLine($"counter2: {counter2()}");

}

delegate int Calculator(int n);

