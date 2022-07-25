namespace Übung_4;

internal class Chessboard
{
    public Dictionary<ChessboardCoordinate, ChessboardField> Fields = new();
    public readonly int BoardSize = 8;

    public void CreateChessboard()
    {
        Color[] chessboardFieldColors = new Color[] { Color.Black, Color.White };
        const int offsetX = 12;
        const int offsetY = 12;
        const int panelSize = 50;

        for (int i = 1; i <= BoardSize; i++)
        {
            for (int j = 1; j <= BoardSize; j++)
            {
                ChessboardCoordinate chessboardCoordinate = new(i, j);

                Point chessboardLocation = new(offsetX + ((chessboardCoordinate.X - 1) * panelSize), offsetY + ((BoardSize - chessboardCoordinate.Y) * panelSize));

                ChessboardField chessboardField = new(chessboardCoordinate, chessboardFieldColors[(i+j-1) % 2], chessboardLocation, panelSize);
                
                Fields.Add(chessboardCoordinate, chessboardField);
            }
        }
    }

    public Panel[] GetPanels()
    {
        return Fields.Values.Select(chessboardField => chessboardField.panel).ToArray();
    }
}
