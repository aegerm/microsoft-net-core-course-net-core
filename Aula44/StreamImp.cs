using System.IO;

namespace Aula44
{
    public class StreamImp
    {
        public void test()
        {
            string path = @"c:\temp\data.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    System.Console.WriteLine(line);
                }
            }

            catch(IOException e)
            {
                System.Console.WriteLine(e.Message);
            }

            finally
            {
                //if (fs != null)
               // {
                  //  fs.Close();
                //}

                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}