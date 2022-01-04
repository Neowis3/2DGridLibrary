namespace _2DGridLibrary;

public class Grid<T>
{
    public Square<T>[,] Squares { get; protected set; }

    public Grid(int xAxisLenght, int yAxisLenght)
    {
        Squares = SetGridCoordinates(xAxisLenght, yAxisLenght);
    }

    public Square<T>[] GetLegalAdjacentSquares(Coordinate coordinate, bool includeDiagonal)
    {
        List<Square<T>> legalAdjacentSquares = new();

        if (coordinate.Y - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.South()]);
        if (coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.West()]);
        if (coordinate.Y + 1 < Squares.GetLength(0)) legalAdjacentSquares.Add(this[coordinate.North()]);
        if (coordinate.X + 1 < Squares.GetLength(1)) legalAdjacentSquares.Add(this[coordinate.East()]);
        if (includeDiagonal)
        {
            if (coordinate.Y - 1 >= 0 && coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.SouthWest()]);
            if (coordinate.Y - 1 >= 0 && coordinate.X + 1 < Squares.GetLength(1)) legalAdjacentSquares.Add(this[coordinate.SouthEast()]);
            if (coordinate.Y + 1 < Squares.GetLength(0) && coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.NorthWest()]);
            if (coordinate.Y + 1 < Squares.GetLength(0) && coordinate.X + 1 < Squares.GetLength(1)) legalAdjacentSquares.Add(this[coordinate.NorthEast()]);
        }
        return legalAdjacentSquares.ToArray();
    }

    protected Square<T>[,] SetGridCoordinates(int xAxisLenght, int yAxisLenght)
    {
        Square<T>[,] squares = new Square<T>[yAxisLenght, xAxisLenght];

        for (int y = 0; y < squares.GetLength(0); y++)
            for (int x = 0; x < squares.GetLength(1); x++)
                squares[y, x] = new(x, squares.GetLength(0) - (y + 1));

        return squares;
    }

    public Square<T> this[Coordinate coordinate]
    {
        get => Squares[coordinate.Y, coordinate.X];
    }
}
