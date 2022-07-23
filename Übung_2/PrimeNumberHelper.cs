namespace Übung_2;

public class PrimeNumberHelper
{
    private List<int> primeNumbers;
    private List<int> helperPrimeNumbers;
    private int helperPrimeNumberLastCheckedNumber;

    public PrimeNumberHelper()
    {
        // initalization 
        primeNumbers = new List<int>();
        helperPrimeNumbers = new List<int>();
        helperPrimeNumberLastCheckedNumber = 1;
    }

    public List<int> GetPrimeNumbersBetween(int beginNumber, int endNumber)
    {
        // clear list
        primeNumbers.Clear();

        // check numbers from begin to end number
        for (int i = beginNumber; i <= endNumber; i++)
        {
            // if i a prime number, add it to the list
            if (IsPrime(i))
                primeNumbers.Add(i);
        }

        return primeNumbers;
    }

    public bool IsPrime(int number)
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
