using NUnit.Framework;
using _2DGridLibrary;

namespace _2DGridLibraryTest;

public class SquareTest
{
    [Test]
    public void SquareConstructorCoordinatesTest()
    {
        Coordinate expectedSquareCoordinate = new(1, 1);

        Square actualSquare = new DerivedSquareTest(1, 1);

        Assert.AreEqual(expectedSquareCoordinate, actualSquare.Coordinates);
    }
}

public class DerivedSquareTest : Square
{
    public DerivedSquareTest(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)  { }
}
