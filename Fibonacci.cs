using System.Diagnostics;
namespace LoopsAndRecursions
{
    internal class Fibonacci
    {
        private int _fibonacciNumber;
        private int _count = 0;
        internal Fibonacci(int fibonacciNumber)
        {
            _fibonacciNumber = fibonacciNumber;
        }
        public void FibonacciByLoop()
        {
            Stopwatch stopwatch = new();
            var _fib1 = 1;
            var _fib2 = 1;
            int _fibSum;
            stopwatch.Start();
            while (_count < (_fibonacciNumber - 2))
            {
                _fibSum = _fib1 + _fib2;
                _fib1 = _fib2;
                _fib2 = _fibSum;
                _count++;
            }
            stopwatch.Stop();
            Console.WriteLine($"Значение числа Фибоначчи для {_fibonacciNumber} члена последовательности: {_fib2}");
            Console.WriteLine($"Время затраченное на нахождение n-го члена последовательности {_fibonacciNumber} циклом: ticks: {stopwatch.ElapsedTicks}, ms {stopwatch.ElapsedMilliseconds}");
        }

        public void FibonacciByRecursion()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            CalculateFibonacciByRecursion(_fibonacciNumber);
            stopwatch.Stop();
            Console.WriteLine($"Значение числа Фибоначчи для {_fibonacciNumber} члена последовательности: {CalculateFibonacciByRecursion(_fibonacciNumber)}");
            Console.WriteLine($"Время затраченное на нахождение n-го члена последовательности {_fibonacciNumber} рекурсией: ticks: {stopwatch.ElapsedTicks}, ms {stopwatch.ElapsedMilliseconds}");
        }

        private int CalculateFibonacciByRecursion(int count)
        {
            if (count == 1 || count == 2)
            {
                return 1;
            }
            return CalculateFibonacciByRecursion(count - 1) + CalculateFibonacciByRecursion(count - 2);
        }
    }
}