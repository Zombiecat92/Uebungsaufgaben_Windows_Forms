namespace Übung_4;

internal class ChessboardField
{
    public readonly ChessboardCoordinate Coordinate;
    public readonly Panel panel;

    public ChessboardField(ChessboardCoordinate coordinate, Color color, Point point, int panelSize)
    {
        Coordinate = coordinate;
        panel = new Panel();
        panel.BackColor = color;
        panel.Width = panelSize;
        panel.Height = panelSize;
        panel.Location = point;
    }
}
