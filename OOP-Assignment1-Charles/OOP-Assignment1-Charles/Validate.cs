using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment1_Charles
{
    class Validate
    {
        private string userInput;//data abstarction. User input definiatly should not be accesable to other classes.


        public string ExceptionCheck(string message) //checks if size of input causes unwanted/unexpected behaviour such as run time errors.
                                                     //This method is used on manual inputs to see if any exceptions are made.
        {

            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                    return (userInput);
                }
                catch
                {
                    Console.WriteLine("Incorrect input, please try again");
                }

            }

        }

        public bool ExceptionCheck(string message, string file)
        { //METHOD OVERLOADING is being used here to increace code readability.
            //This method is used for files to check for any exceptions

            return (false);
        }

        public string IsDirectoryValid()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the file directory you wish to analyse");
                    string inputDirectory = Console.ReadLine();
                    string text = System.IO.File.ReadAllText(inputDirectory);
                    return text;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{ e.Message} \n\nplease try again: \n");

                }
            }

        }
        public string ValidateManualOrFile(string message)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine($"{message}"); // message is a passed parametre. It is used so that this one method can be used
                    //for multiple diffrent purposes, meaning new validation methods dont need to be created.
                    userInput = Console.ReadLine(); //If the user enters an extreme value that causes an error, it will be handled,
                                                    //the return wont be run until a valid input is given.

                }
                catch
                {
                    Console.WriteLine("You entered incorrect input"); //gives feedback to the user that their input was invalid. 
                }

                if (userInput.ToLower() == "manual" || userInput.ToLower() == "file")
                {
                    return userInput;
                }
            }

        }





    }
}
