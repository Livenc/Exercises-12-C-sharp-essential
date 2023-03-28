using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{

    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddEvent += new EventHandler(AddEvent_myEvent);
            this.mainWindow.SubEvent += new EventHandler(SubEvent_myEvent);
            this.mainWindow.MulEvent += new EventHandler(MulEvent_myEvent);
            this.mainWindow.DivEvent += new EventHandler(DivEvent_myEvent);
        }
        void AddEvent_myEvent(object sender, EventArgs e)
        {
            mainWindow.result.Text =  model.Add(mainWindow.first.Text, mainWindow.second.Text).ToString();
            

        }
        void SubEvent_myEvent(object sender, EventArgs e)
        {

            mainWindow.result.Text = model.Add(mainWindow.first.Text, mainWindow.second.Text).ToString();

        }
        void MulEvent_myEvent(object sender, EventArgs e)
        {

            mainWindow.result.Text = model.Add(mainWindow.first.Text, mainWindow.second.Text).ToString();

        }
        void DivEvent_myEvent(object sender, EventArgs e)
        {
            mainWindow.result.Text = model.Add(mainWindow.first.Text, mainWindow.second.Text).ToString();


        }
    }
}
