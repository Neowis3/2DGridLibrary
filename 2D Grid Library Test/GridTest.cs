using NUnit.Framework;
using _2DGridLibrary;
using System.Collections.Generic;

namespace _2DGridLibraryTest;

public class GridTest
{
    [Test]
    public void GridCoordinatesConstructorTest()
    {
        int[,] expectedGridSquares = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };

        Grid<int> actualGrid = new(3, 3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        int[,] actualGridSquares = actualGrid.Squares;

        for (int x = 0; x < actualGridSquares.GetLength(1); x++)
            for (int y = 0; y < actualGridSquares.GetLength(0); y++)
                Assert.AreEqual(expectedGridSquares[y, x], actualGridSquares[y, x]);
    }

    [TestCase(true)]
    [TestCase(false)]
    public void GetLegalAdjacentSquareTest(bool includeDiagonal)
    {
        Grid<int> grid = new(3, 3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        Coordinate centerCoordinate = new(1, 1);

        int[] expectedAdjacentSquares = includeDiagonal ?
            new int[] { 1, 2, 3, 4, 6, 7, 8, 9 } :
            new int[] { 2, 4, 6, 8 };

        int[] actualAdjacentSquares = grid.GetLegalAdjacentSquares(centerCoordinate, includeDiagonal);
        List<int> actualSquareCoordinates = new();

        foreach (int square in actualAdjacentSquares)
            actualSquareCoordinates.Add(square);

        foreach (int expectedSquare in expectedAdjacentSquares)
            Assert.Contains(expectedSquare, actualSquareCoordinates);
    }

    [TestCase(1, 2)]
    [TestCase(2, 2)]
    [TestCase(0, 2)]
    [TestCase(2, 0)]
    public void GridIndexerTest(int inputX, int inputY)
    {
        int[,] expectedGridSquares = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };

        int expectedSquare = expectedGridSquares[inputY, inputX];

        Grid<int> grid = new(3, 3, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        int actualSquare = grid[new Coordinate(inputX, inputY)];

        Assert.AreEqual(expectedSquare, actualSquare);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void SetSquaresTest(int[] squaresList)
    {
        int[,] expectedGridSquares = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };
        
        Grid<int> grid = new(3, 3, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        grid.SetSquares(squaresList);
        int[,] actualGridSquares = grid.Squares;

        for (int y = 0; y < expectedGridSquares.GetLength(0); y++)
            for (int x = 0; x < expectedGridSquares.GetLength(1); x++)
                Assert.AreEqual(expectedGridSquares[y, x], actualGridSquares[y, x]);
    }
}
