using System;
using System.IO;

namespace JvPipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            string file = @"C:\temp\TestFile.txt";

            try
            {
                if(File.Exists(file))
                {
                    File.Delete(file);        
                }
                using (StreamWriter sw = File.CreateText(file))    
                {    
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());    
                    sw.WriteLine("Author: Javier H");  
                    sw.WriteLine("Done! ");    
                } 
                using (StreamReader sr = File.OpenText(file))    
                {    
                    string s = "";    
                    while ((s = sr.ReadLine()) != null)    
                    {    
                        Console.WriteLine(s);    
                    }    
                }       
            }
            catch (Exception Ex)    
            {    
                Console.WriteLine(Ex.ToString());    
            }

            Console.WriteLine("Hello World!");
        }
    }
}
