using System;
using System.Collections.Generic;
using System.Linq;

namespace testTaskAppA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbersSum = inputNumbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine(evenNumbersSum);

            var inputStringWithDuplicates = "aaaa   bbbc";
            var resultStringWithUniqueSymbols = RemoveDuplicates(inputStringWithDuplicates);
            Console.WriteLine(resultStringWithUniqueSymbols);

            var inputList = new List<int> { 1, 2, 3, 5 };
            RemoveOddElements(inputList);
            Console.WriteLine(string.Join(",", inputList));
        }

        private static string RemoveDuplicates(string inputString)
        {
            return string.Join("", inputString.Distinct());
        }

        private static void RemoveOddElements(List<int> inputList)
        {
            inputList.RemoveAll(x => x % 2 != 0);
        }
    }
}
