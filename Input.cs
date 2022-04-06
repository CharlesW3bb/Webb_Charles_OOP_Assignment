using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_Charles
{
    class Input : Validate //(INHERITANCE) the input class inheirts from the validate class so inputs can be validated when taken.
    {


        string text = "nothing";
        string usersChoice;
        string[] returnInput = { "", "" };


        public string ManualOrFile()
        {
            string userInput = ValidateManualOrFile("Please enter eiter 'manual', or 'file: ");
            return (userInput);
        }

        public string[] GetInput()
        {
            usersChoice = ManualOrFile();

            if (usersChoice == "manual")
            {
                text = manualTextInput();

                returnInput[0] = text;
                returnInput[1] = usersChoice; // usersChoice of the two options is stored to be passed to the Analyse class so it can work out if it needs to calcualte max length of values for option two.

            }

            else if (usersChoice == "file")
            {
                text = fileTextInput();

                returnInput[0] = text;
                returnInput[1] = usersChoice;


            }

            return (returnInput);

        }

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {

            text = ExceptionCheck("Please enter the text you wish to analyse");
            return text;

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()//string fileName
        {
            text = IsDirectoryValid();
            return text;
        }




    }
}
