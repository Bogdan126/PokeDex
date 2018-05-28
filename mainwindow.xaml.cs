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

namespace ForFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Nowy_Pok_Click(object sender, RoutedEventArgs e)
        {
            Nowy_Pok nowy_pok = new Nowy_Pok();
            nowy_pok.Show();
        }

        private void Nowy_Pok_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Edycja_Poka edycja = new Edycja_Poka();
            edycja.Show();
        }

        private void Ustawienia_Click(object sender, RoutedEventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            ustawienia.Show();
        }
    }
}
