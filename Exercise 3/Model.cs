using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace Exercise_3
{
   public class Model
    {
        internal DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        internal DateTime date =DateTime.Now;
      
        internal long tick;
        DateTime stopWatch = new DateTime();
        
       
        public Model() 
        {
            tick  = DateTime.Now.Ticks - date.Ticks;
            timer.Interval = TimeSpan.FromMilliseconds(1);
           

        }

       public string Print()
        {


            stopWatch = stopWatch.AddTicks(tick);
            return String.Format("{0:HH:mm:ss:ff}", stopWatch);
            
        }
        public void Start()
        {
           
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public void Update()
        {
            stopWatch = default;
        }
    }
}
