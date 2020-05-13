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
using YAHTZEE_CSharp_Client.Classes;

namespace YAHTZEE_CSharp_Client.UI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm;
        public MainWindow()
        {
            InitializeComponent();
            mvm = FindResource("mvm") as MainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tb_PName.Text))
            {
                mvm.AddPlayer(new Player(tb_PName.Text));
                tb_PName.Text = string.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mvm.ResetPlayerList();
        }
    }
}
