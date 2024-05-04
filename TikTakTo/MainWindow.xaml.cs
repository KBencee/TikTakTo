using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TikTakTo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] mezok;
        private bool jatekosKor = true;
        private Random r = new();

        public MainWindow()
        {
            InitializeComponent();
            mezok = new Button[3, 3] { { mezo11, mezo12, mezo13 }, { mezo21, mezo22, mezo23 }, { mezo31, mezo32, mezo33 } };
            }

        private void mezo11_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
