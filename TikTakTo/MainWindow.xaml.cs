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
        const int size = 3;
        int[,] matrix;

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < size; i++)
            {
                JatekGrid.RowDefinitions.Add(new());
                JatekGrid.ColumnDefinitions.Add(new());
            }
            GenerateMatrix();
            ShowMatrix();
        }

        public void GenerateMatrix()
        {
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8,9 };
            int[] shuffled = szamok.OrderBy(n => Guid.NewGuid()).ToArray();
            int counter = 0;
            matrix = new int[size, size];
            Random r = new();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = shuffled[counter];
                    counter++;
                }
            }
        }

        public void ShowMatrix()
        {
            JatekGrid.Children.Clear();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button b = new();
                    b.Content = matrix[i, j];
                    if (matrix[i, j] == 9)
                    {
                        b.Background = new SolidColorBrush(Colors.Gray); b.Foreground= new SolidColorBrush(Colors.Gray);
                        b.IsEnabled = false;
                    }
                    b.HorizontalAlignment = HorizontalAlignment.Stretch;
                    b.VerticalAlignment = VerticalAlignment.Stretch;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    b.Click += csere_Click;
                    JatekGrid.Children.Add(b);
                }
            }
        }

        private void csere_Click(object sender, RoutedEventArgs e)
        {
            Button current = sender as Button;
            int row = Grid.GetRow(current);
            int column = Grid.GetColumn(current);
            if (current.IsEnabled == true &&)

            ShowMatrix();
        }
    }
}
