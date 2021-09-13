using System;

namespace CSharpProject
{ 
    class Assignment4_StringArray
    {
        static void Main(string[] args)
        {

            String[] word1 = new string[2];
            String[] word2 = new string[2];

            String concatWord1 = "", concatWord2 = "";

            Console.WriteLine("Enter the first string array values");

            for (int i = 0; i < word1.Length; i++)
            {
                word1[i] = Console.ReadLine();


            }

            foreach (String word in word1)
            {

                concatWord1 += word;
            }

            Console.WriteLine("Enter the second string array values");

            for (int i = 0; i < word2.Length; i++)
            {
                word2[i] = Console.ReadLine();

            }

            foreach (String word in word2)
            {

                concatWord2 += word;
            }


            if (concatWord1.Equals(concatWord2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("'False");

            }



        }
    }
}
