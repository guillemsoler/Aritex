using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritex
{
    class Program
    {
        static ArrayList numbers = new ArrayList();
        static void Main(string[] args)
        {
            ReadFile();
            ShowIntervals();
        }

        private static void ReadFile()
        {
            int counter = 0;
            string line;
            try
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\code\input.txt");
                while ((line = file.ReadLine()) != null)
                {
                    numbers.Add(line);
                    counter++;
                }

                file.Close();
            }
            catch
            {
                Console.WriteLine("File doesn't exist");
                System.Console.ReadLine();
            }
            // Suspend the screen.  
            System.Console.ReadLine();
        }
        private static void ShowIntervals()
        {
            
            int[] numbersInt = (int[])numbers.ToArray(typeof(int[]));
            int first = numbersInt[0];
            int last = numbersInt[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbersInt[i] == last + 1)
                {
                    last = numbersInt[i];
                }
                else
                {
                    //Show interval
                    Console.WriteLine("["+first);
                    if (first != last)
                    {
                        Console.WriteLine(".."+last+"]");
                    }
                }
            }
        }
    }
}
