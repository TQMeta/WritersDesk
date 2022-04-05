using System;
using System.Security.Policy;
using System.Windows.Controls;

namespace WritersDesk.UserControls.Web
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WDeskBrowser : UserControl
    {
        public WDeskBrowser()
        {
            
        }
        
        public WDeskBrowser(string Url)
        {            
            InitializeComponent();

            this.webView.Source = new Uri(Url);

        }
    }
}