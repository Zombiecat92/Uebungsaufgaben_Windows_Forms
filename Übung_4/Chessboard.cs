namespace Übung_4;

internal class Chessboard
{
    public Dictionary<ChessboardCoordinate, ChessboardField> Fields;
    public readonly int BoardSize;

    public Chessboard(int boardSize)
    {
        Fields = new();
        BoardSize = boardSize;
    }

    public void CreateChessboard(Form form)
    {
        // PictureBox settings
        Color[] chessboardFieldColors = new Color[] { Color.SandyBrown, Color.White };
        const int offsetX = 12;
        const int offsetY = 12;
        const int pictureBoxSize = 50;

        // Create picturebox grid
        for (int i = 1; i <= BoardSize; i++)
        {
            for (int j = 1; j <= BoardSize; j++)
            {
                ChessboardCoordinate chessboardCoordinate = new(i, j);

                Point chessboardLocation = new(offsetX + ((chessboardCoordinate.X - 1) * pictureBoxSize), offsetY + ((BoardSize - chessboardCoordinate.Y) * pictureBoxSize));

                ChessboardField chessboardField = new(chessboardCoordinate, chessboardFieldColors[(i+j-1) % 2], chessboardLocation, pictureBoxSize);
                
                Fields.Add(chessboardCoordinate, chessboardField);
            }
        }

        // Add pictureboxes to form as children
        form.Controls.AddRange(GetPictureBoxes());
    }

    public PictureBox[] GetPictureBoxes()
    {
        return Fields.Values.Select(chessboardField => chessboardField.pictureBox).ToArray();
    }
}
