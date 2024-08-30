using Xunit;

public class AlgorithmsTests
{
    // Test for PowerOf2Iterative method
    [Fact]
    public void PowerOf2Iterative_ShouldReturnCorrectResult()
    {
        // Act & Assert
        Assert.Equal(1, Algorithms.PowerOf2Iterative(0));
        Assert.Equal(2, Algorithms.PowerOf2Iterative(1));
        Assert.Equal(4, Algorithms.PowerOf2Iterative(2));
        Assert.Equal(8, Algorithms.PowerOf2Iterative(3));
        Assert.Equal(1024, Algorithms.PowerOf2Iterative(10));
    }

    // Test for PowerOf2Recursive method
    [Fact]
    public void PowerOf2Recursive_ShouldReturnCorrectResult()
    {
        // Act & Assert
        Assert.Equal(1, Algorithms.PowerOf2Recursive(0));
        Assert.Equal(2, Algorithms.PowerOf2Recursive(1));
        Assert.Equal(4, Algorithms.PowerOf2Recursive(2));
        Assert.Equal(8, Algorithms.PowerOf2Recursive(3));
        Assert.Equal(1024, Algorithms.PowerOf2Recursive(10));
    }

    // Test for SuperPowerOf2 method
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    [InlineData(2, 4)]
    [InlineData(3, 8)]
    [InlineData(10, 1024)]
    [InlineData(31, 2147483648)] // This is a big number handled by PowerOf2Recursive
    [InlineData(32, 4294967296)] // This should be handled by PowerOf2Iterative
    public void SuperPowerOf2_ShouldReturnCorrectResult(int n, long expected)
    {
        // Act
        long result = Algorithms.SuperPowerOf2(n);
        
        // Assert
        Assert.Equal(expected, result);
    }
}
