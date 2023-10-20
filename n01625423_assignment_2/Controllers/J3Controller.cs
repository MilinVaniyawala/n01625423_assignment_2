using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace n01625423_assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Problem Description [ Hidden Palindrome ]
        /// A palindrome is a word which is the same when read forwards as it is when read backwards.For example, mom and anna are two palindromes.A word which has just one letter, such as a, is also a palindrome. Given a word, what is the longest palindrome that is contained in the word? That is, what is the longest palindrome that we can obtain, if we are allowed to delete characters from the beginning and/or the end of the string?
        /// Input Specification
        /// The input will consist of one line, containing a sequence of at least 1 and at most 40 lowercase letters.
        /// Output Specification
        /// Output the total number of letters of the longest palindrome contained in the input word.
        /// </summary>

        /// <param name="word">
        /// Sample Input 1
        /// banana
        /// Sample Input 2 
        /// abracadabra
        /// </param>

        /// <returns>
        /// Output for Sample Input 1
        /// 5
        /// Output for Sample Input 2
        /// 3
        /// </returns>
        /// To Complete J3 Task I take help from the stack overflow
        /// J3 Problem Link: https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2016/stage%201/juniorEn.pdf

        [HttpGet]
        [Route("api/J3/Palindrome/{word}")]
        public int Palindrome(string word) 
        {
            int maxLength = 1;
            int inputLength = word.Length;

            // For loop run tills the length of the string
            for (int i = 0; i < inputLength; i++)
            {
                // logic for odd length palindrome -> example: mom 
                int leftChar = i;
                int rightChar = i;

                while (leftChar > 0 && rightChar < inputLength && word[leftChar] == word[rightChar]) 
                {
                    int length = rightChar - leftChar + 1;
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                    leftChar--;
                    rightChar++;
                }

                // logic for even length palindrome -> example: anna 
                leftChar = i;
                rightChar = i + 1;

                while (leftChar >= 0 && rightChar < inputLength && word[leftChar] == word[rightChar])
                {
                    int length = rightChar - leftChar + 1;
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }

                    leftChar--;
                    rightChar++;
                }
            }
            return maxLength;
        }

    }
}