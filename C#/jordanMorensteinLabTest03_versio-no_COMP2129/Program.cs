using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jordanMorensteinLabTest03_versio_no_COMP2129
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers labtest = new Numbers();

            labtest.createFile();

            labtest.readFile();

            Console.WriteLine("The largest number is " + labtest.getLargest());
            Console.WriteLine("The smallest number is " + labtest.getSmallest());

            Console.ReadLine();
        }

        

        
    }
}
