namespace Übung_1.Errorhandling;

public partial class ErrorForm : Form
{
    private Exception? _exceptionMassage;
    public Exception? ErrorMassage {
        get => _exceptionMassage;

        set
        {
            _exceptionMassage = value;

            lblError.Text = _exceptionMassage?.Message;

            this.ShowDialog();
        }
    }

    public ErrorForm()
    {
        InitializeComponent();
    }
}
