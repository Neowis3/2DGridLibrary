namespace _2DGridLibrary;

public class Grid<T>
{
    private int XAxisLenght { get; set; }
    private int YAxisLenght { get; set; }

    public T[,] Squares { get; protected set; }

    public Grid(int xAxisLenght, int yAxisLenght, T[] squares)
    {
        XAxisLenght = xAxisLenght;
        YAxisLenght = yAxisLenght;
        SetSquares(squares);
    }

    public T[] GetLegalAdjacentSquares(Coordinate coordinate, bool includeDiagonal)
    {
        List<T> legalAdjacentSquares = new();

        if (coordinate.Y - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.South()]);
        if (coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.West()]);
        if (coordinate.Y + 1 < YAxisLenght) legalAdjacentSquares.Add(this[coordinate.North()]);
        if (coordinate.X + 1 < XAxisLenght) legalAdjacentSquares.Add(this[coordinate.East()]);
        if (includeDiagonal)
        {
            if (coordinate.Y - 1 >= 0 && coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.SouthWest()]);
            if (coordinate.Y - 1 >= 0 && coordinate.X + 1 < XAxisLenght) legalAdjacentSquares.Add(this[coordinate.SouthEast()]);
            if (coordinate.Y + 1 < YAxisLenght && coordinate.X - 1 >= 0) legalAdjacentSquares.Add(this[coordinate.NorthWest()]);
            if (coordinate.Y + 1 < YAxisLenght && coordinate.X + 1 < XAxisLenght) legalAdjacentSquares.Add(this[coordinate.NorthEast()]);
        }
        return legalAdjacentSquares.ToArray();
    }

    public void SetSquares(T[] squaresList)
    {
        if (squaresList.Length != YAxisLenght * XAxisLenght)
            throw new ArgumentException("The lenght of the array does not match the grid square count.");

        T[,] newSquares = new T[YAxisLenght, YAxisLenght];
        int positionCounter = 0;

        for (int y = 0; y < YAxisLenght; y++)
            for (int x = 0; x < XAxisLenght; ++x)
            {
                newSquares[y, x] = squaresList[positionCounter];
                positionCounter++;
            }
        Squares = newSquares;
    }

    public T this[Coordinate coordinate]
    {
        get => Squares[coordinate.Y, coordinate.X];
    }
}
