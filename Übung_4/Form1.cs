namespace Übung_4;

public partial class Form1 : Form
{
    private readonly Chessboard _chessboard;
    private readonly Animator _animator;
    private readonly Pathfinding _pathfinding;

    public Form1()
    {
        InitializeComponent();

        _chessboard = new Chessboard(8);
        _animator = new Animator(_chessboard);
        _pathfinding = new Pathfinding(_chessboard, _animator);

        // Create chessboard in this Form
        _chessboard.CreateChessboard(this);

        // First step for pathfinding
        Step startStep = new(_chessboard.Fields[new ChessboardCoordinate(1, 1)]);

        // Start pathfinding
        _ = _pathfinding.FindPath(startStep);
    }
}
