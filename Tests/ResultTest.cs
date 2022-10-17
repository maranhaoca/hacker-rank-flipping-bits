using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        long n = 2147483647;
        
        var expected = 2147483648;
        var actual = Result.flippingBits(n);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        long n = 1;
        
        var expected = 4294967294;
        var actual = Result.flippingBits(n);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        long n = 0;
        
        var expected = 4294967295;
        var actual = Result.flippingBits(n);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test5()
    {
        long n = 9;
        
        var expected = 4294967286;
        var actual = Result.flippingBits(n);

        Assert.Equal(expected, actual);
    }
}