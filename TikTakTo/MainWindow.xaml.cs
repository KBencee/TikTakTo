using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TikTakTo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Button[,] mezok;
        private bool jatekosKor = false;
        private readonly Random r = new();

        public MainWindow()
        {
            InitializeComponent();
            mezok = new Button[3, 3] { { mezo11, mezo12, mezo13 }, { mezo21, mezo22, mezo23 }, { mezo31, mezo32, mezo33 } };
            RandomO();
            }

        private void mezo_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Content == null && jatekosKor)
            {
                b.Content = "X";
                jatekosKor = false;
                Ellenorzes();
                if (!jatekosKor)
        {
                    RandomO();
                }
            }
        }

        private void RandomO()
        {
            var szabadMezok = new System.Collections.Generic.List<Button>();
            foreach (Button b in mezok)
            {
                if (b.Content == null)
                {
                    szabadMezok.Add(b);
                }
            }
            if (szabadMezok.Count > 0)
            {
                int i = r.Next(szabadMezok.Count);
                szabadMezok[i].Content = "O";
                jatekosKor = true;
                Ellenorzes();
            }
        }

        private void Ellenorzes()
        {
            for (int i = 0; i < 3; i++)
            {
                if (mezok[i, 0].Content != null && mezok[i, 0].Content == mezok[i, 1].Content && mezok[i, 0].Content == mezok[i, 2].Content)
                {
                    if (mezok[i, 0].Content == "X")
                        MessageBox.Show("Nyertél!");
                    else
                        MessageBox.Show("Vesztettél.");
                    Ujraindit();
                    return;
                }
                if (mezok[0, i].Content != null && mezok[0, i].Content == mezok[1, i].Content && mezok[0, i].Content == mezok[2, i].Content)
                {
                    if (mezok[0, i].Content == "X")
                        MessageBox.Show("Nyertél!");
                    else
                        MessageBox.Show("Vesztettél.");
                    Ujraindit();
                    return;
                }
        }
            if (mezok[0,0].Content != null && mezok[0,0].Content == mezok[1,1].Content && mezok[0,0].Content == mezok[2,2].Content)
            {
                if (mezok[0, 0].Content == "X")
                    MessageBox.Show("Nyertél!");
                else
                    MessageBox.Show("Vesztettél.");
                Ujraindit();
                return;
            }
            if (mezok[0, 2].Content != null && mezok[0, 2].Content == mezok[1, 1].Content && mezok[0, 2].Content == mezok[2, 0].Content)
            {
                if (mezok[0, 2].Content == "X")
                    MessageBox.Show("Nyertél!");
                else
                    MessageBox.Show("Vesztettél.");
                Ujraindit();
                return;
            }

            bool dontetlen = true;
            foreach (Button b in mezok) 
            { 
                if (b.Content == null)
                {
                    dontetlen = false;
                    break;
                }
            }
            if (dontetlen)
            {
                MessageBox.Show("Döntetlen... :/");
                Ujraindit();
            }
        }

        private void Ujraindit()
        {
            foreach (Button b in mezok)
            {
                b.Content = null;
            }
            jatekosKor = false;
            RandomO();
    }
}
}
