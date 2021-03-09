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
            //                                     T          + AyLOr
            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1,6)
            + artist.ToUpper()[7] + artist.Substring(8);
            //                 S  + wIFt

            string realProblem = "tAylOr SwIFt, tHe WeEknD, TRaViS sCoTt, aRiANa gRAndE, bILlie eiLiSh";
            string[] artistNames = realProblem.Split(",");


            for (int i = 0; i < artistNames.Length; i++)
            {
                string tist = artistNames[i];
                //int spaceLocation = tist.IndexOf(' ');
                //artistWithProperName = artist.ToUpper()[0] + artist.Substring(1, spaceLocation)
                //    + tist.ToUpper()[spaceLocation + 1] + tist.Substring(spaceLocation + 2);
                //Console.WriteLine(artistWithProperName);

                string[] names = tist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                firstName = firstName.ToUpper()[0] +firstName.Substring(1);
                lastName = lastName.ToUpper()[] + lastName.Substring(1);

                Console.WriteLine($")



            }

            //12 means characters (specific to taylor swift)
            //that is shown with artistWithProperName.Length
            //Length property shows charcters in a word
            {
                //Console.WriteLine(artistWithProperName[i]);
            }

            if (b)
            {
                int index = phrase.IndexOf(Userword);
                if (index >= 0)
                    UserWord = NewWord.Replace(Userword, NewWord);
                Console.WriteLine($"{phrase} {NewWord}.");








                Console.WriteLine(artistWithProperName);

            //if you do the above green, it must be this instead of the line above...
            // console.WriteLine(newValue);
        }
    }
}
