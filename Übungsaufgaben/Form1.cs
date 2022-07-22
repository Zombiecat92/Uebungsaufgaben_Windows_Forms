namespace Übung_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BntCalculate_Click(object sender, EventArgs error)
    {
        decimal number1;
        decimal number2;
        decimal result; 

        try {
            number1 = Decimal.Parse(txtInput1.Text);
            number2 = Decimal.Parse(txtInput2.Text);

            result = ddn.Text switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number1 / number2,
                _ => throw new ArgumentException()
            };

            lblResult.Text = "Ergebnis: " + result;
            lblResult.Visible = true;
        }
        catch (Exception ex)
        {
            // TODO: Open new window
            lblResult.Text = ex.Message;
            lblResult.Visible = true;
        }
    }
}