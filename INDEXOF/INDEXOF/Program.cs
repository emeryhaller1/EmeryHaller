using System;

namespace INDEXOF
{
    class Program
    {
        static void Main(string[] args)
        {
            //            0123456789...
            string msg = "Hello World";

            int indexofTheFirstWord = msg.IndexOf('e');

            Console.WriteLine(msg);
            Console.WriteLine(indexofTheFirstWord);

        }
    }
}
