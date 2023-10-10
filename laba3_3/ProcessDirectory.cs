using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba3_3
{
    public static class ProcessDirectory
    {
        public static (long, int) ProcessFiles(string path, string[] fileNames)
        {
            long result = 0;
            int count = 0;

            foreach (var fileName in fileNames)
            {
                try
                {
                    string[] data = File.ReadAllLines(path + fileName);
                    ProcessData(path, data, ref result, ref count, fileName);
                }
                catch (FileNotFoundException)
                {
                    File.AppendAllText(path + "no_data.txt", fileName + "\n");
                }

            }
            return (result, count);
        }
        public static void ProcessData(string path, string[] data, ref long result, ref int count, string fileName)
        {
            try
            {
                int firstNumber = Convert.ToInt32(data[0]);
                int secondNumber = Convert.ToInt32(data[1]);
                int product;
                checked
                {
                    product = firstNumber * secondNumber;
                }
                result += product;
                count++;
            }
            catch (IndexOutOfRangeException)
            {
                File.AppendAllText(path + "bad_data.txt", fileName + "\n");
            }
            catch (FormatException)
            {
                File.AppendAllText(path + "bad_data.txt", fileName + "\n");

            }
            catch (OverflowException)
            {
                File.AppendAllText(path + "overflow.txt", fileName + "\n");
            }
        }
    }
}
