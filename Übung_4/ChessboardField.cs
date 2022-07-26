namespace Übung_4;

internal class ChessboardField
{
    public readonly ChessboardCoordinate Coordinate;
    public readonly PictureBox pictureBox;

    public ChessboardField(ChessboardCoordinate coordinate, Color color, Point point, int panelSize)
    {
        Coordinate = coordinate;
        pictureBox = new PictureBox
        {
            BackColor = color,
            Width = panelSize,
            Height = panelSize,
            Location = point
        };
    }
}
