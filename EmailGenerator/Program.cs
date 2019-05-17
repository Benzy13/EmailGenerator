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
                char[] charRandomNumArray = new char[guidLength];
                string[,] strMatrix = new string[201, 4];

                // Generate random number character array
                for (var i = 0; i < guidLength; i++)
                {
                    int randomNumber = IntUtil.Random((int)'a', (int)'z' + 1);
                    charRandomNumArray[i] = Convert.ToChar(randomNumber);
                }
                //Compile a string matrix
                string recipient = new string(charRandomNumArray);
                string emailAddress = "Gesa" + IntUtil.Random(10, 100) + recipient + IntUtil.Random(10, 100) + "@PrimeLogic.co.za";
                strMatrix[j, 0] = emailAddress;
                strMatrix[j, 1] = recipient;
                strMatrix[j, 2] = recipient;
                strMatrix[j, 3] = "0000000000";

                Guid x = Guid.NewGuid();
                var xGuid = Convert.ToString(x);
                //compile lines in the text document
                strArray[0] = "Email Address\tFirst Name\tLast Name\tMobile Number\tGuid"; //Fist Line
                strArray[j] = strMatrix[j, 0] + "\t" + strMatrix[j, 1] + "\t" + strMatrix[j, 2] + "\t" + strMatrix[j, 3] + "\t" + xGuid; //Other Lines
            }
            File.WriteAllLines(@"C:\Users\Jean.PrimeLogic\Documents\Visual Studio 2015\TestFolder\GesaTestEmails.txt", strArray);
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
            //ReadFile.Read();
        }
    }
}
