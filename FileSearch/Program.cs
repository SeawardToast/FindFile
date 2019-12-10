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
            string file = string.Empty;
            string path = string.Empty;
            string extension = "*";
            Console.WriteLine("What is the name of the file you are searching for? (include extension)");
            file = Console.ReadLine();
            extension += file.Split('.')[1];
            Console.WriteLine("Which directory should we search for this file?");
            path = Console.ReadLine();
            util.FindFile(file, path, extension);
            
        }
    }

    class SearchUtils
    {
        public SearchUtils()
        {

        }

        public void FindFile(string fileName, string directory, string extension)
        {
            bool flag = false;
            try
            {
                string[] files = Directory.GetFiles(directory, extension, SearchOption.AllDirectories);
                foreach (string file in files)
                {

                    if (Path.GetFileName(file).Equals(fileName))
                    {
                        Console.WriteLine("We have found the file at " + file);
                        flag = true;
                    }
                        
                }
            } catch(UnauthorizedAccessException e)
            {
                
            }
            if(!flag)
                Console.WriteLine("We have not found the file");
        }
    }
}
