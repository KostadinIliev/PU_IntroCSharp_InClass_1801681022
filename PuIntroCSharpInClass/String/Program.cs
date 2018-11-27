using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] names = new string[]
            {
                "Зайко Байко" ,
                "Фики",
                "Буги Барабата"
            };

            string[] names2 = new string[50];

            names2[0] = "Ne e validno setvane";

            for (int i = 1; i <names2.Length; i++)
            {
                Random rnd = new Random();
                string fakeName = string.Empty;
                for (int j = 0; j < 5; j++)
                {
                    int currNumb = rnd.Next(160, 260);
                    char letter = (char)currNumb;
                    fakeName = string.Concat(fakeName , letter);
                }
                names2[i] = fakeName;
            }
            int loops = names2.Length;
            while (loops > 0)
            {
                if (loops == 0)
                {
                    break;
                }
                try
                {
                    Console.WriteLine(names2[loops]);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                
             
                loops--;
            }

        

        }
    }
}
