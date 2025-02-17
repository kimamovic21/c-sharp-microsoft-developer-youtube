using System;
using System.IO; 
using System.Net;
using System.Collections;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\MyFiles\test-file.txt");
                //string content = File.ReadAllText(@"C:\MyFile\test.txt");
                //string content = File.ReadAllText(@"C:\MyFiles\test.txt");

                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the name of the file is named correctly: test-file.txt");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(@"Make sure the name of the directory C:\MyFiles exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now...");
            }

            Console.ReadLine();
        }
    }
}