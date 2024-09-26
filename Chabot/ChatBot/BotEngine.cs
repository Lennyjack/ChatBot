using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    public class BotEngine
    {
        private Dictionary<string, string> keywordResponses;  // Richtig definierter Typ
        private Storage storage;  // Richtig definierter Typ

        public BotEngine()
        {
            storage = new Storage();  // Initialisiere die Storage-Instanz korrekt
            keywordResponses = storage.LoadKeywords();  // Lade die Keywords und antworte richtig
        }

        public string GetResponse(string userInput)
        {
            // Falls das userInput in der Liste der Keywords enthalten ist
            if (keywordResponses.ContainsKey(userInput.ToLower()))
            {
                return keywordResponses[userInput.ToLower()];  // Gib die entsprechende Antwort zurück
            }
            else
            {
                return "Tut mir leid, ich habe das nicht verstanden";  // Standardantwort, wenn das Schlüsselwort nicht gefunden wird
            }
        }
    }
}
    