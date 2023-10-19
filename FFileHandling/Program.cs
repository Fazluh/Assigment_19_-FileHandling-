using System;
using System.Collections.Generic;
using System.IO;

namespace FFileHandling
{
    public class Program
    {
        static void Main(string[] args)

        {
            //WritingFile();

            //  ReadingFile();

            bool ans= File.Exists(@"D:\\filehandling\\file1.txt");
            Console.WriteLine(ans);
            Console.ReadLine();
        }

        private static void ReadingFile()
        {
            FileStream fs = new FileStream(@"D:\\filehandling\\file1.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

           string data= sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();
        }

        private static void WritingFile()
        {
            try
            {
                // File.Create(@"D:\filehandling\file1.txt");
                FileStream fs = new FileStream(@"D:\\filehandling\\file1.txt", FileMode.Open, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("Hello this is Demo 1");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
