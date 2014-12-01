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
        int value;
        string input = null;

        public void createFile()
        {
            try
            {
                using (StreamWriter writer = File.CreateText("numbers.txt"))
                {
                    for (int i = 1; i <= 10; i++)
                        writer.WriteLine(i);
                    // Insert a new line.
                    writer.Write(writer.NewLine);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                    if (value > large)//comparing each time entered number with large one
                    {
                        large = value;
                    }
                    if (value < smallest)//comparing each time entered number with smallest one
                    {
                        smallest = value;
                    }
                }
            }
        }

        public int getLargest()
        {
            return large;
        }
    }
}
