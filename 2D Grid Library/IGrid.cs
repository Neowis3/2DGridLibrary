namespace _2DGridLibrary;

public interface IGrid<T>
{
    public Square<T>[] GetLegalAdjacentSquares(Coordinate coordinate, bool includeDiagonal);
    public Square<T>[,] SetGridCoordinates(int xAxisLenght, int yAxisLenght);
    public Square<T> this[Coordinate coordinate] { get; }
}
