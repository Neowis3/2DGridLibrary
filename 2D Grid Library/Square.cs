namespace _2DGridLibrary;

public class Square<T>
{
    public Coordinate Coordinates { get; protected set; }

    public Square(int xCoordinate, int yCoordinate)
    {
        Coordinates = new(xCoordinate, yCoordinate);
    }
}
