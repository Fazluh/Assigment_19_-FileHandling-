using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace FFileHandling
{
    public class assigment_19
    {
        static void Main(string[] args)
        {
            string str;
            

            do {
                Console.WriteLine("Menu \n");
                Console.WriteLine("1.Create and Write Person Data\n2.Append new Data Into File\n3.Read the data from file\n4.Exit");
                int ch;
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                        CreateAndWritePersonData();
                        break;
                    case 2:

                        AppendNew();
                        break;
                    case 3:

                        ReadFile();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you Want to Continue : ");
                str= Console.ReadLine();
            } while(str == "yes");
            // CreateAndWritePersonData();
            //AppendNew();
            //  ReadFile();

            Console.ReadLine();
        }

        private static void ReadFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\\Assigment_19\\person.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string prsndata = sr.ReadToEnd();
                Console.WriteLine($"Person Data ={prsndata}");
                sr.Close();
                sr.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static void AppendNew()
        {
            try
            {
                Console.WriteLine("Enter Name");
                string namestr = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string addstr = Console.ReadLine();
                Console.WriteLine("Enter City");
                string citystr = Console.ReadLine();
                Console.WriteLine("Enter Country");
                string cntstr = Console.ReadLine();

                FileStream fs = new FileStream(@"D:\\Assigment_19\\person.txt", FileMode.Append,FileAccess.Write);
                StreamWriter st = new StreamWriter(fs);
                

                st.WriteLine("Name = " + namestr);
                st.WriteLine("Address = " + addstr);
                st.WriteLine("City = " + citystr);
                st.WriteLine("Country = " + cntstr);

                st.Flush();
                st.Close();
                st.Dispose();
                fs.Close();
                fs.Dispose();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CreateAndWritePersonData()
        {
            try
            {

                Console.WriteLine("Enter Name");
                string namestr = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string addstr = Console.ReadLine();
                Console.WriteLine("Enter City");
                string citystr = Console.ReadLine();
                Console.WriteLine("Enter Country");
                string cntstr = Console.ReadLine();
                Directory.CreateDirectory(@"D:\\Assigment_19");
                FileStream fs = new FileStream(@"D:\\Assigment_19\\person.txt", FileMode.CreateNew, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine("Name = " + namestr);
                sr.WriteLine("Address = " + addstr);
                sr.WriteLine("City : " + citystr);
                sr.WriteLine("Country : " + cntstr);
                Console.WriteLine("Data Entered into file");
                sr.Flush();
                sr.Close();
                sr.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
