using System.Text.RegularExpressions;
using System.Drawing;

namespace laba3_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenochka\source\repos\laba3_3\laba3_3_2\Files";
            try
            {
                string[] data = Directory.GetFiles(path);
                ProcessDirectory.ProcessFiles(path, data);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Directory with path {path} can't be found");
            }
        }
    }
}