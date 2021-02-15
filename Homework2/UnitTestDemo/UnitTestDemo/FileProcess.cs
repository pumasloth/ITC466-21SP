namespace UnitTestDemo
{
    using System;
    using System.IO;

    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            return File.Exists(fileName);
        }
    }
}
