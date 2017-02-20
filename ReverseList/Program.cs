using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int len = 100;
            PopulateList(numbers, len);
            ReverseTheList(numbers);

            Console.ReadKey();
        }

        private static void ReverseTheList(List<int> numbers)
        {
            for(int i = numbers.Count -1; i >= 0; i--)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }

        private static void PopulateList(List<int> numbers, int len)
        {
            for (int i = 0; i < len; i++)
            {
                numbers.Add(i + 1);
            }
        }
    }
}
