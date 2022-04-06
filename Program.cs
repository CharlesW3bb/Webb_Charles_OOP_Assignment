//new
//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_Charles
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            //CHalres
            List<int> parameters = new List<int>();
            string[] text;

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Input input = new Input();
            text = input.GetInput();


            //Create an 'Analyse' object

            Analyse analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            List<int> results = new List<int>();
            results = analyse.analyseText(text);


            //Report the results of the analysis
            Report report = new Report();
            report.ReportAnalysis(results);
            report.ReportFrequency(text[0].ToString());

            //TO ADD: Get the frequency of individual letters? THIS IS COMPLETED IN ANALYSIS AND OUTPUTED IN REPORT


        }



    }
}
