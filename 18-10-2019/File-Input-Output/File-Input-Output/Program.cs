using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string rootPath = @"C:\Users\C LOKESH\Desktop\File IO";

            string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.AllDirectories);
            foreach(string i in dirs)
            {
                //"To get All folders inside Folder"
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------------------");

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach (string i in files)
            {
                //"To get All files in folders and sub folders : "
                //Console.WriteLine(i);

                //To get only file names
                //Console.WriteLine(Path.GetFileName(i));

                //To get file name without extension
                Console.WriteLine(Path.GetFileNameWithoutExtension(i));
            }*/

            //Console.WriteLine("--------------------------------------------------");
            // creating new text file
            //FileStream f = new FileStream(@"C:\Users\C LOKESH\Desktop\File IO\Test.txt", FileMode.Create);


            // adding info into file
            /*string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";
            File.AppendAllLines(@"C:\Users\C LOKESH\Desktop\File IO\Test.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
            */

            // Adding string into file
            //File.AppendAllText(@"C:\Users\C LOKESH\Desktop\File IO\Test.txt", "This is File testing");

            // overwrite the existing file
            //File.WriteAllText(@"C:\Users\C LOKESH\Desktop\File IO\Test.txt", "OverRidden text");

            //Replacing the content in one file to another file
            //File.Replace(@"C:\Users\C LOKESH\Desktop\File IO\zip_10MB\file-sample_1MB.doc", @"C:\Users\C LOKESH\Desktop\File IO\Test.docx", @"C:\Users\C LOKESH\Desktop\File IO\Backup.txt");


            //ReadBytes into file
            //FileStream f = new FileStream(@"C:\Users\C LOKESH\Desktop\File IO\zip_10MB\file_example_ODS_5000.ods", FileMode.Open,FileAccess.Read);

            //Encript the file
            //File.Encrypt(@"C:\Users\C LOKESH\Desktop\File IO\cdz.cap.txt");

            //Decrypt
            //File.Decrypt(@"C:\Users\C LOKESH\Desktop\File IO\cdz.cap.txt");


            string rootPath = @"C:\Users\C LOKESH\Desktop\File IO";
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);
            foreach (string i in files)
            {
                //"To get All files in folders and sub folders : "
                Console.WriteLine(i);

                //To get only file names
                //Console.WriteLine(Path.GetFileName(i));

                //To get file name without extension
                //Console.WriteLine(Path.GetFileNameWithoutExtension(i));

            }

            Console.WriteLine(files.Length);


            Console.ReadKey();
        }
    }
}
