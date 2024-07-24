using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            CollectionSum(numbersList);
            CollectionSum(numberArray);

            Console.ReadKey();
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
