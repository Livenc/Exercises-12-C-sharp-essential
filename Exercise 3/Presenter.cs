using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        
        public Presenter(MainWindow mainWindow) 
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.startEvent += new EventHandler(start_myEvent);
            this.mainWindow.stopEvent += new EventHandler(stop_myEvent);
            this.mainWindow.clearEvent += new EventHandler(clear_myEvent);
        }
        void start_myEvent(object sender, EventArgs e)
        {
            
            model.timer.Tick +=tickTimer;
            model.Start();

            //this.mainWindow.Timerlbl.Content = variable;
        }
        void stop_myEvent(object sender, EventArgs e)
        {
            
            model.Stop();
            
        }
        void tickTimer(object sender, EventArgs e)
        {
            mainWindow.Timerlbl.Content = model.Print();
         
        }
        void clear_myEvent(object sender, EventArgs e)
        {
            
            model.timer.Tick += tickTimer;
            model.Update();

        }
    }
}
