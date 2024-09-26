using System.IO;
using System.Windows;

namespace idk
{
    /// <summary>
    /// Erstellen von einer Assoziation mit BotEngine, erstellen eines LogfilePaths
    /// </summary>
    public partial class MainWindow : Window
    {

        private BotEngine botEngine;
        private string logFilePath = "C:\\Users\\Ege Ulu Dell\\OneDrive - ipso! Bildung\\Desktop\\Modul 320\\Projekte\\WPF\\idk\\ChatLog.txt"; // Speicherort für die Log-Datei
         
        public MainWindow()
        {
            InitializeComponent();
            botEngine = new BotEngine();
        }

        /// <summary>
        /// erstellen einer Senden methode(schickt den UserInput)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            string userMessage = UserInput.Text;
            ChatDisplay.AppendText("User: " + userMessage + "\n");

            string botResponse = botEngine.GetResponse(userMessage);
            ChatDisplay.AppendText("Bot: " + botResponse + "\n");

            UserInput.Clear();
        }
        // Methode zum Hinzufügen von Einträgen in die Log-Datei

        /// <summary>
        /// Methode zum Hinzufügen von Logeinträgen in eine Logdatei
        /// </summary>
        /// <param name="message"></param>
        private void LogMessage(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true)) // true bedeutet, dass die Datei nicht überschrieben wird
                {
                    sw.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Schreiben der Log-Datei: {ex.Message}");
            }
        }

        private void Hinzu_Click_1(object sender, RoutedEventArgs e)
        {
            Hinzu hinzuWindow = new Hinzu(); // Erstelle das Hinzu-Fenster
            hinzuWindow.Show(); // Öffne das Hinzu-Fenster als neues Fenster
            
            this.Close();
        }

        private void Chatbot_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   //Öffnen der Hauptseite,(Chat und bot werden resetet)
            mainWindow.Show();
        }
    }
}