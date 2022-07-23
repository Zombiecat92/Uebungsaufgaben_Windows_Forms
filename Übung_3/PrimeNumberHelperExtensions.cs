using Übung_2;

namespace Übung_3;

public static class PrimeNumberHelperExtensions
{
    public static List<int> GetDifferencesBetweenPrimeNumbers(this PrimeNumberHelper primeNumberHelper, List<int> primeNumbers)
    {
        List<int> primeNumbersDifferences = new List<int>();

        for (int i = 0; i < primeNumbers.Count()-1; i++)
        {
            primeNumbersDifferences.Add(primeNumbers[i+1] - primeNumbers[i]);
        }

        return primeNumbersDifferences;
    }
}
