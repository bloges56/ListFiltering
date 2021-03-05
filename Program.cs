using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            IEnumerable<object> nums = listOfItems.Where(item =>
            {
                return item is int;
            });

            IEnumerable<int> ints = nums.Select(num =>
            {
                return (int)num;
            });

            return ints;
        }
    }
}
