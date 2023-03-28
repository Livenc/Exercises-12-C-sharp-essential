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

namespace Exercise_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler Add_myEvent = null;
        public event EventHandler Remove_myEvent = null;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Add_myEvent.Invoke(sender, e);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Remove_myEvent.Invoke(sender, e);
        }
    }
}
