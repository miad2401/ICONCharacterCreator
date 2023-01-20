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

namespace ITCS_3112_ICON_Character_Creator
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

        private void TabControlSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl control = (TabControl)sender;
            if (control != null)
            {
                if (control.SelectedItem != null)
                {
                    TabItem selected = control.SelectedItem as TabItem;
                    this.Title = selected.Header.ToString();
                    selected.Background = new BrushConverter().ConvertFrom("#FF9A7767") as Brush;
                }

            }
        }
    }
}
