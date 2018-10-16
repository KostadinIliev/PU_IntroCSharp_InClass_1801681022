using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you to play some music?");
            string answer =Console.ReadLine();

            if (answer == "Yes")
            {
                // Create new SoundPlayer in the using statement.
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\W3\PU_IntroCSharp_InClass_1801681022\W3InClass\MusicFactory\Music\Eminem - Venom.mp3"))
                {
                    player.PlaySync();
                }

            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (answer == "Fuck")
            {
                Console.WriteLine("Yes, fuck you too!!!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            


            
        }
    }
}
