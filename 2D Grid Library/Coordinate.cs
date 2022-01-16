namespace _2DGridLibrary;

public record Coordinate(int X, int Y) : ICoordinate
{
    public Coordinate North() => new(X, Y - 1);
    public Coordinate NorthEast() => new(X + 1, Y - 1);
    public Coordinate East() => new(X + 1, Y);
    public Coordinate SouthEast() => new(X + 1, Y + 1);
    public Coordinate South() => new(X, Y + 1);
    public Coordinate SouthWest() => new(X - 1, Y + 1);
    public Coordinate West() => new(X - 1, Y);
    public Coordinate NorthWest() => new(X - 1, Y - 1);
}
