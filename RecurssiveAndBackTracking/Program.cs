using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RecurssiveAndBackTracking
{
    internal class Program
    {
        //static int nthFibonnaciSeries(int n)
        //{
        //    if(n == 0) return 0;
        //    if(n == 1) return 1;
        //    int recurssiveCall = nthFibonnaciSeries(n - 1) + nthFibonnaciSeries(n - 2);
        //    int smallCalc = recurssiveCall;
        //    return smallCalc;
        //}
        //static int palindrome(string s, int start, int end) {
        //    if (start>=end)
        //    {
        //        return 1;
        //    }
        //    if (s[start] != s[end])
        //    {
        //        return 0;
        //    }
        //    return palindrome(s, start + 1, end - 1);
        //}
        
        static void Main(String[] args)
        {
            //Fibonacci Series
            /* Console.WriteLine("Enter the Nth of the Fibonnaci Series");
             int number = int.Parse(Console.ReadLine());
             int result = nthFibonnaciSeries(number);
             Console.WriteLine(result);
             Console.ReadKey();
            */
            //Palindrome
            //Console.WriteLine("Enter the String to check if a Palindrome or not");
            //string S = Console.ReadLine();
            //int n=S.Length-1;
            //return palindrome(S, 0, n);
            int n = int.Parse(Console.ReadLine());
            //string[] s = new string[10];
            string[] s= { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            PrintNumInLetters printNumInLetters = new PrintNumInLetters();
            printNumInLetters.printNum(n, s);
            Console.ReadKey();



        }
    }
}
