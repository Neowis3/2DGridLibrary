namespace _2DGridLibrary;

public abstract class Square
{
    public Coordinate Coordinates { get; protected set; }

    public Square(int xCoordinate, int yCoordinate)
    {
        Coordinates = new(xCoordinate, yCoordinate);
    }
}
