using System.Windows;
using Syncfusion.Windows.Tools.Controls;
using WritersDesk.DBContexts;

namespace WritersDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private readonly ProductContext _productContext = new ProductContext();

        public MainWindow()
        {
            InitializeComponent();

            _productContext.Database.EnsureCreated();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {

            

            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

        
    }
}
