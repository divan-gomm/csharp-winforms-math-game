using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the Score Manager Class of Mystic Math Game.
The class manages the leaderboard, it handles adding,saving and loading scores from a scoreboard.txt file.
*/



namespace MysticMathsGame__Divan_Gomm.Top_Scores
{
    internal class ScoreManager
    {   //Create sorted list for top scores
        private SortedList< int, string> topScores = new SortedList<int, string>();

        //Add scores to the list
        public void AddScore(string playerName, int score)
        {
            //Added to prevent duplicate keys 
            while (topScores.ContainsKey(score))
            {
                score--;
            }

            topScores.Add(score, playerName);

        }
        //To Save scores to file
        public void SaveScores(string filePath)
        {
            using(StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (var entry in topScores.Reverse())
                {
                    writer.WriteLine($"{entry.Value}:{entry.Key}");
                }

            }

        }

        // Loading scores from file
        public void LoadScores(string filePath)
        {
            topScores.Clear();

            if(File.Exists(filePath))
            {
                foreach(string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split(':');

                    if(parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        AddScore(parts[0], score);
                    }
                }
            }

        }

        //Display scores in listbox
        public void DisplayScores(ListBox listBox)
        {
            listBox.Items.Clear();

            foreach(var entry in topScores.Reverse())
            {
                listBox.Items.Add($"{entry.Value} - {entry.Key}");
            }
        }








    }
}
