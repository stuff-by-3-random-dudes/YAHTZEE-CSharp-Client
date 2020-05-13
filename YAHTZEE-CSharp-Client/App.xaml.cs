using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace YAHTZEE_CSharp_Client
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SetLanguageDictionary();
        }
            private void SetLanguageDictionary()
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-US":
                    dict.Source = new Uri("..\\LanguageFiles\\LanguageEN-US.xaml", UriKind.Relative);
                    break;
                case "de-DE":
                    dict.Source = new Uri("..\\LanguageFiles\\LanguageDE-DE.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\LanguageFiles\\LanguageEN-US.xaml", UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dict);
        }
    }
}
