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
using System.Windows.Threading;

namespace Exercise_3
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
        public event EventHandler startEvent = null;
        public event EventHandler stopEvent = null;
        public event EventHandler timetEvent = null;
        public event EventHandler clearEvent = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            startEvent.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stopEvent.Invoke(sender, e);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timetEvent.Invoke(sender, e);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            clearEvent.Invoke(sender, e);
        }
    }
}
