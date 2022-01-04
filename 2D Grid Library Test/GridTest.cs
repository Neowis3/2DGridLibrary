using NUnit.Framework;
using _2DGridLibrary;

namespace _2DGridLibraryTest;

public class GridTest
{
    [Test]
    public void GridCoordinatesConstructorTest()
    {
        Square<int>[,] expectedGridSquares = new Square<int>[,]
        {
            { new(0, 2), new(1, 2), new(2, 2) },
            { new(0, 1), new(1, 1), new(2, 1) },
            { new(0, 0), new(1, 0), new(2, 0) },
        };

        Grid<int> actualGrid = new(3, 3);
        Square<int>[,] actualGridSquares = actualGrid.Squares;

        for (int x = 0; x < actualGridSquares.GetLength(1); x++)
            for (int y = 0; y < actualGridSquares.GetLength(0); y++)
                Assert.AreEqual(expectedGridSquares[y, x].Coordinates, actualGridSquares[y, x].Coordinates);
    }

    [Test]
    public void GetLegalAdjacentSquareTest()
    {

    }

    [Test]
    public void GridIndexerTest()
    {
        Grid<int> grid = new(3, 3);
        Square<int> expectedSquare = new(2, 2);
        Coordinate expectedCoordinate = new Coordinate(2, 2);

        Square<int> actualSquare = grid[expectedCoordinate];

        Assert.AreEqual(expectedSquare.Coordinates, actualSquare.Coordinates);
    }
}

