namespace factory_pattern
{
    public class  CreateFileWithoutHeader : ICreateFile
    {
        public void CreateFile(string fileName)
        {
            System.Console.WriteLine($"{fileName}");
        }
    }
}