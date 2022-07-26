namespace Übung_4;

public partial class Form1 : Form
{
    private readonly Chessboard _chessboard;
    private readonly Animator _animator;
    private readonly Pathfinding _pathfinding;

    public Form1()
    {
        InitializeComponent();

        _chessboard = new Chessboard();
        _animator = new Animator(_chessboard);
        _pathfinding = new Pathfinding(_chessboard, _animator);

        _chessboard.CreateChessboard();

        this.Controls.AddRange(_chessboard.GetPictureBoxes());

        //_chessboard.Fields[new ChessboardCoordinate(1, 1)].pictureBox.Controls.Add(pictureBox1);
        //pictureBox1.Location = new Point(0, 0);
        //pictureBox1.Image = Properties.Resources.springer_transparent;
    }

    async private void button1_Click(object sender, EventArgs e)
    {
        Step? path;
        Step startStep = new(_chessboard.Fields[new ChessboardCoordinate(1, 1)]);

        path = await _pathfinding.FindPath(startStep);
        //if (path != null)
        //    path.Field.pictureBox.BackColor = Color.Red;

        label1.Text = path?.ToString();
    }
}
