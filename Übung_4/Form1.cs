namespace Übung_4;

public partial class Form1 : Form
{
    private Chessboard chessboard;

    public Form1()
    {
        InitializeComponent();

        chessboard = new Chessboard();

        this.Controls.AddRange(chessboard.ChessboardFields.Values.Select(chessboardField => chessboardField.panel).ToArray());

        foreach (var field in chessboard.ChessboardFields.Values)
        {
            Label label = new Label();

            label.Text = "X:" + field.Coordinate.X.ToString() + " Y:" + field.Coordinate.Y.ToString();
            label.ForeColor = Color.OrangeRed;
            field.panel.Controls.Add(label);
        }
    }
}
