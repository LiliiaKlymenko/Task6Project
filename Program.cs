using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Task6Project
{
    class Program
    {



        static void Main(string[] args)
        {
            string address = "https://dl.dropboxusercontent.com/u/98396761/NewTxt.txt";
            string fileName = @"d:\NewTxt.txt";           

            using (WebClient webClient = new WebClient())
            {                    
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n", fileName, address);
                webClient.DownloadFile(address, @fileName);              
                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, address);
                string appDirectory = Environment.CurrentDirectory;
                Console.WriteLine("\nThe file is saved at:\t" + fileName);
                Console.ReadLine();

            }

            

        }

    }
}
