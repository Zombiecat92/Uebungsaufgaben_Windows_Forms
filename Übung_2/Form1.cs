using System.Diagnostics;

namespace Übung_2;

public partial class Form1 : Form
{
    // declaration
    private int beginNumber;
    private int endNumber;
    private List<int> primeNumbers;
    private List<int> helperPrimeNumbers;
    private int helperPrimeNumberLastCheckedNumber;

    public Form1()
    {
        InitializeComponent();

        // initalization 
        primeNumbers = new List<int>();
        helperPrimeNumbers = new List<int>();
        helperPrimeNumberLastCheckedNumber = 1;
    }

    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        // clear list and datagrid
        primeNumbers.Clear();
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
          
            // check numbers from begin to end number
            for (int i = beginNumber; i <= endNumber; i++)
            {
                // if i a prime number, add it to the list
                if (IsPrime(i))
                    primeNumbers.Add(i);
            }

            // if the list not empty, fill the datagrid
            if (primeNumbers.Count > 0)
                primeNumbers.ForEach(primeNumber => dagPrimeNumbers.Rows.Add(primeNumber.ToString()));
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    private bool IsPrime(int number)
    {
        // 2 is the first prime number
        if (number < 2)
            return false;

        // if the number allready identified as prime number
        if (helperPrimeNumbers.Contains(number))
            return true;

        // calculate the highest possible prime number for the number
        int sqrOfNumber = (int)Math.Sqrt(number);

        // check if the helper list contains the prime numbers for the check
        if (sqrOfNumber > helperPrimeNumberLastCheckedNumber)
        {
            // if not
            // check each number from last checked number to the sqrOfNumber and add them to the helper list
            for (int i = helperPrimeNumberLastCheckedNumber; i < sqrOfNumber; i++)
            {
                IsPrime(i);

                helperPrimeNumberLastCheckedNumber = i;
            }
        }

        // get all prime numbers up to sqrOfNumber
        int[] primeNumbersLowerOrEqualsSqrOfNumber = helperPrimeNumbers.Where(x => x <= sqrOfNumber).ToArray();

        // devide the number by all prime numbers up to sqrOfNumber
        for (int i = 0; i < primeNumbersLowerOrEqualsSqrOfNumber.Length; i++)
        {
            // if there is a remainder, the number is not a prime number
            if (number % primeNumbersLowerOrEqualsSqrOfNumber[i] == 0)
                return false;
        }

        // add the number as a prime number
        helperPrimeNumbers.Add(number);

        return true;
    }
}
