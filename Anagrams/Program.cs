using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class Anagrams
    {

        int isAnagra(String a, String b)
        {
            int temp = -1;
            char[] word1 = a.ToCharArray();
            char[] word2 = b.ToCharArray();

            Int16[] first = new Int16[26];
            Int16[] second = new Int16[26];
            int c = 0;
            if (word1.Length == word2.Length)
            {
                temp += 1;
                for (c = 0; c < word1.Length; c++)
                {
                    first[word1[c] - 'a']++;
                }

                c = 0;
                for (c = 0; c < word2.Length; c++)
                {
                    second[word2[c] - 'a']++;

                }
                c = 0;
                for (c = 0; c < 26; c++)
                {
                    if (first[c] != second[c])
                        temp++;
                }


            }
            return temp;
        }
        int GetMaximumSubset(string[] words)
        {
            //Your code goes here
            int i, count = 0, j;
            //int MinValue = 0;

            int c = 0, temp;
            for (i = 0; i < words.Length - 1; i++)
            {
                for (j = i + 1; j < words.Length; j++)
                {
                    String a = words[i];
                    String b = words[j];
                    temp = isAnagra(a, b);
                    if (temp == 0)
                    {
                        count++;
                        break;
                    }
                    //break;
                }

            }

            return words.Length - count;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
