using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic!" 0-ga
            //programm asendab kõik 'a' tähed lauses 4-ga
            String DontPanic = "Don't Panic!";

          DontPanic= DontPanic.Replace('o', '0');
            DontPanic = DontPanic.Replace('a', '4');
            Console.WriteLine(DontPanic);
        }
    }
}
