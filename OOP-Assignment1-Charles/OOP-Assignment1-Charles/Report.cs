using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_Charles
{
    class Report
    {
        Analyse analyse = new Analyse();
        public void ReportAnalysis(List<int> results)
        {


            foreach (var item in results)
            {
                Console.WriteLine(item);
            }




        }

        public void ReportFrequency(string text)
        {
            analyse.WordFrequency(text);
        }





        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
}
