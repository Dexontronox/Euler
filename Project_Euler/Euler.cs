using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace Project_Euler
{
    class Euler
    {
        public static BigInteger Solution;
        public static List<string> Problems = new List<string>();
        static void Main(string[] args)
        {
            Console.Title = "Project Euler Problems";
            Console.WriteLine("Which problem?");
            ProblemList();
            Switch_Choice(Console.ReadLine());
        }
        static void ProblemList()
        {
            Problems.Add("1. Sum of the multiples of 3 and 5 below 1000");
            Problems.Add("2. Sum of all even fibonacci numbers under 4,000,000");
            Problems.Add("3. Largest prime factor of 600851475143");
            Problems.Add("4. Largest palindromic number that's a product of two three digit numbers");
            Problems.Add("5. Smallest positive number evenly divisible by all numbers 1 - 20");
            Problems.Add("6. Sum of square of first 100 natural numbers minus square of sum.");
            Problems.Add("7. Find the 10,001st prime number");
            Problems.Add("8. Largest product of 13 consecutive numbers in a given 1000-digit number");
            Problems.Add("9. Pythagorean triplet such that a + b + c = 1000");
            Problems.Add("10. Sum of all primes below 2,000,000");
            Problems.Add("11. Which four adjacent numbers in a 20x20 grid have the highest product?");
            Problems.Add("12. The first Triangle number with over 500 factors");
            Problems.Add("13. Find the first ten digits of the sum of a given list of one hundred 50-digit numbers");
            Problems.Add("14. Number under 1,000,000 that produces the longest Collatz sequence");
            Problems.Add("15. Number of routes from the top left of a 20x20 square to the bottom right");
            Problems.Add("16. Sum of the digits making up 2^1000");
            Problems.Add("17. Sum of the letters used to write out all numbers from 1 to 1000");
            Problems.Add("18. Find the maximum sum of a path down a given triangle.");
            Problems.Add("19. How many Sundays lie at the start of the month during the 20th century?");
            Problems.Add("20. Find the sum of the digits in 100!");
            Problems.Add("21. Find the sum of all amicable pairs under 10,000");
            Problems.Add("22. Apply a set of operations to a given list of 5000+ names.");
            Problems.Add("23. Sum of all positive integers that cannot be written as the sum of two abunant numbers");
            Problems.Add("24. Find the millionth entry in the lexicographic permutation of 0,1,2,3,4,5,6,7,8,9");
            Problems.Add("25. Which Fibonacci number is the first to contain 1000 digits");
            Problems.Add("26. Find the value of d (d < 1000) where 1/d contains longest recurring cycle.");
            Problems.Add("27. Find f(a,b) =  n^2 + an + b that produces that largest number of consecutive primes.");
            Problems.Add("28. Find the sum of the diagonal entries on a 1001 by 1001 clockwise spiral");
            Problems.Add("29. How many distinct terms in a^b for all a and b in [2, 100]");
            Problems.Add("30. Find all numbers that can be written as the sum of the fifth power of their digits");
            Problems.Add("31. Find all possible methods of creating £2 with any number of coins.");
            Problems.Add("32. Find the sum of all z such that x * y = z uses all digits 1 - 9");
            Problems.Add("33. Find the denominator of the product of all fractions that can be non-trivially simplified");
            Problems.Add("34. Find all numbers that are equal to the sum of the factorial of their digits");
            Problems.Add("35. How many circular primes are there below 1,000,000");
            Problems.Add("36. Find the sum of all numbers under 1,000,000 that are palindromic in base 2 and 10");
            Problems.Add("37. Find the sum of all truncatable prime numbers");
            Problems.Add("38. Find the largest 9-digit pandigital number formed from the concatenated product");
            Problems.Add("39. Which perimeter of a triangle p <= 1000 has the most solutions");
            Problems.Add("40. Product of select digits in decimal created through concatenating of integers.");
            Problems.Add("41. What is the largest n-digit pandigital prime that exists?");
            Problems.Add("42. Given a list of words, find which are 'Triangle words'.");
            Problems.Add("43. Find the largest 0 to 9 pandigital with sub-string divisibility");
            Problems.Add("44. Find the pair of pentagonal numbers whos sum and difference and pentagonal, with the smallest difference");
            Problems.Add("45. Find the first number above 40755 that is a triangle, pentagonal, and hexagonal number.");
            Problems.Add("46. Find the smallest odd composite that cannot be written as the sum of a prime plus a sqaure.");
            Problems.Add("47. Find the first four numbers to have four distinct prime factors.");
            Problems.Add("48. Find the last ten digits of 1^1 + 2^2 + 3^3 + ... + 1000^1000");
            Problems.Add("49. Concatenate the three four-digit numbers that are both prime, and permutations");
            Problems.Add("50. Which prime, below one million, can be written as the sum of the most consecutive primes?");
            Problems.Add("51. Find the smallest prime which, by replacing part of the number is part of an eight prime value family.");
            Problems.Add("52. Find the smallest possible integer x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits");
            Problems.Add("53. How many, not necessarily distinct, values of nCr, for 1 <= n <= 100, are greater than one million?");
            Problems.Add("54. A text file contains 1000 random poker hands for two players. How many times does player one win?");
            Problems.Add("55. How many Lychrel numbers are there below 10,000?");
            Problems.Add("56. What is the maximum possible value from the addition of the digits in a^b, where a, b < 100?");
            Problems.Add("57. In the first thousand expansions of root two, how many fractions contain more digits in the numerator than denominator?");
            Problems.Add("58. For an anticlockwise spiral of numbers, what is the length required to get the ratio of primes on the diagonals below 10%?");
            Problems.Add("59. Use XOR decryption to decrypt the given text file");
            Problems.Add("60. Find the lowest sum of five primes which any two concatenated make another prime");
        }
        static void Switch_Choice(string Choice)
        {
            int ChoiceInt;
            bool Open = true;
            if (int.TryParse(Choice, out ChoiceInt)) { Console.WriteLine(Problems[ChoiceInt - 1]); }
            switch (Choice)
            {
                case "1": Problem_1(); break;
                case "2": Problem_2(); break;
                case "3": Problem_3(); break;
                case "4": Problem_4(); break;
                case "5": Problem_5(); break;
                case "6": Problem_6(); break;
                case "7": Problem_7(); break;
                case "8": Problem_8(); break;
                case "9": Problem_9(); break;
                case "10": Problem_10(); break;
                case "11": Problem_11(); break;
                case "12": Problem_12(); break;
                case "13": Problem_13(); break;
                case "14": Problem_14(); break;
                case "15": Problem_15(); break;
                case "16": Problem_16(); break;
                case "17": Problem_17(); break;
                case "18": Problem_18(); break;
                case "19": Problem_19(); break;
                case "20": Problem_20(); break;
                case "21": Problem_21(); break;
                case "22": Problem_22(); break;
                case "23": Problem_23(); break;
                case "24": Problem_24(); break;
                case "25": Problem_25(); break;
                case "26": Problem_26(); break;
                case "27": Problem_27(); break;
                case "28": Problem_28(); break;
                case "29": Problem_29(); break;
                case "30": Problem_30(); break;
                case "31": Problem_31(); break;
                case "32": Problem_32(); break;
                case "33": Problem_33(); break;
                case "34": Problem_34(); break;
                case "35": Problem_35(); break;
                case "36": Problem_36(); break;
                case "37": Problem_37(); break;
                case "38": Problem_38(); break;
                case "39": Problem_39(); break;
                case "40": Problem_40(); break;
                case "41": Problem_41(); break;
                case "42": Problem_42(); break;
                case "43": Problem_43(); break;
                case "44": Problem_44(); break;
                case "45": Problem_45(); break;
                case "46": Problem_46(); break;
                case "47": Problem_47(); break;
                case "48": Problem_48(); break;
                case "49": Problem_49(); break;
                case "50": Problem_50(); break;
                case "52": Problem_52(); break;
                case "53": Problem_53(); break;
                case "55": Problem_55(); break;
                case "56": Problem_56(); break;
                case "test": Test_Function(); break;
                default: Open = false; break;
            }
            if (Open == true && int.TryParse(Choice, out ChoiceInt)) { Open_Problem(Choice); }
        }
        static void Open_Problem(string Problem)
        {
            string response;
            Console.WriteLine("Open the webpage for this problem? Y/N");
            response = Console.ReadLine().ToLower();
            if (response == "yes" || response == "y") { System.Diagnostics.Process.Start("https:\\projecteuler.net\\problem=" + Problem); }
        }

        static Boolean isPalindrome(BigInteger PalinTest)
        {
            if (PalinTest == Reversal(PalinTest)) { return true; }
            else { return false; }
        }
        static Boolean isPrime(int Number)
        {
            if (Number <= 1) { return false; }
            for (int i = 2; i*i <= Number; i++) { if (Number % i == 0) { return false; } }
            return true;
        }
        static Boolean isPandigital(string n)
        {
            char[] digits;
            string sorted;
            if (n.Length == 1) { return false; }
            digits = n.ToCharArray();
            Array.Sort(digits);
            sorted = new string(digits);
            for (int i = 0; i < digits.Length; i++) { if (int.Parse(digits[i].ToString()) != i) { return false; } }
            return true;
        }
        static Boolean isTriangle(int Number)
        {
            double discriminant = Math.Sqrt((8 * Number) + 1);
            int IntDiscriminant = 0;
            if (int.TryParse(discriminant.ToString(), out IntDiscriminant)) { if (-1 + IntDiscriminant % 2 == 0) { return true; } else { return false; } }
            else { return false; }
        }
        static Boolean isPentagonal(int Number)
        {
            // P(n) = n(3n - 1) / 2
            // 3*n^2 - n - 2P(n) = 0
            // Quadratic formula on ^
            int result = 0;
            double Unpentagonal = Math.Sqrt((Number * 24) + 1);
            if (int.TryParse(Unpentagonal.ToString(),out result)) { if ((result + 1) % 6 == 0) { return true; } else { return false; } }
            else { return false; }
        }
        static Boolean isHexagonal(int Number)
        {
            double Discriminant = Math.Sqrt(1 + 8 * Number);
            int IntDiscriminant = 0;
            if (int.TryParse(Discriminant.ToString(), out IntDiscriminant)) { if ((1 + IntDiscriminant) % 4 == 0) { return true; } else { return false; } }
            else { return false; }
        }

        static List<List<int>> Problem_11_Table()
        {
            List<List<int>> Result = new List<List<int>>();
            int[] RowOne = { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 4, 5, 7, 78, 52, 12, 50, 77, 91, 8 };
            int[] RowTwo = { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 0 };
            int[] RowThree = { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 3, 49, 13, 36, 65 };
            int[] RowFour = { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24, 68, 56, 1, 32, 56, 71, 37, 2, 36, 91 };
            int[] RowFive = { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 };
            int[] RowSix = { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 };
            int[] RowSeven = { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 };
            int[] RowEight = { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91, 66, 49, 94, 21 };
            int[] RowNine = { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 };
            int[] RowTen = { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45, 35, 14, 0, 61, 33, 97, 34, 31, 33, 95 };
            int[] RowEleven = { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 3, 80, 4, 62, 16, 14, 9, 53, 56, 92 };
            int[] RowTwelve = { 16, 39, 5, 42, 96, 35, 31, 47, 55, 58, 88, 24, 0, 17, 54, 24, 36, 29, 85, 57 };
            int[] RowThirteen = { 86, 56, 0, 48, 35, 71, 89, 7, 5, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 };
            int[] RowFourteen = { 19, 80, 81, 68, 5, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 4, 89, 55, 40 };
            int[] RowFifteen = { 4, 52, 8, 83, 97, 35, 99, 16, 7, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 };
            int[] RowSixteen = { 88, 36, 68, 87, 57, 62, 20, 72, 3, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 };
            int[] RowSeventeen = { 4, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32, 40, 62, 76, 36 };
            int[] RowEighteen = { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 4, 36, 16 };
            int[] RowNineteen = { 20, 73, 35, 29, 78, 31, 90, 1, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 5, 54 };
            int[] RowTwenty = { 1, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 1, 89, 19, 67, 48 };
            Result.Add(RowOne.ToList<int>()); Result.Add(RowTwo.ToList<int>()); Result.Add(RowThree.ToList<int>());
            Result.Add(RowFour.ToList<int>()); Result.Add(RowFive.ToList<int>()); Result.Add(RowSix.ToList<int>());
            Result.Add(RowSeven.ToList<int>()); Result.Add(RowEight.ToList<int>()); Result.Add(RowNine.ToList<int>());
            Result.Add(RowTen.ToList<int>()); Result.Add(RowEleven.ToList<int>()); Result.Add(RowTwelve.ToList<int>());
            Result.Add(RowThirteen.ToList<int>()); Result.Add(RowFourteen.ToList<int>()); Result.Add(RowFifteen.ToList<int>());
            Result.Add(RowSixteen.ToList<int>()); Result.Add(RowSeventeen.ToList<int>()); Result.Add(RowEighteen.ToList<int>());
            Result.Add(RowNineteen.ToList<int>()); Result.Add(RowTwenty.ToList<int>()); return Result;
        }
        static int AlphabeticalValue(char Letter)
        {
            switch (Letter)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 5;
                case 'F':
                    return 6;
                case 'G':
                    return 7;
                case 'H':
                    return 8;
                case 'I':
                    return 9;
                case 'J':
                    return 10;
                case 'K':
                    return 11;
                case 'L':
                    return 12;
                case 'M':
                    return 13;
                case 'N':
                    return 14;
                case 'O':
                    return 15;
                case 'P':
                    return 16;
                case 'Q':
                    return 17;
                case 'R':
                    return 18;
                case 'S':
                    return 19;
                case 'T':
                    return 20;
                case 'U':
                    return 21;
                case 'V':
                    return 22;
                case 'W':
                    return 23;
                case 'X':
                    return 24;
                case 'Y':
                    return 25;
                case 'Z':
                    return 26;
                default:
                    if (Letter != '"') { throw new Exception("Found" + Letter.ToString()); }
                    return 0;
            }
        }
        private static BigInteger Factorial(int i)
        {
            if (i == 0) { return 1; }
            BigInteger p = 1;
            for (int j = 1; j <= i; j++) { p *= j; }
            return p;
        }
        static int GCD(int numerator, int demoninator)
        {
            int GreatestCommon = 0;          
                for (int i = 1; i <= Math.Min(numerator, demoninator); i++)
                {
                    if (numerator % i == 0 && demoninator % i == 0) { GreatestCommon = i; }
                }
            return (Convert.ToInt32(demoninator) / GreatestCommon);
        }
        static List<BigInteger> Permutations(BigInteger[] elements)
        {
            List<BigInteger> GivenElements = new List<BigInteger>();
            List<BigInteger> RecursiveResult = new List<BigInteger>();
            List<BigInteger> Result = new List<BigInteger>();
            BigInteger Temp = 0;
            GivenElements = elements.ToList<BigInteger>();
            for (int i = 0; i <= elements.Length - 1; i++) { if (elements[i] / 10 > 0) { return Result; } }
            if (elements.Length == 1) { Result.Add(elements[0]); return Result; }
            if (elements.Length == 2)
            {
                Result.Add((elements[0] * 10) + elements[1]); Result.Add((elements[1] * 10) + elements[0]);
                return Result;
            }
            for (int i = 0; i <= elements.Length - 1; i++)
            {
                GivenElements = elements.ToList<BigInteger>();
                GivenElements.RemoveAt(i);
                RecursiveResult = Permutations(GivenElements.ToArray<BigInteger>());
                foreach (int x in RecursiveResult) { Result.Add(x + (elements[i] * Convert.ToInt32(Math.Pow(10, elements.Length - 1)))); }
            }
            return Result;
        }
        static List<int> PrimeFactors(int Number)
        {
            List<int> DivisiblePrimes = new List<int>();
            List<int> AllPrimes = new List<int>();
            int NumberTemp = Number;
            for (int i = 2; i <= Math.Sqrt(Number); i++)
            {
                if (isPrime(i))
                {
                    AllPrimes.Add(i);
                    if (isPrime(Number / i)) { AllPrimes.Add(Number / i); }
                }
            }
            for (int i = 0; i <= AllPrimes.Count - 1; i++)
            {
                if (NumberTemp == 1) { break; }
                while (NumberTemp % AllPrimes[i] == 0)
                {
                    NumberTemp /= AllPrimes[i];
                    DivisiblePrimes.Add(AllPrimes[i]);
                }
            }
            return DivisiblePrimes;
        }
        static int FindNextPrime(int MaxPrime)
        {
            int count = MaxPrime;
            if (count % 2 == 0) { count++; if (isPrime(count)) { return count; } }
            do { count += 2; if (isPrime(count)) { return count; } } while (true);
        }
        static double Decimal_Root_Two_Recursion(int RecursionCount, int MaxCount)
        {
            if (RecursionCount == 1) { return (double)1 / (double)2; }
            else if (RecursionCount > 1 && RecursionCount < MaxCount) { return (double)(1 / (2 + Decimal_Root_Two_Recursion(RecursionCount - 1, MaxCount))); }
            else if (RecursionCount == MaxCount) { return 1 + (double)(1 / (2 + Decimal_Root_Two_Recursion(RecursionCount - 1, MaxCount))); }
            else return 0;
        }
        static List<double> Fractional_Root_Two_Recursion(double nume, double denom, int count)
        {
            List<double> ReturnList = new List<double>();
            double DenomResult = denom;
            if (count < 10000)
            {
                DenomResult += (double)Fractional_Root_Two_Recursion(nume, denom, count + 1)[0] / (double)Fractional_Root_Two_Recursion(nume, denom, count + 1)[1];
            }
            ReturnList.Add(nume);
            ReturnList.Add(DenomResult);

            return ReturnList;
        }
        static BigInteger Reversal(BigInteger Reverse)
        {
            BigInteger result = 0;
            BigInteger storage = Reverse;
            int length = Reverse.ToString().Length;
            if (Reverse < 10) { return Reverse; }
            for (int i = 1; i <= length; i++)
            {
                result += (storage % 10) * (BigInteger)Math.Pow(10, length - i);
                storage /= 10;
            }
            return result;
        }
        static BigInteger TriPentHexNumberConvert(string Type, BigInteger toConvert, BigInteger Converted)
        {
            if (toConvert > int.MaxValue || Converted > int.MaxValue) { return 0; }
            if (Type == "Tri")
            {
                if (Converted == 0) { return ((toConvert * (toConvert + 1)) / 2); }
                if (toConvert == 0 && isTriangle(Convert.ToInt32(Converted))) { return (BigInteger)((-1 + Math.Sqrt((8 * Convert.ToInt32(Converted)) + 1)) / 2); }
                else { return 0; }
            }
            else if (Type == "Pent")
            {
                if (Converted == 0) { return ((toConvert * ((3 * toConvert) - 1)) / 2); }
                if (toConvert == 0 && isPentagonal(Convert.ToInt32(Converted))) { return (BigInteger)((1 + Math.Sqrt((Convert.ToInt32(Converted) * 24) + 1)) / 6); }
                else { return 0; }
            }
            else if (Type == "Hex")
            {
                if (Converted == 0) { return (toConvert * ((2 * toConvert) - 1)); }
                if (toConvert == 0 && isHexagonal(Convert.ToInt32(Converted))) { return (BigInteger)((1 + Math.Sqrt(1 + (8 * Convert.ToInt32(Converted)))) / 4); }
                else { return 0; }
            }
            else { return 0; }
        }
        static List<int> XtotheX(int x)
        {
            // Returns Digits in reverse order
            List<int> Digits = new List<int>();
            int storage = x;
            do { Digits.Add(storage % 10); storage /= 10; } while (storage > 0);
            for (int i = 1; i <= x - 1; i++)
            {
                for (int j = 0; j <= Digits.Count - 1; j++) { Digits[j] *= x; }
                for (int j = 0; j <= Digits.Count - 1; j++)
                {
                    do
                    {
                        if (Digits[j] >= 10) { if (j == Digits.Count - 1) { Digits.Add(Digits[j] / 10); Digits[j] %= 10; } else { Digits[j + 1] += Digits[j] / 10; Digits[j] %= 10; } }
                    } while (Digits[j] >= 10);
                }
            }
            return Digits;
        }
        static int Problem_51_Family_Test(List<int> Numbers)
        {
            List<int> Digits = Numbers;
            int storage = 0, PrimeCount = 0, smallest = 0;
            bool smallestrecorded = false;
            for (int i = 0; i <= Numbers.Count - 1; i++)
            {
                for (int j = i + 1; j <= Numbers.Count - 1; j++)
                {
                    for (int k = j + 1; k <= Numbers.Count - 1; k++)
                    {
                        for (int repeat = 0; repeat <= 2; repeat++)
                        {
                            smallestrecorded = false; Digits = Numbers; PrimeCount = 0;
                            for (int count = 0; count <= (9 - repeat); count++)
                            {
                                storage = 0;
                                Digits[i] = repeat + count; Digits[j] = repeat + count; Digits[k] = repeat + count;
                                for (int f = 0; f <= Numbers.Count - 1; f++) { storage = (storage * 10) + Numbers[f]; }
                                if (storage.ToString().Length < Numbers.Count) { continue; }
                                if (isPrime(storage)) { PrimeCount++; if (smallestrecorded == false) { smallest = storage; smallestrecorded = true; } }
                            }
                            if (PrimeCount == 8)
                            { return smallest; }

                        }
                    }
                }
            }
            if (PrimeCount == 8) { return storage; } else { return 0; }
        }
        static bool ListEquality(List<int> One, List<int> Two)
        {
            return One.Count == Two.Count && new HashSet<int>(One).SetEquals(Two);
        }
        static void Problem54_HandEvaluator(string[] Player_Hand, out string Player_Result, out string[] Ordered_Hand)
        {
            Player_Result = ""; Ordered_Hand = new string[5];
            string[] CardValues = new string[5], CardSuits = new string[5]; int[] CardValue_Numbers = new int[5];
            char[] CardSplit = new char[2];
            if (Player_Hand.Length != 5) { return; }
            for (int i = 0; i <= 4; i++) { CardSplit = Player_Hand[i].ToCharArray(); CardValues[i] = CardSplit[0].ToString(); CardSuits[i] = CardSplit[1].ToString(); }
            CardValue_Numbers = Array.ConvertAll(Problem54_CardValues(CardValues, "Convert"), Value => int.Parse(Value)); Array.Sort(CardValue_Numbers); Array.Reverse(CardValue_Numbers);
            Ordered_Hand = Problem54_OrderedHand(Array.ConvertAll(CardValues, x => Convert.ToChar(x)), Array.ConvertAll(CardSuits, x => Convert.ToChar(x)), CardValue_Numbers);
            if (Player_Hand.Contains<string>("A") && Player_Hand.Contains<string>("K") && Player_Hand.Contains<string>("Q") && Player_Hand.Contains<string>("J") &&
                Player_Hand.Contains<string>("T") && CardSuits.Distinct().Count() == 1) { Player_Result = "Royal Flush"; return; }
            else if (Player_Hand.All(Card => Card.Contains("S"))) { Player_Result = "Flush Spades"; }
            else if (Player_Hand.All(Card => Card.Contains("H"))) { Player_Result = "Flush Hearts"; }
            else if (Player_Hand.All(Card => Card.Contains("D"))) { Player_Result = "Flush Diamonds"; }
            else if (Player_Hand.All(Card => Card.Contains("C"))) { Player_Result = "Flush Clubs"; }
            if (Player_Result != "" && Player_Result.Substring(0, 4) == "Flush" && !CardValue_Numbers.Select((i, j) => i - j).Distinct().Skip(1).Any()) { Player_Result = "Straight " + Player_Result; return; }
            if (Player_Result != "") { return; }
            string[] FrequencyOrder = CardValues.OrderByDescending(g => g.Count()).ToArray();
            int MostFrequentCount = Convert.ToInt32(CardValues.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First().Count());
            if (!CardValue_Numbers.Select((i,j) => i - j).Distinct().Skip(1).Any()) { Player_Result = "Straight " + Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, x => x.ToString()), "Revert")[0]; }
            switch (CardValues.Distinct().Count())
            {
                case 2:
                    if (MostFrequentCount == 3) { Player_Result = "Full House " + FrequencyOrder[0] + " and " + FrequencyOrder[3]; return; }
                    if (MostFrequentCount == 4) { Player_Result = "Four of a Kind " + FrequencyOrder[0]; return; }
                    break;
                case 3: 
                    if (MostFrequentCount == 2) { Player_Result = "Two Pair " + FrequencyOrder[0] + " and " + FrequencyOrder[1]; return; }
                    if (MostFrequentCount == 3) { Player_Result = "Three of a Kind " + FrequencyOrder[0]; return; }
                    break;
                case 4:
                    Player_Result = "Pair " + FrequencyOrder[0]; return;
                case 5:
                    Player_Result = "Highest Card " + Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, Number => Number.ToString()), "Revert")[0]; return;
                default: break;
            }
            return;
        }
        static string[] Problem54_OrderedHand(char[] CardValues, char[] CardSuits, int[] CardValue_Numbers)
        {
            string[] Result = new string[5];
            Result = Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, x => x.ToString()), "Revert");
            for (int i = 0; i <= 4; i++) { for (int j = 0; j <= 4; j++) { if (Convert.ToChar(Result[i]) == CardValues[j]) { Result[i] += CardSuits[j]; break; } } }
            return Result;
        }
        static void Problem54_RoundWinner(string PlayerOne_Result, string[] PlayerOne_Hand, string PlayerTwo_Result, string[] PlayerTwo_Hand, out string Winner)
        {
            Winner = "";
            string[] PlayerOne_CardSuits = new string[5], PlayerTwo_CardSuits = new string[5];
            string[] PlayerOne_CardValues = new string[5], PlayerTwo_CardValues = new string[5];
            char[] Cardsplit;
            for (int i = 0; i <= 4; i++)
            {
                Cardsplit = PlayerOne_Hand[i].ToCharArray(); PlayerOne_CardValues[i] = Cardsplit[0].ToString(); PlayerOne_CardSuits[i] = Cardsplit[1].ToString();
                Cardsplit = PlayerTwo_Hand[i].ToCharArray(); PlayerTwo_CardValues[i] = Cardsplit[0].ToString(); PlayerTwo_CardSuits[i] = Cardsplit[1].ToString();
            }
            if (PlayerOne_Result.Contains("Royal") && PlayerTwo_Result.Contains("Royal") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Royal") && PlayerOne_Result.Contains("Royal") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight Flush") && PlayerTwo_Result.Contains("Straight Flush") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Straight Flush") && PlayerOne_Result.Contains("Straight Flush") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight Flush") && PlayerTwo_Result.Contains("Straight Flush"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Four") && PlayerTwo_Result.Contains("Four") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Four") && PlayerOne_Result.Contains("Four") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Four") && PlayerTwo_Result.Contains("Four"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                    if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                    if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Full") && PlayerTwo_Result.Contains("Full") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Full") && PlayerOne_Result.Contains("Full") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Full") && PlayerTwo_Result.Contains("Full"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Flush") && PlayerTwo_Result.Contains("Flush") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Flush") && PlayerOne_Result.Contains("Flush") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Flush") && PlayerTwo_Result.Contains("Flush"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Straight") && PlayerTwo_Result.Contains("Straight") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Straight") && PlayerOne_Result.Contains("Straight") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight") && PlayerTwo_Result.Contains("Straight"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Three") && PlayerTwo_Result.Contains("Three") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Three") && PlayerOne_Result.Contains("Three") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Three") && PlayerTwo_Result.Contains("Three"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (int.Parse(P1FrequencyOrder[3]) > int.Parse(P2FrequencyOrder[3])) { Winner = "Player One"; return; }
                    if (int.Parse(P2FrequencyOrder[3]) > int.Parse(P1FrequencyOrder[3])) { Winner = "Player Two"; return; }

                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Two") && PlayerTwo_Result.Contains("Two") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Two") && PlayerOne_Result.Contains("Two") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Two") && PlayerTwo_Result.Contains("Two"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (int.Parse(P1FrequencyOrder[2]) > int.Parse(P2FrequencyOrder[2])) { Winner = "Player One"; return; }
                    if (int.Parse(P2FrequencyOrder[2]) > int.Parse(P1FrequencyOrder[2])) { Winner = "Player Two"; return; }
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("One") && PlayerTwo_Result.Contains("One") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("One") && PlayerOne_Result.Contains("One") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("One") && PlayerTwo_Result.Contains("One"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Highest") && PlayerTwo_Result.Contains("Highest"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");                
                if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
            }
        }
        static string[] Problem54_CardValues(string[] CardNumbers, string Convert_Revert)
        {
            string[] result = new string[5];
            if (CardNumbers.Length < 5) { return null; }
            if (Convert_Revert == "Convert")
            {
                for (int i = 0; i <= 4; i++)
                {
                    switch (CardNumbers[i])
                    {
                        case "2": result[i] = "2"; break;
                        case "3": result[i] = "3"; break;
                        case "4": result[i] = "4"; break;
                        case "5": result[i] = "5"; break;
                        case "6": result[i] = "6"; break;
                        case "7": result[i] = "7"; break;
                        case "8": result[i] = "8"; break;
                        case "9": result[i] = "9"; break;
                        case "T": result[i] = "10"; break;
                        case "J": result[i] = "11"; break;
                        case "Q": result[i] = "12"; break;
                        case "K": result[i] = "13"; break;
                        case "A": result[i] = "14"; break;
                        default: break;
                    }
                }
            }
            else if (Convert_Revert == "Revert")
            {
                for (int i = 0; i<= 4; i++)
                {
                    switch (CardNumbers[i])
                        {
                        case "14": result[i] = "A"; break;
                        case "13": result[i] = "K"; break;
                        case "12": result[i] = "Q"; break;
                        case "11": result[i] = "J"; break;
                        case "10": result[i] = "T"; break;
                        case "9": result[i] = "9"; break;
                        case "8": result[i] = "8"; break;
                        case "7": result[i] = "7"; break;
                        case "6": result[i] = "6"; break;
                        case "5": result[i] = "5"; break;
                        case "4": result[i] = "4"; break;
                        case "3": result[i] = "3"; break;
                        case "2": result[i] = "2"; break;
                            default: break;
                        }
                }

            }

            return result;
        }

        static void Test_Function()
        {
            Problem_54();
            Console.ReadKey();
        }

        static void Problem_1()
        {
            int Solution = 0;
            for (int i = 0; i < 1000; i++) { if (i % 5 == 0 | i % 3 == 0) { Solution += i; } }
            Console.WriteLine("The sum of all multiples of 3 and 5 below 1000 is " + Solution);
        }
        static void Problem_2()
        {
            int Solution = 0;
            int a = 1, b = 2, c = 0;
            Solution += b;
            do
            {
                c = a + b; a = b; b = c;
                if (c % 2 == 0) { Solution += c; }
            } while (a < 4000000 & b < 4000000);
            Console.WriteLine("Sum of all even fibonacci numbers under 4,000,000 is " + Solution);
        }
        static void Problem_3()
        {
            long Storage = 600851475143;
            Console.WriteLine("The largest prime factor of 600851475143 is found by dividing it by the smallest factor to find what remains:");
            for (long i = 2; i <= Math.Sqrt(Storage); i++)
            {
                if (Storage % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + Storage + " so we divide it out. Giving " + (Storage / i));
                    Storage /= i;
                }
            }
            Console.WriteLine("So the solution is: " + Storage);
        }
        static void Problem_4()
        {
            int Storage;
            string Storagestring, ReverseStorage;
            char[] ReverseStorageChars;
            char CharStore;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    Storage = i * j;
                    Storagestring = Storage.ToString();
                    ReverseStorageChars = Storagestring.ToCharArray();
                    for (int k = 0; k < ReverseStorageChars.Length / 2; k++)
                    {
                        CharStore = ReverseStorageChars[k];
                        ReverseStorageChars[k] = ReverseStorageChars[(ReverseStorageChars.Length - 1) - k];
                        ReverseStorageChars[(ReverseStorageChars.Length - 1) - k] = CharStore;
                    }
                    ReverseStorage = new string(ReverseStorageChars);
                    if (Storagestring.Equals(ReverseStorage) & Storage > Solution) { Solution = Storage; }
                }
            }
            Console.WriteLine("Largest palindromic number that's a product of two three digit numbers: " + Solution);
        }
        static void Problem_5()
        {
            int Test = 1;
            bool SolutionFound = false;
            do
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (Test % i == 0) { if (i == 20) { SolutionFound = true; Solution = Test; } continue; }
                    else { Test += 1; break; }
                }
            } while (SolutionFound == false);
            Console.WriteLine("Smallest positive number evenly divisible by numbers 1 - 20 is: " + Solution);
        }
        static void Problem_6()
        {
            int SumSquares = 0, SumSquared = 0, Difference = 0;
            for (int i = 0; i <= 100; i++) { SumSquares += (i * i); SumSquared += i; }
            Difference = Math.Max(SumSquared * SumSquared, SumSquares) - Math.Min(SumSquares, (SumSquared * SumSquared));
            Console.WriteLine("The difference is " + Difference);
        }
        static void Problem_7()
        {
            List<int> Primes = new List<int>();
            Primes.Add(2);
            Primes.Add(3);
            do
            {
                Primes.Add(FindNextPrime(Primes.Max()));
            } while (Primes.Count <= 10000);
            Console.WriteLine("The 10,001st prime is: " + Primes[10000]);
        }
        static void Problem_8()
        {
            string Number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long MaxProd = 0;
            long Storage = 1;
            for (int j = 0; j < Number.Length - 14; j++)
            {
                for (int i = 0; i < 13; i++) { Storage *= int.Parse(Number.ElementAt(j + i).ToString()); }
                if (Storage > MaxProd) { MaxProd = Storage; }
                Storage = 1;
            }
            Console.WriteLine("The largest product of 13 numbers in the given sequence is: " + MaxProd);
        }
        static void Problem_9()
        {
            int Finala = 0; int Finalb = 0; int Finalc = 0;
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if ((a * a) + (b * b) == (c * c)) { Finala = a; Finalb = b; Finalc = c; break; }
                }
            }
            Console.WriteLine("a = " + Finala + " b = " + Finalb + " c = " + Finalc + "a * b * c = " + (Finala * Finalb * Finalc));
        }
        static void Problem_10()
        {
            for (int i = 1; i < 2000000; i++)
            {
                if (isPrime(i) == true) { Solution += i; }
            }
            Console.WriteLine("Sum of all primes under 2,000,000 is " + Solution);
        }
        static void Problem_11()
        {
            List<List<int>> Table = new List<List<int>>();
            Table = Problem_11_Table();
            int BiggestProduct = 0;
            int Product = 0;
            // Left
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    Product = Table[j][i] * Table[j][i + 1] * Table[j][i + 2] * Table[j][i + 3];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            // Right
            for (int j = 0; j < 20; j++)
            {
                for (int i = 19; i > 3; i--)
                {
                    Product = Table[j][i] * Table[j][i - 1] * Table[j][i - 2] * Table[j][i - 3];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            // Down
            for (int j = 0; j < 16; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Product = Table[j][i] * Table[j + 1][i] * Table[j + 2][i] * Table[j + 3][i];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            // Up
            for (int j = 19; j < 3; j--)
            {
                for (int i = 0; i < 20; i++)
                {
                    Product = Table[j][i] * Table[j - 1][i] * Table[j - 2][i] * Table[j - 3][i];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            // Diagonal
            for (int j = 0; j < 16; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    Product = Table[j][i] * Table[j + 1][i + 1] * Table[j + 2][i + 2] * Table[j + 3][i + 3];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            for (int j = 19; j > 3; j--)
            {
                for (int i = 19; i > 3; i--)
                {
                    Product = Table[j][i] * Table[j - 1][i - 1] * Table[j - 2][i - 2] * Table[j - 3][i - 3];
                    if (Product > BiggestProduct) { BiggestProduct = Product; }
                }
            }
            Console.WriteLine(BiggestProduct);
        }
        static void Problem_12()
        {
            int TriangleSize = 7;
            int TriangleNumber = 0;
            int Factors = 0;
            do
            {
                TriangleSize += 1;
                TriangleNumber = 0;
                Factors = 0;
                for (int i = 1; i < TriangleSize; i++) { TriangleNumber += i; }
                for (int i = 1; i < Math.Sqrt(TriangleNumber); i++)
                {
                    if (TriangleNumber % i == 0) { Factors += 2; }
                }
            } while (Factors < 500);
            Console.WriteLine("A Triangle number is generated by adding natural numbers.");
            Console.WriteLine("i.e. The seventh triangle number: 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28");
            Console.Write("First Triangle number with more than 500 factors is " + TriangleNumber);
        }
        static void Problem_13()
        {
            string Problem13_Words = "Problem13_Numbers.txt";
            List<string> Numbers = System.IO.File.ReadAllLines(Problem13_Words).ToList();
            List<int> Digits = new List<int>(); int count = 0; char[] DigitChars;
            string result;
            BigInteger QuickResult = 0;
            do
            {
                DigitChars = Numbers[count].ToCharArray();
                if (count == 0) { for (int i = 0; i < DigitChars.Length; i++) { Digits.Add(int.Parse(DigitChars[i].ToString())); } }
                else
                { 
                        for (int i = 49; i > 0; i--) { Digits[i] += int.Parse(DigitChars[i].ToString()); if (Digits[i] >= 10 && i > 0) { Digits[i - 1]++; Digits[i] %= 10; } } }
                count++;
            } while (count < 100);
            result = string.Join("", Digits);
            foreach (string Number in Numbers) { QuickResult += BigInteger.Parse(Number); }
            Console.WriteLine("Incorrect result, not using BigInteger:" + result);
            Console.WriteLine("Quick result, using BigInteger: " + QuickResult);
            Console.ReadLine();
        }
        static void Problem_14()
        {
            long Collatz = 0;
            int CollatzChain = 0;
            int MaxCollatzChain = 0;
            int MaxCollatz = 0;
            for (int i = 1; i < 1000000; i++)
            {
                Collatz = i;
                CollatzChain = 0;
                do
                {
                    if (Collatz % 2 == 0) { Collatz /= 2; CollatzChain += 1; }
                    if (Collatz == 1) { break; }
                    if (Collatz % 2 == 1) { Collatz = ((Collatz * 3) + 1); CollatzChain += 1; }
                } while (Collatz != 1);
                if (CollatzChain > MaxCollatzChain) { MaxCollatzChain = CollatzChain; MaxCollatz = i; }
            }
            Console.WriteLine("The number under 1,000,000 that produces the largest Collatz chain is " + MaxCollatz);
            Console.WriteLine("Max Collatz chain for a number under 1,000,000 is " + MaxCollatzChain);
        }
        static void Problem_15()
        {
            Console.WriteLine("The answer to this requires the use of the Binomial Coefficient.");
            Console.WriteLine("This is mathematically written as 40C20");
            Console.WriteLine("This is calculated by 40! / ((40-20)! 20!) which is 137,846,528,820");
        }
        static void Problem_16()
        {
            BigInteger BigNumber = BigInteger.Pow(2, 1000);
            int Total = 0;
            do { Total += Convert.ToInt32(BigNumber % 10); BigNumber /= 10; } while (BigNumber > 0);
            Console.WriteLine("2^1000 is " + BigInteger.Pow(2, 1000));
            Console.WriteLine("The sum of all the digits that make up 2^1000 is " + Total);
        }
        static void Problem_17()
        {
            Console.WriteLine("The pattern used to solve this involves a certain amount of recursion.");
            Console.WriteLine("The numbers 1 - 9 written out add up to 36, the numbers 10 - 19 add up to 70");
            Console.WriteLine("We can use the 36 again to add up the digit values for 20 - 99, plus the ten prefixes");
            Console.WriteLine("This results in a total of 854 for the addition from 1 - 99");
            Console.WriteLine("Then we use what we have done here repeatedly to go from 100 - 999. And then add 11 for the 'one thousand'");
            Console.WriteLine("Giving the sum of all the letters used to write out the numbers 1 to 1000 as 21124");

        }
        static void Problem_18()
        {
            string file = "Problem18_Numbers.txt";
            string[] Numbers = System.IO.File.ReadAllLines(file);
            List<List<int>> Triangle = new List<List<int>>();
            for (int i = 0; i <= Numbers.Length -1; i++) { Triangle.Add(Array.ConvertAll(Numbers[i].Split(' '), int.Parse).ToList()); }
            for (int i = Triangle.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j <= Triangle[i].Count -2; j++)
                {
                    Triangle[i - 1][j] += Math.Max(Triangle[i][j], Triangle[i][j + 1]);
                }
            }
            Console.WriteLine("The path through the given triangle with the largest value is" + Triangle[0][0]);
        }
        static void Problem_19()
        {
            int Total = 0;
            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday) { Total++; }
                }
            }
            Console.WriteLine(Total);
        }
        static void Problem_20()
        {
            BigInteger Factorial = 1;
            char[] FactorialArray;
            int Total = 0;
            for (int i = 1; i <= 100; i++) { Factorial *= i; }
            FactorialArray = Factorial.ToString().ToCharArray();
            for (int i = 0; i <= FactorialArray.Length - 1; i++) { Total += int.Parse(FactorialArray[i].ToString()); }
            Console.WriteLine("The sum of the digits in 100! is " + Total);
        }
        static void Problem_21()
        {
            List<int> SumOfFactors = new List<int>();
            List<int> ListOfAmicablePairs = new List<int>();
            int Sum = 0; int AmicableSum = 0;
            int SumOfAmicablePairs = 0;
            for (int i = 1; i <= 10000; i++)
            {
                Sum = 0; AmicableSum = 0;
                for (int j = 1; j < Math.Sqrt(i); j++) { if (i % j == 0) { Sum += j; if ((j != 1) && (i / j != j)) { Sum += i / j; }; } }
                for (int j = 1; j < Math.Sqrt(Sum); j++) { if (Sum % j == 0) { AmicableSum += j;  if ((j != 1) && (Sum / j != j)) { AmicableSum += Sum / j; } } }
                if (AmicableSum == i && i != Sum) { SumOfAmicablePairs += i; }
            }
            Console.Clear();
            Console.WriteLine("An amicable pair is a pair of numbers where the sum of their divisors add up to each other.");
            Console.WriteLine("Example?");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Example: Divisors of 220 = 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, and 110. Sum is 284.");
                Console.WriteLine("Example: Divisors of 284 = 1, 2, 4, 71, and 142. Sum is 220.");
                Console.WriteLine("Example: These are an amicable pair.");
            }
            Console.WriteLine("The sum of all amicable pairs under 10,000 is " + SumOfAmicablePairs);
        }
        static void Problem_22()
        {
            string Problem_22_File = "Problem22_Names.txt";
            string NamesString = System.IO.File.ReadAllText(Problem_22_File);
            string[] NamesArray = NamesString.Split(',');
            Array.Sort(NamesArray);
            char[] NameChars;
            int NameTotal = 0;
            int Total = 0;
            for (int i = 0; i <= NamesArray.Length - 1; i++)
            {
                NameTotal = 0;
                NameChars = NamesArray[i].ToCharArray();
                for (int j = 0; j <= NameChars.Length - 1; j++) { NameTotal += AlphabeticalValue(NameChars[j]); }
                NameTotal *= (i + 1);
                Total += NameTotal;
            }
            Console.WriteLine("Sum of the alphabetical value of the names in the given text file is " + Total);
        }
        static void Problem_23()
        {
            List<int> AbundantNumbers = new List<int>();
            Boolean[] SumPossibilites = new bool[28123];
            int total = 0;
            int SumDivisors = 0;
            int TotalPoint = 0;
            for (int i = 0; i <= 28123; i++)
            {
                SumDivisors = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) { SumDivisors += j; if (j != 1 && (i / j != j)) { SumDivisors += (i / j); } }
                }
                if (SumDivisors > i) { AbundantNumbers.Add(i); }
            }
            for (int i = 0; i <= AbundantNumbers.Count - 1; i++)
            {
                for (int j = 0; j <= AbundantNumbers.Count - 1; j++)
                {
                    if ((AbundantNumbers[i] + AbundantNumbers[j]) < 28123) { SumPossibilites[(AbundantNumbers[i] + AbundantNumbers[j])] = true; }
                }
            }
            for (int i = TotalPoint; i < 28123; i++)
            {
                if (SumPossibilites[i] == false) { total += i; TotalPoint = i; }
            }
            Console.WriteLine("Sum of all positive integers that cannot be written as sum of two abundant numbers is " + total);
        }
        static void Problem_24()
        {
            // This works by reducing the range in which the millionth permutation is in
            // until that range reaches one number.
            int[] perm = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int N = 10;
            string permNum = "";
            int Remain = 999999;
            List<int> Numbers = new List<int>();
            for (int i = 0; i < N; i++) { Numbers.Add(i); }
            for (int i = 1; i < N; i++)
            {
                int j = Convert.ToInt32(Remain / Factorial(N - i));
                Remain %= Convert.ToInt32(Factorial(N - i));
                permNum += Numbers[j];
                Numbers.RemoveAt(j);
                if (Remain == 0) { break; }
            }
            for (int i = 0; i < Numbers.Count; i++) { permNum += Numbers[i]; }
            Console.WriteLine("The millionth entry in the lexicographic permutation is " + permNum);
        }
        static void Problem_25()
        {
            List<BigInteger> FibonacciNumbers = new List<BigInteger>();
            BigInteger FibNumber = 0;
            FibonacciNumbers.Add(1);
            FibonacciNumbers.Add(1);
            int Temp = 2;
            do
            {
                FibNumber = 0;
                FibNumber = FibonacciNumbers[Temp - 1] + FibonacciNumbers[Temp - 2];
                Temp += 1;
                FibonacciNumbers.Add(FibNumber);
            } while (FibNumber.ToString().Length < 1000);
            Console.WriteLine(FibonacciNumbers.Count + " is the index of the first Fibonacci number with over 1000 digits");
        }
        static void Problem_26()
        {
            int count = 1; int maxcount = 0; int nextremainder = 0;
            List<int> Remainder = new List<int>();
            bool endfound = false;
            for (int denominator = 2; denominator < 1000; denominator++)
            {
                count = 1; Remainder.Clear(); Remainder.Add(1); endfound = false;
                do
                {
                    nextremainder = (Remainder[count - 1] * 10) % denominator;
                    if (Remainder.Contains(nextremainder)) { Remainder.Add(nextremainder); count++; endfound = true; }
                    else { Remainder.Add(nextremainder); count++; }                  
                } while (endfound == false);
                if (count > maxcount) { maxcount = count; }
            }
            Console.WriteLine("The d < 1000 for which 1/d has the largest recurring cycle is " + maxcount);
        }
        static void Problem_27()
        {
            long result = 0;
            int first = 0; int second = 0;
            int highestcount = 0;
            int n = 0;
            int FunctionResult = 0;
            bool NonPrimeFound = false;
            for (int a = -1000; a < 1000; a++)
            {
                for (int b = -1000; b < 1000; b++)
                {
                    n = 0;
                    NonPrimeFound = false;
                    do
                    {
                        FunctionResult = ((n * n) + (a * n) + b);
                        if (FunctionResult > 0 && isPrime(FunctionResult) == false) { NonPrimeFound = true; }
                        if (FunctionResult < 0) { NonPrimeFound = true; }
                        if (FunctionResult >= 0 && NonPrimeFound == false) { n += 1; }
                    } while (NonPrimeFound == false);
                    if (n > highestcount) { highestcount = n; result = a * b; first = a; second = b; }
                }
            }
            Console.WriteLine("Product of a and b that create highest number of consecutive primes is " + result);
            Console.WriteLine("The function is n^2 + " + first + "*n + " + second);
        }
        static void Problem_28()
        {
            int total = 1;
            //Top right corner of ring has value n^2
            //Top left has value n^2 - (n - 1)
            //Bottom left has value n^2 - 2(n - 1)
            //Bottom right has value n^2 - 3(n - 1)
            //Sum for ring is 4n^2 - 6(n - 1)
            //Can use this to add up each ring for total.
            for (int i = 3; i <= 1001; i += 2) { total += (4 * i * i) - (6 * (i - 1)); }
            Console.WriteLine("Sum of all diagonals in a 1001 by 100 spiral are " + total);
        }
        static void Problem_29()
        {
            List<double> Terms = new List<double>();
            double Power = 0;
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    Power = Math.Pow(a, b);
                    if (Terms.Contains(Power) == false) { Terms.Add(Power); }
                }
            }
            Console.WriteLine(Terms.Count);
        }
        static void Problem_30()
        { 
            int FinalResult = 0;
            int a = 0;
            int Total = 0;
            int Temp = 0;
            for (int i = 2; i < 1000000; i ++)
            {
                Temp = 0; Total = 0; a = i;
                do
                {
                    Temp = a % 10;
                    Total += Temp * Temp * Temp * Temp * Temp;
                    a = a / 10;
                } while (a != 0);
                if (Total == i) { FinalResult += i; }
            }
            Console.WriteLine("Sum of all numbers that can be written as the sum of the fifth power of their digits is " + FinalResult);
        }
        static void Problem_31()
        {
            int total = 0;
            int Ways = 1;
            for (int i = 0; i <= 200; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    for (int k = 0; k <= 50; k++)
                    {
                        for (int l = 0; l <= 20; l++)
                        {
                            for (int m = 0; m <= 10; m++)
                            {
                                for (int n = 0; n <= 5; n++)
                                {
                                    for (int o = 0; o <= 2; o++)
                                    {                                       
                                        total = i + (2 * j) + (5 * k) + (10 * l) + (20 * m) + (50 * n) + (100 * o);
                                        if (total == 200) { Ways += 1; }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("£2 can be made " + Ways + " ways using any number of coins.");
        }
        static void Problem_32()
        {
            int total = 0;
            List<int> Pandigitals = new List<int>();
            for (int i = 0; i <= 10000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (isPandigital(j.ToString() + i.ToString() + (i / j).ToString()) == true && Pandigitals.Contains(i) == false) { total += i; Pandigitals.Add(i); }
                    }
                }
            }
            Console.WriteLine("Sum of all z such that x * y = z uses all digits 1 - 9 is " + total);
        }
        static void Problem_33()
        {
            int Answer = 0;
            int numer = 1; int denom = 1;
            for (int i = 10; i <= 100; i++)
            {
                for (int j = 10; j < i; j++)
                {
                    int n0 = j % 10; int n1 = j / 10;
                    int d0 = i % 10; int d1 = i / 10;
                    if (n1 == d0 && n0 * i == d1 * j || n0 == d1 && n1 * i == d0 * j) { numer *= j; denom *= i; }
                }
            }
            Answer = GCD(numer, denom);
            Console.WriteLine("The product of the fractions obtained by digit cancelling has denominator " + Answer);
        }
        static void Problem_34()
        {
            int[] Factorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int Factoriand;
            int TempTotal = 0;
            int Answer = 0;
            for (int i = 0; i <= 9999999; i++)
            {
                Factoriand = i; TempTotal = 0;
                do
                {
                    TempTotal += Convert.ToInt32(Factorial(Factoriand % 10));
                    Factoriand /= 10;
                } while (Factoriand > 0);
                if (TempTotal == i && i > 2) { Answer += i; }
            }
            Console.WriteLine("Sum of all numbers equal to the sum of the factorial of their digits is " + Answer);
        }
        static void Problem_35()
        {
            int TotalCircularPrimes = 0;
            string Prime;
            bool Circular;
            for (int i = 2; i <= 1000000; i++)
            {
                Circular = true;
                if (isPrime(i))
                {
                    Prime = i.ToString();
                    if (Prime.Length == 1) { TotalCircularPrimes += 1; continue; }
                    for (int j = 0; j < Prime.Length; j++)
                    {
                        if (isPrime(int.Parse(Prime.Substring(j) + Prime.Substring(0, j))) == false) { Circular = false; }
                    }
                    if (Circular) { TotalCircularPrimes += 1; }
                }
            }
            Console.WriteLine("There are " + TotalCircularPrimes + " circular primes under 1,000,000");
        }
        static void Problem_36()
        {
            int Answer = 0;
            int Dec; string DecReversed = "";
            char[] DecChars; char[] BinChars;
            string Bin; string BinReversed = "";
            for (int i = 0; i < 1000000; i++)
            {
                Dec = i; DecChars = Dec.ToString().ToCharArray(); DecReversed = "";
                for (int j = DecChars.Length - 1; j >= 0; j--) { DecReversed += DecChars[j]; }
                if (Dec == int.Parse(DecReversed))
                {
                    Bin = Convert.ToString(Dec, 2); BinReversed = "";
                    BinChars = Bin.ToCharArray();
                    for (int j = Bin.Length - 1; j >= 0; j--) { BinReversed += BinChars[j]; }
                    if (Bin == BinReversed) { Answer += i; }
                }
            }
            Console.WriteLine("The sum of all circular primes is " + Answer);
        }
        static void Problem_37()
        {
            int Count = 0; int Prime = 10;
            bool Truncatable = true;
            int Answer = 0;
            do
            {
                if (isPrime(Prime))
                {
                    for (int i = 1; i < Math.Floor(Math.Log10(Prime) + 1); i++)
                    {
                        Truncatable = true;
                        if (isPrime(Prime / Convert.ToInt32(Math.Pow(10, i))) == false) { Truncatable = false; break; }
                        if (isPrime(Prime % Convert.ToInt32(Math.Pow(10, i))) == false) { Truncatable = false; break; }
                    }
                    if (Truncatable) { Answer += Prime; Count += 1; }
                }
                Prime += 1;
            } while (Count < 11);
            Console.WriteLine("The sum of all truncatable primes is " + Answer);
        }
        static void Problem_38()
        {
            int Count = 1;
            string Concatenated = "";
            string LargestPandigital = "0";
            for (int i = 1; i < 100000000; i++)
            {
                Concatenated = ""; Count = 1;
                do
                {
                    Concatenated += (i * Count).ToString();
                    Count += 1;
                } while (Concatenated.Length < 9);
                if (Concatenated.Length == 9 && isPandigital(Concatenated)) { if (int.Parse(Concatenated) > int.Parse(LargestPandigital)) { LargestPandigital = Concatenated; } }
            }
            Console.WriteLine("The largest pandigital number made from a concatenated product is " + LargestPandigital);
        }
        static void Problem_39()
        {
            int MaxSolutions = 0; int Solutions; int Maxp = 0;
            List<string> AllSolutions = new List<string>();
            for (int i = 0; i <= 1000; i++)
            {
                Solutions = 0;
                for (int a = 0; a <= i; a++)
                {
                    for (int b = a; b <= i; b++)
                    {
                        for (int c = b; c <= i; c++)
                        {
                            if (a + b + c == i && (a * a) + (b * b) == (c * c)) { Solutions += 1; AllSolutions.Add(a.ToString() + b.ToString() + c.ToString()); }
                        }
                    }
                }
                if (Solutions > MaxSolutions) { MaxSolutions = Solutions; Maxp = i; }
            }
            Console.WriteLine("Right-angled Triangle with perimeter " + Maxp + " has the most solutions");
        }
        static void Problem_40()
        {
            int TotalDigits = 0;
            int[] nDigits = { 9, 99, 999, 9999, 99999, 999999 };
            List<int> NeededDigits = new List<int>();
            char[] DigitsToChar;
            string StringDigits = "";
            int Answer = 1;
            int Count = 1;
            do
            {
                NeededDigits.Add(Count);
                TotalDigits += Count.ToString().Length;
                Count++;
            } while (TotalDigits < 1000000);
            foreach (int Number  in NeededDigits) { StringDigits += Number.ToString(); }
            DigitsToChar = StringDigits.ToCharArray();
            for (int i = 0; i < nDigits.Length - 1; i++) { Answer *= int.Parse(DigitsToChar[nDigits[i]].ToString()); }
            Console.WriteLine(Answer);
        }
        static void Problem_41()
        {
            List<BigInteger> PermArray = new List<BigInteger>();
            List<BigInteger> Permutation = new List<BigInteger>();
            int BiggestPanPrime = 0;
            for (BigInteger i = 1; i < 9; i++)
            {
                PermArray.Add(i);
                Permutation = Permutations(PermArray.ToArray<BigInteger>());
                for (int j = 0; j <= Permutation.Count - 1; j++)
                {
                    if (isPrime(Convert.ToInt32(Permutation[j])) && Permutation[j] > BiggestPanPrime) { BiggestPanPrime = Convert.ToInt32(Permutation[j]); }
                }
            }
            Console.WriteLine("The largest number that is both pandigital and prime is " + BiggestPanPrime);
        }
        static void Problem_42()
        {
            // Go to text file properties and make it an added resource to use below method of reading
            string TextFileName = "Problem42_Words.txt";
            string[] Words = System.IO.File.ReadAllText(TextFileName).Split(',');
            char[] Letters;
            int AlphaValueSum = 0;
            int count = 0;
            foreach (string Word in Words)
            {
                AlphaValueSum = 0;
                Letters = Word.ToCharArray();
                foreach  (char Letter in Letters) { AlphaValueSum += AlphabeticalValue(Letter); }
                if (isTriangle(AlphaValueSum)) { count++; }
            }
            Console.WriteLine(count);
        }
        static void Problem_43()
        {
            List<BigInteger> Permutes = new List<BigInteger>();
            int[] Primes = { 2, 3, 5, 7, 11, 13, 17 };
            BigInteger[] PanDigits = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            bool SubstringDivisible = true;
            BigInteger Total = 0;
            char[] IntSplitTemp; string substring;
            Permutes = Permutations(PanDigits);
            foreach (BigInteger Permutation in Permutes)
            {
                IntSplitTemp = Permutation.ToString().ToCharArray(); SubstringDivisible = true;
                if (IntSplitTemp.Length == 9) { continue; }
                for (int i = 0; i <= Primes.Length - 1; i++)
                {
                    substring = IntSplitTemp[i + 1].ToString() + IntSplitTemp[i + 2].ToString() + IntSplitTemp[i + 3].ToString();
                    if (int.Parse(substring) % Primes[i] != 0) { SubstringDivisible = false; break; }
                }
                if (SubstringDivisible == true) { Total += Permutation; }
            }
            Console.WriteLine(Total);
        }
        static void Problem_44()
        {
            int PentaCount = 0;
            int Pentaj = 0; int result = 0;
            bool done = false;
            for (int i = 1; ; i++)
                {
                PentaCount = Convert.ToInt32(TriPentHexNumberConvert("Pent", i, 0));
                    for (int j = 1; j < i; j++)
                    {
                        Pentaj = Convert.ToInt32(TriPentHexNumberConvert("Pent", 0, j));
                        if (isPentagonal(PentaCount - Pentaj) && isPentagonal(PentaCount + Pentaj)) { result = PentaCount - Pentaj; done = true; break; }
                    }
                    if (done == true) { break; }
                }
                
            Console.WriteLine("The two pentagonal numbers whose difference and sum are pentagonal has difference " + result);
        }
        static void Problem_45()
        {
            BigInteger result = 0;
            int count = 0;
            bool found = false;
            List<BigInteger> TriNumbers = new List<BigInteger>();
            List<BigInteger> PentNumbers = new List<BigInteger>();
            List<BigInteger> HexNumbers = new List<BigInteger>();
            Console.WriteLine("This solution is correct, but takes over six minutes to run. Continue Anyway?");
            if (Console.ReadLine() != "yes") { return; }
            do
            {
                for (int i = count; i < count + 1000; i++)
                {
                    TriNumbers.Add(TriPentHexNumberConvert("Tri", i, 0));
                    PentNumbers.Add(TriPentHexNumberConvert("Pent", i, 0));
                    HexNumbers.Add(TriPentHexNumberConvert("Hex", i, 0));
                }
                count += 1000;
                for (int i = 0; i < TriNumbers.Count - 1; i++)
                {
                    if (TriNumbers[i] > 40755 && PentNumbers.Contains(TriNumbers[i]) && HexNumbers.Contains(TriNumbers[i])) { result = TriNumbers[i]; found = true; break; }
                }
            } while (found == false);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void Problem_46()
        {
            int OddComposite = 7;
            string OddCompMinusSquare = "";
            bool Solved = false;
            do
            {
                OddComposite += 2; if (isPrime(OddComposite)) { do { OddComposite += 2; } while (isPrime(OddComposite)); }
                for (int i = 1; i <= Math.Sqrt(OddComposite / 2); i++)
                {
                    OddCompMinusSquare = (OddComposite - 2 * Math.Pow(i, 2)).ToString();
                    if (isPrime(int.Parse(OddCompMinusSquare))) { break; }
                    if (i + 1 > Math.Sqrt(OddComposite / 2)) { Solved = true; }
                }
            } while (Solved == false);
            Console.WriteLine("The first odd composite number that cannot be written as the sum of a prime and");
            Console.WriteLine("a square number is " + OddComposite);
        }
        static void Problem_47()
        {
            List<List<int>> DistinctFactors = new List<List<int>>();
            int TestNumber = 1;
            bool Solved = false;
            do
            {
                TestNumber += 1;
                DistinctFactors.Add(new List<int>()); DistinctFactors[0] = PrimeFactors(TestNumber).Distinct<int>().ToList<int>();
                if (DistinctFactors[0].Count == 4)
                {
                    DistinctFactors.Add(new List<int>()); DistinctFactors[1] = PrimeFactors(TestNumber + 1).Distinct<int>().ToList<int>();
                    if (DistinctFactors[1].Count == 4)
                    {
                        DistinctFactors.Add(new List<int>()); DistinctFactors[2] = PrimeFactors(TestNumber + 2).Distinct<int>().ToList<int>();
                        if (DistinctFactors[2].Count == 4)
                        {
                            DistinctFactors.Add(new List<int>()); DistinctFactors[3] = PrimeFactors(TestNumber + 3).Distinct<int>().ToList<int>();
                            if (DistinctFactors[3].Count == 4) { Solved = true; }
                        }
                    }
                }
            } while (Solved == false);
            Console.WriteLine(TestNumber);
        }
        static void Problem_48()
        {
            List<int> Digits = new List<int>();
            List<int> iDigits = new List<int>();
            string Result = "";
            for (int i = 1; i <= 1000; i++ )
            {
                iDigits = XtotheX(i);
                while (Digits.Count < iDigits.Count) { Digits.Add(0); }
                for (int j = 0; j <= iDigits.Count -1; j++) { Digits[j] += iDigits[j]; }
                for (int j = 0; j <= Digits.Count -1; j++) { if (Digits[j] >= 10) { if (j < iDigits.Count - 1) { Digits[j + 1] += Digits[j] / 10; } else { Digits.Add(Digits[j] / 10); } Digits[j] %= 10; } }
            }
            for (int i = 9; i >= 0; i--) { Result += Digits[i].ToString(); }
            Console.WriteLine(Result);
        }
        static void Problem_49()
        {
            List<BigInteger> Permutes = new List<BigInteger>();
            List<BigInteger> iDigits = new List<BigInteger>();
            int Temp;
            string result = "";
            for (int i = 1000; i <= 9999; i++)
            {
                Temp = i;
                if (isPrime(Temp) == false || isPrime(Temp + 3330) == false || isPrime(Temp + 6660) == false) { continue; }
                do { iDigits.Add(Temp % 10); Temp /= 10; } while (Temp > 0);
                iDigits.Reverse();
                Permutes = Permutations(iDigits.ToArray<BigInteger>());
                if (Permutes.Contains(i) && Permutes.Contains(i + 3330) && Permutes.Contains(i + 6660)) { result = Temp.ToString() + (Temp + 3330).ToString() + (Temp + 6660).ToString(); }
            }
            Console.WriteLine(result);
        }
        static void Problem_50()
        {
            List<int> Primes = new List<int>();
            int result = 0, PrimesTotal = 0, count = 0;
            bool Done = false;
            Primes.Add(2); Primes.Add(3);
            do
            {
                count = 0;
                Primes.Add(FindNextPrime(Primes.Max()));
                do
                {
                    PrimesTotal = 0;
                    for (int i = count; i <= Primes.Count - 1; i++) { PrimesTotal += Primes[i]; }
                    count++;
                    if (PrimesTotal < result) { break; }
                if (PrimesTotal > 1000000) { Done = true; break; }
                else if (isPrime(PrimesTotal) && PrimesTotal > result) { result = PrimesTotal; }
                } while (count < Primes.Count - 1);
            } while (Done == false);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void Problem_51()
        {
            // Repeating digit has to be 0, 1, or 2. Otherwise can't get eight digit family.
            // Must have three repeating digits. Otherwise can't get eight digit family.
            List<int> Digits = new List<int>();
            int TestNumber = 56003, storage = 0, result = 0;
            do
            {
                Digits.Clear();
                TestNumber = FindNextPrime(TestNumber);
                storage = TestNumber; do { Digits.Add(storage % 10); storage /= 10; } while (storage > 0); Digits.Reverse();
                result = Problem_51_Family_Test(Digits);
            } while (result == 0);

            Console.WriteLine(result);
            Console.ReadKey();           
        }
        static void Problem_52()
        {
            int TestNumber = 0, result = 0;
            List<int> TestDigits = new List<int>(), TestMultipliedDigits = new List<int>();
            bool Found = false;
            for (int i = 125874; ; i++)
            {
                TestDigits.Clear(); TestMultipliedDigits.Clear();
                TestNumber = i; do { TestDigits.Add(TestNumber % 10); TestNumber /= 10; } while (TestNumber > 0);
                for (int j = 2; j <= 6; j++)
                {
                    TestMultipliedDigits.Clear();
                    TestNumber = i * j; do { TestMultipliedDigits.Add(TestNumber % 10); TestNumber /= 10; } while (TestNumber > 0);
                    if (ListEquality(TestDigits, TestMultipliedDigits) == false) { break; }
                    else if (j == 6) { Found = true; result = i; }
                }
                if (Found == true) { break; }
            }
            Console.WriteLine("The number that has the same digits for x, 2x, 3x, 4x, 5x, and 6x, is " + result);
        }
        static void Problem_53()
        {
            BigInteger Combinatorial = 0;
            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Combinatorial = Factorial(i) / (Factorial(j) * Factorial(i - j));
                    if (Combinatorial > 1000000) { result++; }
                }
            }
            Console.WriteLine("For n <= 100, nCr is over one million " + result + " times.");
            Console.ReadKey();
        }
        static void Problem_54()
        {
            string[] Hands = System.IO.File.ReadAllLines("Problem54_PokerHands.txt");
            List<string> PlayerOne_Hands = new List<string>();
            List<string> PlayerTwo_Hands = new List<string>();
            string[] PlayerOne_Hand = new string[5], PlayerTwo_Hand = new string[5], PlayerOne_OrderedHand = new string[5], PlayerTwo_OrderedHand = new string[5];
            string PlayerOne_Result = "", PlayerTwo_Result = "", RoundWinner = "";
            int count = 0;
            for (int i = 0; i <= Hands.Length - 1; i++) { PlayerOne_Hands.Add(Hands[i].Substring(0, 14)); PlayerTwo_Hands.Add(Hands[i].Substring(15)); }
            for (int i = 0; i <= PlayerOne_Hands.Count -1; i++)
            {
                PlayerOne_Hand = PlayerOne_Hands[i].Split(' '); PlayerTwo_Hand = PlayerTwo_Hands[i].Split(' ');
                Problem54_HandEvaluator(PlayerOne_Hand, out PlayerOne_Result, out PlayerOne_OrderedHand);
                Problem54_HandEvaluator(PlayerTwo_Hand, out PlayerTwo_Result, out PlayerTwo_OrderedHand);
                Problem54_RoundWinner(PlayerOne_Result, PlayerOne_OrderedHand, PlayerTwo_Result, PlayerTwo_OrderedHand, out RoundWinner);
                if (RoundWinner == "Player One") { count++; }
            }
            Console.WriteLine("Player One wins " + count + " times.");
        }
        static void Problem_55()
        {
            List<int> Lychrel = new List<int>();
            BigInteger storage = 0;
            BigInteger PalinTest = 0;
            for (int i = 10; i < 10000; i++)
            {
                storage = i;
                for (int j = 0; j < 50; j++)
                {
                    PalinTest = storage + Reversal(storage);
                    storage = PalinTest;
                    if (isPalindrome(PalinTest)) { break; }
                    else if (j == 49) { Lychrel.Add(i); }
                }
            }
            Console.WriteLine("There are " + Lychrel.Count + "Lyrechal numbers under 10,000");
        }
        static void Problem_56()
        {
            BigInteger Result = 0;
            BigInteger Power = 0;
            BigInteger PowerDigitSum = 0;
            for (int i = 0; i < 100; i++)
            {
               for (int j = 0; j < 100; j++)
                {
                    Power = (BigInteger)Math.Pow(i, j); PowerDigitSum = 0;
                    do { PowerDigitSum += Power % 10; Power /= 10; } while (Power > 0);
                    if (PowerDigitSum > Result) { Result = PowerDigitSum; }
                }
            }
            Console.WriteLine(Result);
        }
        static void Problem_57()
        {

        }
        static void Problem_60()
        {
            List<int> Primes = new List<int>();
            Primes.Add(2); Primes.Add(3); Primes.Add(5); Primes.Add(7);
            string Concat = "";
            bool result = true; int ResultSum = 0;
            do
            {
                result = true;
                Primes.Add(FindNextPrime(Primes[Primes.Count - 1]));
                for (int i = Primes.Count - 5; i < Primes.Count -1; i++)
                    {
                        Concat = Primes[i].ToString() + Primes[i + 1].ToString();
                        if (isPrime(int.Parse(Concat)) == false) { result = false; break; }
                        Concat = Primes[i + 1].ToString() + Primes[i].ToString();
                        if (isPrime(int.Parse(Concat)) == false) { result = false; break; }
                    }
            } while (result == false);
            ResultSum = Primes[Primes.Count - 4] + Primes[Primes.Count - 3] + Primes[Primes.Count - 2] + Primes[Primes.Count - 1] + Primes[Primes.Count];

        }
        




        static void Problem_66()
        {
            int D = 1, Greatestx = 0, GreatestD = 0;
            Decimal x = 0;
            do
            {
                do { D++; } while (Math.Sqrt(D) % 1 == 0);
                for (int y = 1; ; y++)
                {
                    if (D * (y*y) < 1) { break; }
                    x = Convert.ToDecimal(Math.Sqrt(1 + D* (y * y)));
                    if (x % 1 == 0) { if (x > Greatestx) { Greatestx = Convert.ToInt32(x); GreatestD = D; break; } break; }
                }

            } while (D <= 1000);
            Console.WriteLine("Greatest D <= 1000 is " + GreatestD);
            Console.ReadKey();
        }
    }
}