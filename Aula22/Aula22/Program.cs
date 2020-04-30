using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[]
{
                "Desktop",
                "Smartphone",
                "Notebook"
};

            foreach (string s in vect)
            {
                Console.WriteLine(s);
            }
        }
    }
}
