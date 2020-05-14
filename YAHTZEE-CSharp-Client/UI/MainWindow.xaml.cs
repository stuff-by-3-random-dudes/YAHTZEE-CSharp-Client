using System;
using System.Windows;

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
            try
            {
                mvm.AddPlayer(tb_PName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_PName.Text = String.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mvm.ResetPlayerList();
        }

        private void MenuItem_ClickDelete(object sender, RoutedEventArgs e)
        {
            try
            {
                mvm.RemoveSelectedPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
