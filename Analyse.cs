using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_Charles
{
    class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        List<string> vowel = new List<string>();

        public void WordFrequency(string text)
        {

            int[] value = new int[(int)char.MaxValue];

            foreach (char t in text)
            {
                value[(int)t]++;
            }

            // Outputs all letters and their respective frequecncies
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (value[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine($"Letter: {(char)i}  Frequency: {value[i]}");
                }

            }


        }

        public List<int> analyseText(string[] input)
        {
            string toAnalyse = input[0].ToString(); // toAnalyse stores the users inputted text
            string fullStop = ".";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; //This would preferably be tuple, however this causes indexing issues so a normal aray has to be usedl
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z' };
            string[] alphabet = {"a", "b", "c", "d", "e", "f", //String because c# doesnt operate required functions of char elements
                "g", "h", "i", "j", "k", "l", "m", "n", "o",
                "p", "q", "r", "s" , "t", "u", "v", "w", "x", "w", "z"};

            /*string[] alphabetHigher = alphabetLower;
            alphabetHigher = Array.ConvertAll(alphabetHigher, d => d.ToLower());*/


            int totalSentances = 0; // A list could preferably be used here to save time. Although variables
            int totalCharacters = 0; // are more readable from first glance and increase the readibility of the program.
            int totalVowels = 0;     // For example, if items[0] was used in a instuction it would be unclear what its purpose is,
            int totalconsonants = 0;     // For example, if items[0] was used in a instuction it would be unclear what its purpose is,
            int totalUpper = 0;       // and perhaps cause some confusion
            int totalLower = 0;


            //List of integers to hold the first five measurements:
            //1. Number of sentences



            foreach (var item in toAnalyse)
            {

                if (item.ToString() == fullStop)
                {
                    totalSentances++;// When a full stop is found. The sentacne count increments by one.
                }

            }


            //2. Number of vowels




            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < toAnalyse.Length; j++)
                {
                    if (vowels[i] == toAnalyse[j])
                    {
                        totalVowels++;
                    }
                }
            }




            //3. Number of consonants

            for (int i = 0; i < consonants.Length; i++)
            {
                for (int j = 0; j < toAnalyse.Length; j++)
                {
                    if (consonants[i] == toAnalyse[j])
                    {
                        totalconsonants++;
                    }
                }
            }


            //4. Number of upper case letters

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < toAnalyse.Length; j++)
                {
                    //Console.WriteLine($"{alphabet[i].ToUpper()} {toAnalyse[j].ToString()}");
                    if (alphabet[i].ToUpper() == toAnalyse[j].ToString())
                    {

                        totalUpper++;
                    }
                }
            }

            //5. Number of lower case letters


            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < toAnalyse.Length; j++)
                {
                    //Console.WriteLine($"{alphabet[i].ToUpper()} {toAnalyse[j].ToString()}");
                    if (alphabet[i].ToLower() == toAnalyse[j].ToString())
                    {

                        totalLower++;
                    }
                }
            }

            //Option 2 long words
            string[] indivualWords = { };
            indivualWords = toAnalyse.Split(' ');
            List<string> largeWords = new List<string>();

            if (toAnalyse == "file")
            {
                foreach (string item in indivualWords)
                {
                    if (item.Length >= 7)
                    {
                        largeWords.Add(item);
                    }
                }
                try
                {
                    System.IO.File.WriteAllLines("Longwords.txt", largeWords.ToArray());
                }
                catch
                {
                    Console.WriteLine("Sorry, we couldnt write your long words to a file ");
                }

            }



            List<int> values = new List<int>();
            values.Add(totalSentances);
            values.Add(totalVowels);
            values.Add(totalconsonants);
            values.Add(totalUpper);
            values.Add(totalLower);
            //Initialise all the values in the list to '0'
            /* for (int i = 0; i < 5; i++) 
             {
                 values.Add(0);
             }

             values[0] = totalSentances;
             values[1] = totalVowels;
             values[2] = totalconsonants;
             values[3] = totalUpper;
             values[4] = totalLower;
             */
            return values;


        }


    }


}
