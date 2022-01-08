namespace _2DGridLibrary;

public interface IGrid<T>
{
    public T[] GetLegalAdjacentSquares(Coordinate coordinate, bool includeDiagonal);
    public T[,] SetGridCoordinates();
    public T this[Coordinate coordinate] { get; }
}
