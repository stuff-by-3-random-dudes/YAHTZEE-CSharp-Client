using System;
using System.Windows;
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
            if (!String.IsNullOrWhiteSpace(tb_PName.Text))
            {
                mvm.AddPlayer(new Player(tb_PName.Text));
                tb_PName.Text = string.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mvm.ResetPlayerList();
        }

        private void cm_Opened(object sender, RoutedEventArgs e)
        {

        }
    }
}
