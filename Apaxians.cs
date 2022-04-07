using System;

namespace Apaxians
{
    class Apaxians
    {
        static void Main(string[] args)
        {
            //Take console input for the word
            string longname = Console.ReadLine();

            //Take the first character of the input word as a string
            string shortname = "" + longname[0];

            //Checks every letter in the input to see if letters are matching in a row
            for (int i = 1; i < longname.Length; i++)
            {
                //If letters match then continue the loop to the next letter
                if(longname[i] == longname[i - 1])
                {
                    continue;
                }

                //If they do not match then add the letter to the new string
                shortname += longname[i];
            }

            //Write the final string to the console
            Console.WriteLine(shortname);
        }
    }
}
