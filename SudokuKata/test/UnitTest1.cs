using Xunit;
using SudokuKata;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test()
    {
        var actual = Program.Play(out string expected);
        Assert.Equal(expected, actual);
    }
}