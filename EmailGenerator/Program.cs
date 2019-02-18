using System;
using System.IO;

namespace EmailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[201];

            for (var j = 1; j < 201; j++)
            {
                int guidLength = 5;
                int[] numArray = new int[guidLength];
                char[] charArray = new char[guidLength];
                string[,] strMatrix = new string[201, 4];

                for (var i = 0; i < guidLength; i++)
                {
                    int randomNumber = IntUtil.Random((int)'a', (int)'z' + 1);
                    numArray[i] = randomNumber;
                    char newChar = Convert.ToChar(numArray[i]);
                    charArray[i] = newChar;
                }

                string recipient = new string(charArray);

                //compile a line in the text document
                string emailAddress = "Gesa" + IntUtil.Random(10, 100) + recipient + IntUtil.Random(10, 100) + "@PrimeLogic.co.za";
                strMatrix[j, 0] = emailAddress;
                strMatrix[j, 1] = recipient;
                strMatrix[j, 2] = recipient;
                strMatrix[j, 3] = "0000000000";

                Guid x = Guid.NewGuid();
                var xGuid = Convert.ToString(x);

                strArray[0] = "Email Address\tFirst Name\tLast Name\tMobile Number\tGuid";
                strArray[j] = strMatrix[j, 0] + "\t" + strMatrix[j, 1] + "\t" + strMatrix[j, 2] + "\t" + strMatrix[j, 3] + "\t" + xGuid;
            }
            File.WriteAllLines(@"C:\Users\Jean.PrimeLogic\Documents\Visual Studio 2015\TestFolder\GesaTestEmails.txt", strArray);

            //ReadFile.Read();
        }
    }
}
