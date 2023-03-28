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

namespace Exercise_4
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

        public event EventHandler AddEvent = null;
        public event EventHandler SubEvent = null;
        public event EventHandler MulEvent = null;
        public event EventHandler DivEvent = null;
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEvent.Invoke(sender, e);
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            SubEvent.Invoke(sender, e);
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            MulEvent.Invoke(sender, e);
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            DivEvent.Invoke(sender, e);
        }
    }
}
