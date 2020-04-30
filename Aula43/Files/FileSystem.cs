using System.IO;

namespace Aula43.Files
{
    public class FileSystem
    {
        public void ReadFileItem(FileStream file)
        {
            try
            {
                file = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                
                StreamReader sr = new StreamReader(file);
                
                string line = sr.ReadLine();
                
                System.Console.WriteLine(line);
            }

            catch(FileNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }

            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}