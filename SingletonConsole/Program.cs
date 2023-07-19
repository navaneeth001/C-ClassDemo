using System.Diagnostics.Metrics;

Counter counter = Counter.GetInstance();
counter.Increment();
Console.WriteLine(counter.Count);   // Output: 1

counter.Decrement();
Console.WriteLine(counter.Count);   // Output: 0