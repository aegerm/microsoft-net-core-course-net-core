using System.Collections.Generic;
using System.IO;

namespace Aula44
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\data.txt";

            System.Console.WriteLine(Path.GetDirectoryName(path));
        }

        public void manipulandoArquivosPasta()
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                foreach (string s in folders)
                {
                    System.Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string s in files)
                {
                    System.Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }

            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public void ToUp()
        {
            string path = @"c:\temp\data.txt";
            string path2 = @"c:\temp\data2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(path2))
                {
                    foreach(string l in lines)
                    {
                        sw.WriteLine(l.ToUpper());
                    }
                }
            }

            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public void ImpUsign()
        {
            string path = @"c:\temp\data.txt";

            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        System.Console.WriteLine(line);
                    }
                }
            }

            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
