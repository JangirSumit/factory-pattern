using System;

namespace factory_pattern
{
    public class CreateFileFactory
    {
        public ICreateFile GetFileObject(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.WithHeader : 
                    return new CreateFileWithHeader();

                case FileType.WithoutHeader : 
                    return new CreateFileWithoutHeader();
                default:
                throw new Exception ("Invalid type");
            }
        }
    }
}