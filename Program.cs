using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}