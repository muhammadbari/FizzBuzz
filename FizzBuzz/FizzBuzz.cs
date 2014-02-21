using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IFizzBuzz
    {
        string GetOutput(int dividend);
        string GetOutputString(int start, int end);
        bool Contains3(int number);
    }

    public class FizzBuzz1 : IFizzBuzz
    {
        public string GetOutput(int dividend)
        {
            if (dividend % 15 == 0)
            { return "fizzbuzz"; }
            if (dividend % 5 == 0)
            { return "buzz"; }
            if (dividend % 3 == 0)
            { return "fizz"; }
            return dividend.ToString();
        }

        public string GetOutputString(int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += GetOutput(i) + " ";
            }
            return output.Trim();
        }

        public bool Contains3(int number) { return false; }
    }

    public class FizzBuzz2 : IFizzBuzz
    {
        public string GetOutput(int dividend)
        {
            if (this.Contains3(dividend))
            { return "lucky"; }
            if (dividend % 15 == 0)
            { return "fizzbuzz"; }
            if (dividend % 5 == 0)
            { return "buzz"; }
            if (dividend % 3 == 0)
            { return "fizz"; }
            return dividend.ToString();
        }

        public string GetOutputString(int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += GetOutput(i) + " ";
            }
            return output.Trim();
        }

        //Performing integer operation in this function
        //This is much better than string operations, in terms of performance
        //And native to every platform
        public bool Contains3(int number)
        {
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                if (digit == 3)
                    return true;
                number = (number - digit) / 10;
            }
            return false;
        }
    }

    public class FizzBuzz3 : FizzBuzz2, IFizzBuzz
    {
        private int _fizzCount { get; set; }
        private int _buzzCount { get; set; }
        private int _fizzbuzzCount { get; set; }
        private int _luckyCount { get; set; }
        private int _integerCount { get; set; }

        public string GetOutput(int dividend)
        {
            if (this.Contains3(dividend))
            { _luckyCount++; return "lucky"; }
            if (dividend % 15 == 0)
            { _fizzbuzzCount++; return "fizzbuzz"; }
            if (dividend % 5 == 0)
            { _buzzCount++; return "buzz"; }
            if (dividend % 3 == 0)
            { _fizzCount++; return "fizz"; }
            _integerCount++;
            return dividend.ToString();
        }

        public string GetOutputString(int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += GetOutput(i) + " ";
            }
            output = output.Trim();
            output += "\nfizz: " + this._fizzCount.ToString();
            output += "\nbuzz: " + this._buzzCount.ToString();
            output += "\nfizzbuzz: " + this._fizzbuzzCount.ToString();
            output += "\nlucky: " + this._luckyCount.ToString();
            output += "\ninteger: " + this._integerCount.ToString();
            return output.Trim();
        }
    }
}
