using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum() - numbers.Where (n =>n % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengthOfShortest = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return lengthOfShortest.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallestNumber = new List<int>() { number1, number2, number3, number4 };    
            return smallestNumber.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // Triangles must have: 2 sides added together is larger than the third
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;            
        }

        public bool IsStringANumber(string input)
        {   double num = 0;
            return double.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        //{
        //    if (numbers == null || numbers.Count() == 0)
        //    {
        //        return 0; 
        //    }
        //    var evens = numbers.Where(x => x % 2 == 0);

        //    if (evens.Count() == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //        return evens.Average(); 
        //}
        {
            return numbers == null || numbers.Length == 0 ? 
                0 :numbers.Where(x => x % 2 == 0).Count() == 0 ? 
                0 : numbers.Where(x => x % 2 == 0).Average();    
        }

        public int Factorial(int number)
        //{
        //    if (number < 0)
        //    {
        //        throw new ArgumentOutOfRangeException();
        //    }
        //    if (number == 0)
        //    {
        //        return 1;
        //    }
        //    return number * Factorial(number - 1);

        //}
        {
            return number == 0 ? 1 : number * Factorial(number - 1);         
        }
            
    }
}
