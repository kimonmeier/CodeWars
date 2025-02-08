using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSuite;

public sealed class CodeWarsSolution
{
    public string? Decompose(long n)
    {
        // Prepare Map with precomputed Values
        Dictionary<long, long> exponentialValueMap = new Dictionary<long, long>();
        Dictionary<long, long> exponentialKeyMap = new Dictionary<long, long>();
        for (int i = 1; i < n; i++)
        {
            long currentValue = n - i;
            long currentExponetial = currentValue * currentValue;

            exponentialValueMap.Add(currentExponetial, currentValue);
            exponentialKeyMap.Add(currentValue, currentExponetial);
        }


        long scoreToReach = n * n;
        List<long> result = new List<long>();

        recursiveSearch(n, n - 1, result);

        if (result.Count == 0)
        {
            return null;
        }

        result.Reverse();

        return string.Join(' ', result);
    }

    private void recursiveSearch(long exponetialStartingPoint, long currentExponential, List<long> results)
    {
        long currentResultSum = results.Sum(x => x * x);

        if (exponetialStartingPoint * exponetialStartingPoint == results.Sum(x => x * x))
        {
            return;
        }

        if (currentExponential == 0)
        {
            if (results.Count == 0)
            {
                return;
            }
            long lastExponetial = results.Last();
            results.RemoveAt(results.Count - 1);

            recursiveSearch(exponetialStartingPoint, lastExponetial - 1, results);
            return;
        }

        long[] remainingExponetial = new long[currentExponential];
        for (int i = 0; i < currentExponential; i++)
        {
            remainingExponetial[i] = currentExponential - i;
        }

        try
        {
            if (exponetialStartingPoint * exponetialStartingPoint > currentResultSum + remainingExponetial.Sum(x => x * x))
            {
                if (results.Count == 0)
                {
                    return;
                }
                long lastExponetial = results.Last();
                results.RemoveAt(results.Count - 1);

                recursiveSearch(exponetialStartingPoint, lastExponetial - 1, results);
                return;
            }
        } catch (OverflowException _)
        {
            
        }


        long scoreToReach = exponetialStartingPoint * exponetialStartingPoint;
        if (results.Sum(x => x * x) + (currentExponential * currentExponential) > scoreToReach)
        {
            if (currentExponential == 1)
            {
                long lastExponetial = results.Last();
                results.RemoveAt(results.Count);

                recursiveSearch(exponetialStartingPoint, lastExponetial - 1, results);
            } else
            {
                recursiveSearch(exponetialStartingPoint, currentExponential - 1, results);
            }
            return;
        }

        results.Add(currentExponential);
        recursiveSearch(exponetialStartingPoint, currentExponential - 1, results);
    }
}
