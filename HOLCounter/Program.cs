using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"
            Console.WriteLine("Hello World!");
            string HelloWorld = ("hello world!");
            
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    hCounter++;
                }
                if (HelloWorld [i] == 'o')
                {
                    oCounter++;
                }
                if (HelloWorld[i] == 'l')
                {
                    lCounter++;
                }

            }
            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' täht.");
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' täht.");
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' täht.");
            }
        }
    }
}
