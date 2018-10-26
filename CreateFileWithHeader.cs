namespace factory_pattern
{
    public class  CreateFileWithHeader : ICreateFile
    {
        public void CreateFile(string fileName)
        {
            System.Console.WriteLine("******************** Header ***********************");
            System.Console.WriteLine($"{fileName}");
        }
    }
}