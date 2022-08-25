using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                    return true;
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //int sum = 0;

            //if (numbers == null)
            //{
            //    return false; 
            //}
            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}
            //    if (sum % 2 != 0)
            //    {
            //    return true;
            //    }
            //    else return false;
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber) ? true : false; 

        }

        public char GetFirstLetterOfString(string val)
        {
            //var firstLetter = val[0];
            //return firstLetter;
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val[val.Length - 1];
            return lastLetter;
            //return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor > 0 ? dividend / divisor : 0; 
        }

        public int LastMinusFirst(int[] nums)
        {
            var lastNumber = nums[nums.Length - 1];
            var firstNumber = nums[0];
            return lastNumber - firstNumber; 
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();


            //int[] result = new int[50];
            //int index = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        result[index] = i; 
            //        index++;
            //    }
            //}
            //return result;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
