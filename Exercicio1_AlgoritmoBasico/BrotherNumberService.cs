using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_AlgoritmoBasico
{
    public static class BrotherNumberService
    {
        public static int LargestNumberOnNFamily(int number)
        {
            var resultString = "";
            var numbers = new List<int>();

            var charArray = number.ToString().ToArray();

            foreach (var c in charArray)
                numbers.Add(Convert.ToInt32(c.ToString()));

            numbers.Sort();
            numbers.Reverse();

            foreach (var n in numbers)
                resultString += n.ToString();

            var result = Convert.ToInt32(resultString);

            if (result >= 100000000)
                return -1;

            return result;
        }
    }
}
