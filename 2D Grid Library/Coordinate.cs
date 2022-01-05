namespace _2DGridLibrary;

public record Coordinate(int X, int Y)
{
    public virtual Coordinate North() => new(X, Y + 1);
    public virtual Coordinate NorthEast() => new(X + 1, Y + 1);
    public virtual Coordinate East() => new(X + 1, Y);
    public virtual Coordinate SouthEast() => new(X + 1, Y - 1);
    public virtual Coordinate South() => new(X, Y - 1);
    public virtual Coordinate SouthWest() => new(X - 1, Y - 1);
    public virtual Coordinate West() => new(X - 1, Y);
    public virtual Coordinate NorthWest() => new(X - 1, Y + 1);
}
