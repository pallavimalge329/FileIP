using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIP
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\myFile.txt", FileMode.Open, FileAccess.Read);

            //StreamReader class is inherited from an abstract class, TextReader. It is used to read a series of characters 
            StreamReader sr = new StreamReader(fs);

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // read till the end of file is reached
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }


            // close all the resources
            sr.Close();
            fs.Close();

            /*    Console.WriteLine("Working with File IO Operations!");
                FileStream fs = new FileStream("F:\\student.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter some contents ");
                string str = Console.ReadLine();

                sw.Write(str);
                sw.Flush();

                sw.Close();
                fs.Close();  */
            Console.ReadKey();

        }
    }
}
