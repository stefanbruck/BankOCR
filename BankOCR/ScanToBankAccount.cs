using System.Collections.Generic;
using System.Linq;

namespace BankOCR
{
    public class ScanToBankAccount
    {
        public int Convert(IEnumerable<string> input)
        {
            //TODO: 1 rename 'x': CTRL R + R
            var x = new List<string>();

            // TODO: 2 Extract method Ctrl + R, CTRL + m 
            // TODO: 3 once you have extracted a method, extract a class: Ctrl + Shift + R -->  extract class
            for (int j = 0; j < 9; j++)
                x.Add(input.First().Substring(j*3, 3) + input.Skip(1).First().Substring(j*3, 3) + input.Skip(2).First().Substring(j*3, 3));


            // TODO: 4 extract another method / class: parse single digits
            var y = "";
            foreach (var a in x)
            {
                if (a == "     |  |") y += "1";
                if (a == " _  _||_ ") y += "2";
                if (a == " _  _| _|") y += "3";
                if (a == "   |_|  |") y += "4";
                if (a == " _ |_  _|") y += "5";
                if (a == " _ |_ |_|") y += "6";
                if (a == " _   |  |") y += "7";
                if (a == " _ |_||_|") y += "8";
                if (a == " _ |_| _|") y += "9";
                if (a == " _ | ||_|") y += "0";
            }

            return int.Parse(y);
        }
    }
}
