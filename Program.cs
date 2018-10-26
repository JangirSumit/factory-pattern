using System;

namespace factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please select file type from below (1/2)");
            System.Console.WriteLine("1. With Header\n2. Without Header");
            System.Console.WriteLine("");

            var type = Convert.ToInt32(Console.ReadLine());
            FileType fileType = (FileType)type;

            System.Console.WriteLine("");

            var createFileFactory = new CreateFileFactory();
            var createFileObject = createFileFactory.GetFileObject(fileType);

            createFileObject.CreateFile("Demo");
            System.Console.WriteLine("");
        }
    }
}
