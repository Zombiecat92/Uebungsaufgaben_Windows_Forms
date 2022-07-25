namespace Übung_4;

public partial class Form1 : Form
{
    private readonly Chessboard _chessboard;
    private readonly Pathfinding _pathfinding;

    public Form1()
    {
        InitializeComponent();

        _chessboard = new Chessboard();
        _pathfinding = new Pathfinding(_chessboard);

        _chessboard.CreateChessboard();

        this.Controls.AddRange(_chessboard.GetPanels());
    }

    async private void button1_Click(object sender, EventArgs e)
    {
        Step? path;
        Step startStep = new(_chessboard.Fields[new ChessboardCoordinate(1, 1)]);

        path = await _pathfinding.FindPath(startStep);
        if (path != null)
            path.Field.panel.BackColor = Color.Red;

        label1.Text = path?.ToString();
    }
}
