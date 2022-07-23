using System.Diagnostics;
using Übung_2;

namespace Übung_3;

public partial class Form1 : Form
{
    // declaration
    private int beginNumber;
    private int endNumber;
    private PrimeNumberHelper primeNumberHelper;

    public Form1()
    {
        InitializeComponent();

        // initalization
        beginNumber = 0;
        endNumber = 0;
        primeNumberHelper = new PrimeNumberHelper();
    }

    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        // clear datagrid
        dagPrimeNumbers.Rows.Clear();
    
        try
        {
            // parse input
            beginNumber = Int32.Parse(txtInput1.Text);
            endNumber = Int32.Parse(txtInput2.Text);
    
            // validate input
            if (beginNumber < 0)
                throw new Exception("The first number cannot be less than 0.");
    
            if (beginNumber >= endNumber)
                throw new Exception("The first number cannot be equal to or greater than the second number.");
    
            // calculate the prime numbers
            List<int> primeNumbers = primeNumberHelper.GetPrimeNumbersBetween(beginNumber, endNumber);

            // calculate differences
            List<int> primeNumbersDifferences = primeNumberHelper.GetDifferencesBetweenPrimeNumbers(primeNumbers);

            // group same differences
            IEnumerable<IGrouping<int, int>>? groupedPrimeNumbersDifferences = primeNumbersDifferences.GroupBy(x => x);

            // fill the datagrid
            foreach (var group in groupedPrimeNumbersDifferences)
            {
                dagPrimeNumbers.Rows.Add(group.Key.ToString(), group.Count().ToString());
            }
        }
        catch (Exception ex)
        {
            // TODO: Open new form
            Debug.WriteLine(ex);
        }
    }
}
