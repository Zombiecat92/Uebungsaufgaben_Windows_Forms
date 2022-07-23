namespace Übung_4;

internal class Chessboard
{
    public Dictionary<ChessboardCoordinate, ChessboardField> ChessboardFields;

    public Chessboard()
    {
        ChessboardFields = new Dictionary<ChessboardCoordinate, ChessboardField>();

        CreateChessboard();
    }

    private void CreateChessboard()
    {
        Color[] chessboardFieldColors = new Color[] { Color.Black, Color.White };
        const int offsetX = 12;
        const int offsetY = 12;
        const int panelSize = 50;

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                ChessboardCoordinate chessboardCoordinate = new ChessboardCoordinate(i, j);

                Point chessboardLocation = new Point(offsetX + ((chessboardCoordinate.X - 1) * panelSize), offsetY + ((8 - chessboardCoordinate.Y) * panelSize));

                ChessboardField chessboardField = new ChessboardField(chessboardCoordinate, chessboardFieldColors[(i+j-1) % 2], chessboardLocation);
                
                ChessboardFields.Add(chessboardCoordinate, chessboardField);
            }
        }
    }
}
