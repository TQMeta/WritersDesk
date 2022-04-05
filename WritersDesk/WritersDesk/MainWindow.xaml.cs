using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Syncfusion.Windows.Tools.Controls;
using WritersDesk.DBContexts;
using WritersDesk.UserControls.Web;

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

        private void NewMap_OnClick(object sender, RoutedEventArgs e)
        {

            /*foreach (ContentControl child in DockingManager.DocContainer.Items)
            {
                MessageBox.Show(child.Name);

                if (child.Name == "MapGenerator")
                {
                    this.DockingManager.ActivateWindow(child.Name);
                    return;
                }
            }*/

            var mapsBrowser = new WDeskBrowser("https://localhost:7022/sites/mapgenerator/index.html");

            var content = new ContentControl
            {
                Content = mapsBrowser,
                Name = "MapGenerator"
            };

            DockingManager.SetHeader(content, "Map Generator");
            DockingManager.SetState(content, DockState.Document);

            DockingManager.DocContainer.Items.Add(content);
        }
    }
}
