using NUnit.Framework;
using _2DGridLibrary;
using System.Collections.Generic;

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

    [TestCase(true)]
    [TestCase(false)]
    public void GetLegalAdjacentSquareTest(bool includeDiagonal)
    {
        Grid<int> grid = new(3, 3);
        Coordinate centerCoordinate = new(1, 1);

        Square<int>[] expectedAdjacentSquares = includeDiagonal ?
            new Square<int>[] { new(0, 2), new(1, 2), new(2, 2), new(0, 1), new(2, 1), new(0, 0), new(1, 0), new(2, 0) } :
            new Square<int>[] { new(1, 2), new(0, 1), new(2, 1), new(1, 0) };

        Square<int>[] actualAdjacentSquares = grid.GetLegalAdjacentSquares(centerCoordinate, includeDiagonal);
        List<Coordinate> actualSquareCoordinates = new();
        
        foreach (Square<int> square in actualAdjacentSquares)
            actualSquareCoordinates.Add(square.Coordinates);

        foreach (Square<int> expectedSquare in expectedAdjacentSquares)
            Assert.Contains(expectedSquare.Coordinates, actualSquareCoordinates);
    }

    [TestCase(1, 2)]
    [TestCase(2, 2)]
    [TestCase(0, 2)]
    [TestCase(2, 0)]
    public void GridIndexerTest(int inputX, int inputY)
    {
        Square<int> expectedSquare = new(inputX, inputY);

        Grid<int> grid = new(3, 3);
        Square<int> actualSquare = grid[new Coordinate(inputX, inputY)];

        Assert.AreEqual(expectedSquare.Coordinates, actualSquare.Coordinates);
    }
}
