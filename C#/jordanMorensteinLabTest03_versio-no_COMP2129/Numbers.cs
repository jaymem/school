using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jordanMorensteinLabTest03_versio_no_COMP2129
{
    class Numbers
    {
        private int large;
        private int smallest;
        private int value;
        private string input = null;

        public void createFile()
        {
            try
            {
                using (StreamWriter writer = File.CreateText("numbers.txt"))
                {
                    for (int i = 1; i <= 10; i++)
                        writer.WriteLine(i * 43);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!: \n " + e.Message);
            }
            Console.WriteLine("Created file press enter...");
            Console.ReadLine();
        }

        public void readFile()
        {
            using (StreamReader sr = File.OpenText("numbers.txt"))
            {
                while ((input = sr.ReadLine()) != null)
                {
                    int.TryParse(input, out value);
                    determineLargest(value);
                }
            }
        }

        public void determineLargest(int number)
        {
            if (number > large) large = number;
            if (number < smallest) smallest = number;
        }

        public int getLargest()
        {
            return large;
        }

        public int getSmallest()
        {
            return smallest;
        }
    }
}
