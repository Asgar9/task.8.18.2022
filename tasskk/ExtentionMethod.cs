using System;
using System.Collections.Generic;
using System.Text;

namespace task18._08._2022
{
    class ExtentionMethods
    {
        public static bool IsOdd(int dig)
        {
            if (dig % 2 == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(int dig)
        {
            if (dig % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(string strr)
        {
            foreach (char item in strr)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }

            return false;
        }
        public static string ToCapitalize(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(str[0]));
            sb.Append(str.Substring(1).ToLower());
            return sb.ToString();

        }
        public static int[] GetValueIndexes(this string word, char symbol)
        {

            int[] indexOf = new int[0];
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==symbol)
                {

                  count++;
                   Array.Resize(ref indexOf, count);
                indexOf[count - 1] = i;
                }
            }
            return indexOf;
        }
     
			}



    }
