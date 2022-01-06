namespace _2DGridLibrary;

internal interface ICoordinate
{
    public Coordinate North();
    public Coordinate NorthEast();
    public Coordinate East();
    public Coordinate SouthEast();
    public Coordinate South();
    public Coordinate SouthWest();
    public Coordinate West();
    public Coordinate NorthWest();
}
