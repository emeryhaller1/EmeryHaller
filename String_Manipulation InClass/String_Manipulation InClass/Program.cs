using System;

namespace String_Manipulation_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //               123456 7890
            string artist = "tAylOr SwIFt";
            artist = artist.ToLower();


            //could also do...
            //string newValue = artist.ToLower();

            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1,6)
            + artist.ToUpper()[7] + artist.Substring(8);
            
            //for (int i = 0; i < artistWithProperName.Length; i++)

            //12 means characters (specific to taylor swift)
            //that is shown with artistWithProperName.Length
            //Length property shows charcters in a word
            {
                //Console.WriteLine(artistWithProperName[i]);
            }


            Console.WriteLine(artistWithProperName);

            //if you do the above green, it must be this instead of the line above...
            // console.WriteLine(newValue);
        }
    }
}
