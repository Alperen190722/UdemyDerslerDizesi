using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO.FileIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool kontrol = FileExists("c:\\udemy\\merhaba.txt");
            //if (kontrol)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır.");
            //}
            //else 
            //{
            //    FileCreate("c:\\udemy\\merhaba.txt");
            //}

            string metinDegeri = FileReadAllText("c:\\udemy\\merhaba.txt");
            Console.WriteLine(metinDegeri);
            FileAppendText("c:\\udemy\\merhaba.txt", "Merhaba TXT");

            FileCopy("c:\\udemy2\\merhaba.txt", "c:\\udemy\\merhaba.txt");
            FileMove("c:\\udemy\\merhaba.txt", "c:\\udemy2\\merhaba.txt");

            FileDelete("c:\\udemy\\merhaba.txt");
             
        }

        static void FileCreate(string path) 
        {
            FileStream Fs = File.Create(path);
            Fs.Close();
        }

        static bool FileExists(string path) 
        {
            return File.Exists(path);
        }

        static void FileDelete(string path) 
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef) 
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef) 
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path, string deger) 
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path) 
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }
    }
}
