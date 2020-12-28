using System;

namespace Horspool_s_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm algoritmi = new Algorithm();

            long foundIndex1 = algoritmi.Horspool("lorem ipsum is simply dummy text of the printing and typesetting industry", "industry");
            long foundIndex2 = algoritmi.Horspool("lorem ipsum is simply dummy text of the printing and typesetting industry", "dummy");
            long foundIndex3 = algoritmi.Horspool("lorem ipsum is simply dummy text of the printing and typesetting industry", "simply");
            long foundIndex4 = algoritmi.Horspool("lorem ipsum is simply dummy text of the printing and typesetting industry", "ply");
            long foundIndex5 = algoritmi.Horspool("lorem ipsum is simply dummy text of the printing and typesetting industry", "typesetting");

            Console.WriteLine("Patterni i pare eshte bere match ne indeksin " + foundIndex1 + Environment.NewLine 
                + "Patterni i dyte eshte bere match ne indeksin " + foundIndex2 + Environment.NewLine
                + "Patterni i trete eshte bere match ne indeksin " + foundIndex3 + Environment.NewLine
                + "Patterni i katert eshte bere match ne indeksin " + foundIndex4 + Environment.NewLine
                +"Patterni i peste eshte bere match ne indeksin " + foundIndex5 + Environment.NewLine);
        }
    }
}
