using ClassLibrary1;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange

        const int a = 3;
        const int b = 4;
        
        // Act

        var result = Class1.Summe(a, b);
        
        Assert.Equal(7, result);
    }
}
