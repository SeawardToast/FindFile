using System;
using System.IO;
namespace FileSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SearchUtils util = new SearchUtils();
            util.FindFile("hello.txt", @"C:\Users\aidan\Documents");
        }
    }

    class SearchUtils
    {
        public SearchUtils()
        {

        }

        public void FindFile(string fileName, string directory)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directory))
                {
                    
                    if(Path.GetFileName(file).Equals(fileName))
                        Console.WriteLine("Your file has been found at location " + file);
                }
            } catch(UnauthorizedAccessException e)
            {
                
            }
            
        }
    }
}
