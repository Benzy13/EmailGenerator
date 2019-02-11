using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[100];
            int guidLength = 5;
            for (var j = 0; j < 100; j++)
            {
                int[] numArray = new int[guidLength];
                char[] charArray = new char[guidLength];

                for (var i = 0; i < guidLength; i++)
                {
                    int randomNumber = IntUtil.Random((int)'a', (int)'z' + 1);
                    numArray[i] = randomNumber;
                    char newChar = Convert.ToChar(numArray[i]);
                    charArray[i] = newChar;
                }

                string recipient = new string(charArray);

                var random = new Random();
              //  string emailAddress = "Gesa" + IntUtil.Random(10, 100) + recipient + IntUtil.Random(10, 100) + "@PrimeLogic.co.za";
                string emailAddress = "Gesa" + random.Next(10,100) + recipient + random.Next(10, 100) + "@PrimeLogic.co.za";
                lines[j] = emailAddress;
                System.IO.File.WriteAllLines(@"C:\Users\Jean.PrimeLogic\Documents\Visual Studio 2015\TestFolder\WriteLines.txt", lines);
            }
        }
    }
}
