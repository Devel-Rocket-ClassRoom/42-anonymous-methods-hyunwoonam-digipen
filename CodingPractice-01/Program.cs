using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 명명된 메서드를 대리자에 할당");

    Calculator calc = Square;

    int Square(int x)
    {
        return x * x;
    }

    Console.WriteLine(calc(5));
}

Console.WriteLine();

{
    Console.WriteLine("2. 반환 타입이 있는 익명 메서드");

    Transformer square = delegate (int x) { return x * x; };
    Transformer cube = delegate (int x) { return x * x * x; };

    Console.WriteLine($"3의 제곱: {square(3)}");
    Console.WriteLine($"3의 세제곱: {cube(3)}");
}

Console.WriteLine();

{
    Console.WriteLine("3. 반환 타입이 없는 익명 메서드");

    Printer print = delegate (string message) 
    { 
        Console.WriteLine($"[메시지] {message}"); 
    };

    print("안녕하세요!");
    print("익명 메서드를 사용 중입니다.");
}

Console.WriteLine();

{
    Console.WriteLine("4. Func와 Action 델리게이트 사용");

    Func<int, int> doubler = delegate (int x) { return x * 2; };
    Action<string> logger = delegate (string msg) 
    { 
        Console.WriteLine($"[LOG] {msg}"); 
    };

    Console.WriteLine(doubler(10));
    logger("작업 시작");
}

Console.WriteLine();

{
    Console.WriteLine("5. 매개변수 생략");

    SimpleDelegate handler = delegate 
    {
        Console.WriteLine("매개변수를 사용하지 않습니다.");
    };

    handler(100, "테스트");
}

Console.WriteLine();

{
    Console.WriteLine("6. 이벤트 핸들러에서의 매개변수 생략");

    EventHandler onClick = delegate 
    {
        Console.WriteLine("클릭 이벤트 발생!");
    };

    onClick(null, EventArgs.Empty);
}

delegate int Calculator(int n);
delegate int Transformer(int x);
delegate void Printer(string message);
delegate void SimpleDelegate(int n, string s);