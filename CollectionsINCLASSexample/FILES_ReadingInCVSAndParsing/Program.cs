using System;
using System.Collections.Generic;
using System.IO;

namespace FILES_ReadingInCVSAndParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");
            // select the lightbult that says system IO when using file
            List<string> states = new List<string>();
            //using systems.collections.generic
            List<double> soccerscores = new List<double>();
            List<double> footballscores = new List<double>();

            // Console.WriteLine(lines);  //will just output string[] unless you specifiy what you want


            //int i = 3 to get rid of the beginning column names
            for (int i = 3; i < lines.Length; i++)
            {
                //Region/State, SOCCER, FOOTBALL
                //Alabama, 16%, 84%
                string line = lines[i];

                //    0         1     2
                //{"Alabama", "16%", "84"}
                //splitting where there are commas
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);


                //must remove the % sign 
                string soccerScoreAsString = pieces[1].Remove(pieces[1].Length-1) ;
                double soccerScore = Convert.ToDouble(soccerScoreAsString) / 100;
                soccerscores.Add(soccerScore);

                footballscores.Add(Convert.ToDouble(pieces[2].Remove(pieces[1].Length - 1)) / 100);


               // Console.WriteLine(state);
            }

            for (int i = 0; i < footballscores.Count; i++)
            {
                string state = states[i];
                double soccer = soccerscores[i];
                double football = footballscores[i];

                if (soccer > football)
                {
                    Console.WriteLine(state);
                }


            }

        }
    }
}
