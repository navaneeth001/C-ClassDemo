using System.Diagnostics.Metrics;
using Xunit;

public class CounterTests
{
    [Fact]
    public void Increment_IncreaseCount_CorrectValue()
    {
        // Arrange
        Counter counter = Counter.GetInstance();
        int initialCount = counter.Count;

        // Act
        counter.Increment();

        // Assert
        Assert.Equal(initialCount + 1, counter.Count);
    }

    [Fact]
    public void Decrement_DecreaseCount_CorrectValue()
    {
        // Arrange
        Counter counter = Counter.GetInstance();
        int initialCount = counter.Count;

        // Act
        counter.Decrement();

        // Assert
        Assert.Equal(initialCount - 1, counter.Count);
    }

    [Fact]
    public void MultipleInstances_SameInstanceReturned()
    {
        // Arrange
        Counter counter1 = Counter.GetInstance();
        Counter counter2 = Counter.GetInstance();

        // Assert
        Assert.Same(counter1, counter2);
    }
}
