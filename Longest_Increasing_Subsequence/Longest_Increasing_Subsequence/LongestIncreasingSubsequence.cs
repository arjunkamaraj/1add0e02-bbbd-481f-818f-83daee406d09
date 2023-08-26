using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    public class LongestIncreasingSubsequence
    {
        /// <summary>
        /// Find Longest Increasing Subsequence
        /// </summary>
        /// <param name="input">Sequence of integers seperated by spaces </param>
        /// <returns>Longest increasing subsequence present in input sequence</returns>
        public static string FindLongestIncreasingSubsequence(string input)
        {
            // Split the input string into an array of integers    
            var numbers = input.Split(' ').Select(int.Parse).ToList();

            int maxLength = int.MinValue, i = 0, j = 1, startindex = 0, prevStartIndex = 0, difference = 0;

            while (i < numbers.Count && j < numbers.Count)
            {
                if (numbers[i] < numbers[j])
                {
                    i++;

                    if (j == numbers.Count - 1)
                    {
                        // when last digit is greater than the number[i], we have to add 1 more.
                        j++;
                        difference = (j - startindex);
                        if (maxLength < difference)
                        {
                            prevStartIndex = startindex;
                            maxLength = difference;
                        }
                    }
                }
                else
                {
                    difference = (j - startindex);
                    if (maxLength < (difference))
                    {
                        prevStartIndex = startindex;
                        maxLength = difference;
                    }
                    i = j;
                    startindex = i;
                }

                j++;
            }

            var list = numbers.Skip(prevStartIndex).Take(maxLength).ToList();
            return string.Join(' ', list);

        }
    }
}
