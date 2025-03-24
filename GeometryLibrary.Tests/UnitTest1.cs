// CircleTests.cs
public class CircleTests
{
    [Fact]
    public void ValidRadius_CalculationsCorrect()
    {
        var circle = new Circle(2);
        Assert.Equal(12.56637, circle.Area());
        Assert.Equal(12.56637, circle.Perimeter());
    }

    [Fact]
    public void ZeroRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}

// SquareTests.cs
public class SquareTests
{
    [Fact]
    public void ValidSide_CalculationsCorrect()
    {
        var square = new Square(3);
        Assert.Equal(9, square.Area());
        Assert.Equal(12, square.Perimeter());
    }

    [Fact]
    public void NegativeSide_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Square(-1));
    }
}