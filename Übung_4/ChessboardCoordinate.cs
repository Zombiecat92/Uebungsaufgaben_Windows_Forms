namespace Übung_4;

public class ChessboardCoordinate
{
    public int X;
    public int Y;

    public ChessboardCoordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public ChessboardCoordinate Add(ChessboardCoordinate summand)
    {
        return new ChessboardCoordinate(this.X + summand.X, this.Y + summand.Y);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (obj is not ChessboardCoordinate)
            return false;

        ChessboardCoordinate coordinate = (ChessboardCoordinate)obj;

        return this.X == coordinate.X && this.Y == coordinate.Y;
    }

    public override int GetHashCode()
    {
        return this.X.GetHashCode() ^ this.Y.GetHashCode();
    }
}