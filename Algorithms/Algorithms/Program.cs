using Algorithms.Helpers;
using ConsoleApp.fCC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region ReverseAString

            foreach (string item in ReadFileMethod.Read(@"C:\Users\Ricardo Nunes\Documents\Alg\reverse.txt"))
                Console.WriteLine($"{TextClass.REVERSE_A_STRING}{ReverseAString.Reverse(item)}");
            #endregion

            #region Factorialize
            Console.WriteLine($"{TextClass.FACTORIALIZE}{FactorializeANumber.Factorialize(5)}");
            Console.WriteLine($"{TextClass.FACTORIALIZE}{FactorializeANumber.Factorialize(10)}");
            Console.WriteLine($"{TextClass.FACTORIALIZE}{FactorializeANumber.Factorialize(20)}");
            Console.WriteLine($"{TextClass.FACTORIALIZE}{FactorializeANumber.Factorialize(0)}");
            #endregion

            #region Palindrome

            foreach (string item in ReadFileMethod.Read(@"C:\Users\Ricardo Nunes\Documents\Alg\palindrome.txt"))
                Console.WriteLine($"{TextClass.PALINDROME}{item}{": "}{ CheckForPalindrome.Palindrome(item)}");

            #endregion

            #region Longest

            foreach (string item in ReadFileMethod.Read(@"C:\Users\Ricardo Nunes\Documents\Alg\longest.txt"))
                Console.WriteLine($"{TextClass.LONGEST_WORD}{LongestWordInAString.Longest(item)}");
            #endregion

            #region TitleCase
            foreach (string item in ReadFileMethod.Read(@"C:\Users\Ricardo Nunes\Documents\Alg\title.txt"))
                Console.WriteLine($"{TextClass.TITLE_CASE_A_SENTENCE}{TitleCaseASentence.TitleCase(item)}");
            #endregion

            #region LargestNumberArrays

            int[,] arr = new int[,] { { 4, 5, 1, 3 }, { 13, 27, 18, 26 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
            int[,] arr2 = new int[,] { { 13, 27, 18, 26 }, { 4, 5, 1, 3 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
            int[,] arr3 = new int[,] { { 4, 9, 1, 3 }, { 13, 35, 18, 26 }, { 32, 35, 97, 39 }, { 1000000, 1001, 857, 1 } };

            Console.WriteLine(TextClass.LARGEST_NUMBER_IN_ARRAYS);
            foreach (int item in LargestNumberArrays.LargestOfFour(arr))
                Console.WriteLine(item);
            Console.WriteLine($"{TextClass.LARGEST_NUMBER_IN_ARRAYS} 2:");
            foreach (int item in LargestNumberArrays.LargestOfFour(arr2))
                Console.WriteLine(item);
            Console.WriteLine($"{TextClass.LARGEST_NUMBER_IN_ARRAYS} 3:");
            foreach (int item in LargestNumberArrays.LargestOfFour(arr3))
                Console.WriteLine(item);

            #endregion

            #region ConfirmEnding

            string one = "Bastian";
            string seven = "Connor";
            string two = "Walking on water and developing software from a specification are easy if both are frozen";
            string three = "He has to give me a new name";
            string four = "Open sesame";
            string five = "Open sesame";
            string six = "If you want to save our world, you must hurry. We dont know how much longer we can withstand the nothing";

            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(one, "n"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(seven, "n"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(two, "specification"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(three, "name"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(four, "same"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(five, "pen"));
            Console.WriteLine(ConfirmTheEnding.ConfirmEnding(six, "mountain"));
            #endregion

            #region RepeatAString
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("*", 3));
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("abc", 3));
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("abc", 4));
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("abc", 1));
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("*", 8));
            Console.WriteLine(RepeatAString.RepeatStringNumTimes("abc", -2));
            #endregion

            #region TruncateAString

            Console.WriteLine(TruncateAString.Truncate("A-tisket a-tasket A green and yellow basket", 11));
            Console.WriteLine(TruncateAString.Truncate("Peter Piper picked a peck of pickled peppers", 14));
            Console.WriteLine(TruncateAString.Truncate("A-tisket a-tasket A green and yellow basket", "A-tisket a-tasket A green and yellow basket".Length));
            Console.WriteLine(TruncateAString.Truncate("A-tisket a-tasket A green and yellow basket", "A-tisket a-tasket A green and yellow basket".Length + 2));
            Console.WriteLine(TruncateAString.Truncate("A-", 1));
            Console.WriteLine(TruncateAString.Truncate("Absolutely Longer", 2));

            #endregion

            #region ChunkyMonkey

            string[] x = new string[] { "a", "b", "c", "d" };
            Console.WriteLine(ChunkyMonkey.ChunkArrayInGroups(x, 2));


            #endregion

            Console.ReadLine();
        }
    }
}
