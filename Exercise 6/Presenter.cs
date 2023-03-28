using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Presenter
    {

        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.Add_myEvent += new EventHandler(add_myEvent);
            this.mainWindow.Remove_myEvent += new EventHandler(remove_myEvent);
        }

        void add_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Add();

            this.mainWindow.textBox1.Text = variable;
        }
        void remove_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Remove();

            this.mainWindow.textBox1.Text = variable;
        }
    }
}
