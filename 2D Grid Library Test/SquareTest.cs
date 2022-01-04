using NUnit.Framework;
using _2DGridLibrary;

namespace _2DGridLibraryTest;

public class SquareTest
{
    [Test]
    public void SquareConstructorCoordinatesTest()
    {
        Coordinate expectedSquareCoordinate = new(1, 1);

        Square<int> actualSquare = new(1, 1);

        Assert.AreEqual(expectedSquareCoordinate, actualSquare.Coordinates);
    }
}
