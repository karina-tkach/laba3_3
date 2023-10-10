using System.IO;
using System;
using System.Collections.Generic;

namespace laba3_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //10 15 25 no file
            //12 17 19 28 bad data
            //14 29 overflow
            //27 blank
            //10 ok

            //or make in bin
           // Directory.GetCurrentDirectory();
            string path = @"C:\Users\Lenochka\source\repos\laba3_3\Files\";
            string[] fileNames = {
                "10.txt", "11.txt", "12.txt",
                "13.txt", "14.txt", "15.txt",
                "16.txt", "17.txt", "18.txt",
                "19.txt", "20.txt", "21.txt",
                "22.txt", "23.txt", "24.txt",
                "25.txt", "26.txt", "27.txt",
                "28.txt", "29.txt"};
            try
            {
                File.Delete(path + "no_data.txt");
                File.Delete(path + "bad_data.txt");
                File.Delete(path + "overflow.txt");
                Directory.GetFiles(path); 
                var result = ProcessDirectory.ProcessFiles(path, fileNames);
                long avg = result.Item1/result.Item2;
                Console.WriteLine(avg);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Directory with path {path} can't be found");
            }
            catch (DivideByZeroException)
            { 
                Console.WriteLine("All files are inappropriate, so average can't be determined");
            }
        }
    }
}