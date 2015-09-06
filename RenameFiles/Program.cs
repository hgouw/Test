using System;
using System.IO;
using System.Linq;

namespace RenameFiles
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            string oldPath = System.Configuration.ConfigurationManager.AppSettings["OldPath"];
            string newPath = System.Configuration.ConfigurationManager.AppSettings["NewPath"];
            DirectoryInfo info = new DirectoryInfo(oldPath);
            var files = info.GetFiles().OrderBy(p => p.LastWriteTimeUtc).ToArray();
            foreach (FileInfo file in files)
            {
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string newFile = String.Format(@"{0}\IMG_{1}.jpg", newPath, FileCounter());
                file.CopyTo(newFile);
                File.SetCreationTime(newFile, file.LastWriteTimeUtc);
                File.SetLastAccessTime(newFile, file.LastWriteTimeUtc);
                File.SetLastWriteTime(newFile, file.LastWriteTimeUtc);
            }
        }

        static string FileCounter()
        {
            string fileCounter = counter.ToString("D4");
            counter++;
            return fileCounter;
        }
    }
}