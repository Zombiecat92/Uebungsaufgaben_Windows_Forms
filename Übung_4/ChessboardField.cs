namespace Übung_4;

internal class ChessboardField
{
    private const int panelSize = 50;

    public readonly ChessboardCoordinate Coordinate;
    public readonly Panel panel;

    public ChessboardField(ChessboardCoordinate coordinate, Color color, Point point)
    {
        Coordinate = coordinate;
        panel = new Panel();
        panel.BackColor = color;
        panel.Width = panelSize;
        panel.Height = panelSize;
        panel.Location = point;
    }
}
