using System.Collections;

namespace Altbrot.AoC._2022._01.Test;

class CaloriesCases : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return new object[] { @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000" };
    }
}
