using NUnit.Framework;
using _2DGridLibrary;

namespace _2DGridLibraryTest;

public class CoordinateTest
{
    [Test]
    public void CoordinateConstructorTest()
    {
        int expectedXcoordinate = 1;
        int expectedYcoordinate = 2;

        Coordinate actualCoordinate = new Coordinate(1, 2);

        Assert.AreEqual(expectedXcoordinate, actualCoordinate.X);
        Assert.AreEqual(expectedYcoordinate, actualCoordinate.Y);
    }

    [Test]
    public void CoordinateNorthTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(1, 2);

        Coordinate actualNorthCoordinate = baseCoordinate.North();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateNorthEastTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(2, 2);

        Coordinate actualNorthCoordinate = baseCoordinate.NorthEast();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateEastTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(2, 1);

        Coordinate actualNorthCoordinate = baseCoordinate.East();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateSouthEastTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(2, 0);

        Coordinate actualNorthCoordinate = baseCoordinate.SouthEast();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateSouthTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(1, 0);

        Coordinate actualNorthCoordinate = baseCoordinate.South();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateSouthWestTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(0, 0);

        Coordinate actualNorthCoordinate = baseCoordinate.SouthWest();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateWestTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(0, 1);

        Coordinate actualNorthCoordinate = baseCoordinate.West();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }

    [Test]
    public void CoordinateNorthWestTest()
    {
        Coordinate baseCoordinate = new(1, 1);
        Coordinate expectedNorthCoordinate = new(0, 2);

        Coordinate actualNorthCoordinate = baseCoordinate.NorthWest();

        Assert.AreEqual(expectedNorthCoordinate, actualNorthCoordinate);
    }
}
