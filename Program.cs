
namespace LoopsAndRecursions
{
    internal class Program
    {
        public static void Main()
        {
            var memberFibonacci5 = 5;
            var memberFibonacci10 = 10;
            var memberFibonacci20 = 20;

            var fibonacci5 = new Fibonacci(memberFibonacci5);
            var fibonacci10 = new Fibonacci(memberFibonacci10);
            var fibonacci20 = new Fibonacci(memberFibonacci20);
            fibonacci5.FibonacciByLoop();
            fibonacci5.FibonacciByRecursion();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            fibonacci10.FibonacciByLoop();
            fibonacci10.FibonacciByRecursion();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            fibonacci20.FibonacciByLoop();
            fibonacci20.FibonacciByRecursion();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}