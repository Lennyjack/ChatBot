using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace idk
{
    /// <summary>
    /// Interaction logic for Hinzu.xaml
    /// </summary>
    public partial class Hinzu : Window
    {
        public Hinzu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fügt der Datei mit dem streamwriter neue Antworten hinzu 
        /// überprüft ob die Antworten ein : beeinhalten da diese notwendid sind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHinzu_Click(object sender, RoutedEventArgs e)
        {
            if (tbHinzu.Text.Contains(":"))
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\lenny\OneDrive - ipso! Bildung\Desktop\keywords.txt", true);
                string Hinzu1 = tbHinzu.Text;
                sw.WriteLine(Hinzu1);
                sw.Close();//fügt der Text Datei neue Schlüsselwörter/Antworten hinzu
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Sie haben ein falsches Format verwendet.",
                                                          "Fehler",
                                                          MessageBoxButton.OK,
                                                          MessageBoxImage.Error);   // falls die Neue Antwort kein : enthält gibts ein Fehler
            }
        }

        private void Hinzu1_Click(object sender, RoutedEventArgs e)
        {
            Hinzu hinzuWindow = new Hinzu(); // Erstelle das Hinzu-Fenster
            hinzuWindow.Show(); // Öffne das Hinzu-Fenster als neues Fenster
        }

        private void Chatbot_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   //Öffnen der Hauptseite,(Chat und bot werden resetet)
            mainWindow.Show();
            this.Close();
        }
    }
}
