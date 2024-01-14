using System.Diagnostics;
namespace LoopsAndRecursions
{
    internal class Fibonacci
    {
        private int _member;
        private int _count = 0;
        internal Fibonacci(int member)
        {
            _member = member;
        }
        public void FibonacciByLoop()
        {
            Stopwatch stopwatch = new();
            int _fib1 = 1;
            int _fib2 = 1;
            int _fibSum;
            stopwatch.Start();
            while (_count < (_member - 2))
            {
                _fibSum = _fib1 + _fib2;
                _fib1 = _fib2;
                _fib2 = _fibSum;
                _count++;
            }
            stopwatch.Stop();
            Console.WriteLine($"Значение числа Фибоначчи для {_member} члена последовательности: {_fib2}");
            Console.WriteLine($"Время затраченное на нахождение n-го члена последовательности {_member} циклом: ticks: {stopwatch.ElapsedTicks}, ms {stopwatch.ElapsedMilliseconds}");
        }

        public void FibonacciByRecursion()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            CalculateFibonacciByRecursion(_member);
            stopwatch.Stop();
            Console.WriteLine($"Значение числа Фибоначчи для {_member} члена последовательности: {CalculateFibonacciByRecursion(_member)}");
            Console.WriteLine($"Время затраченное на нахождение n-го члена последовательности {_member} рекурсией: ticks: {stopwatch.ElapsedTicks}, ms {stopwatch.ElapsedMilliseconds}");
        }

        private int CalculateFibonacciByRecursion(int count)
        {
            if (count == 1 || count == 2)
            {
                return 1;
            }
            else
            {
                return CalculateFibonacciByRecursion(count - 1) + CalculateFibonacciByRecursion(count - 2);
            }
        }
    }
}