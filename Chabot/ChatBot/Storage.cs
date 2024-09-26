using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    public class Storage
    {
        private string filePath = "C:\\Users\\lenny\\OneDrive - ipso! Bildung\\Desktop\\keywords.txt";

        public Dictionary<string, string> LoadKeywords()

        {
            Dictionary<string, string> keywordResponses = new Dictionary<string, string>();
            if (File.Exists(filePath))

            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)

                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)

                    {
                        keywordResponses.Add(parts[0].ToLower(), parts[1]);
                    }
                }
            }
            return keywordResponses;
        }
        public void SaveKeywords(Dictionary<string, string> keywords)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var keyword in keywords)
                {
                    writer.WriteLine($"{keyword.Key}:{keyword.Value}");
                }
            }


        }
    }
}
        
    
