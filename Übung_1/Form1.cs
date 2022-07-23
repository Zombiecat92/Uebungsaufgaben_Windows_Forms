using Übung_1.Errorhandling;

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

            result = ddlSymbol.Text switch
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
            ErrorForm errorForm = new ErrorForm();
            errorForm.ErrorMassage = ex;
        }
    }
}