using System.IO;

namespace Aula44
{
    public class FileInfoImp
    {
        public void systemTest()
        {
            string sourcePath = @"c:\temp\data.txt";
            string targetPath = @"c:\temp\data2.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);

                file.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string s in lines)
                {
                    System.Console.WriteLine(s);
                }
            }

            catch(IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}