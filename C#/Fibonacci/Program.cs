using System;

namespace Fibonacci {
  public class FibonacciCalculator {
    public static UInt64 FibonacciCalculatorRecursive(UInt64 n) {
      if (n <= 1) return n;
      else return FibonacciCalculatorRecursive(n - 1) + FibonacciCalculatorRecursive(n - 2);
    }
    public static UInt64 FibonacciCalculatorSequential(UInt64 n) {
      UInt64 result = 0;
      UInt64 previous = 1;

      for (UInt64 i = 0; i < n; i++) {
        UInt64 temp = result;
        result = previous;
        previous = temp + previous;
      }
      return result;
    }
    public static void Main(string[] args) {
      for (int i = 1; i < args.Length; i++) {
        try {
          UInt64 value = UInt64.Parse(args[i]);
          Console.WriteLine("Fibonacci sequence number at index {0} is {1}\n", value, FibonacciCalculator.FibonacciCalculatorSequential(value));
        }
        catch(FormatException) {
          Console.WriteLine("{0}: Invalid unsigned integer parameter", args[i]);
        }
        catch(OverflowException) {
          Console.WriteLine("{0}: Overflow", args[i]);
        }
      }
    }
  }
}