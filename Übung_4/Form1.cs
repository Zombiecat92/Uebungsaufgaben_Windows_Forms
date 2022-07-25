namespace Übung_4;

public partial class Form1 : Form
{
    private readonly Chessboard chessboard;
    private readonly Pathfinding pathfinding;

    public Form1()
    {
        InitializeComponent();

        chessboard = new Chessboard();
        chessboard.CreateChessboard();

        pathfinding = new Pathfinding(chessboard);

        this.Controls.AddRange(chessboard.ChessboardFields.Values.Select(chessboardField => chessboardField.panel).ToArray());

        foreach (var field in chessboard.ChessboardFields.Values)
        {
            Label label = new()
            {
                Text = "X:" + field.Coordinate.X.ToString() + " Y:" + field.Coordinate.Y.ToString(),
                ForeColor = Color.OrangeRed
            };

            field.panel.Controls.Add(label);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Step startStep = new Step(chessboard.ChessboardFields[new ChessboardCoordinate(1, 1)]);

        Step? path = pathfinding.FindPath(startStep);

        label1.Text = path?.ToString();
    }
}
