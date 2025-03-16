using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SlimmeLantaarnpaal
{
    class Lantaarnpaal
    {
        // Properties
        public int ID { get; private set; } 
        public bool HuidigeStatus { get; private set; } 
        public DateTime LaatsteUpdate { get; private set; } 

        //Constructor

        public Lantaarnpaal(int iD) 
        {
            ID = iD;
        }

        //Methods

        public void ZetAan()
        {
            HuidigeStatus = true;
            LaatsteUpdate = DateTime.Now;
        }

        public void ZetUit()
        {
            HuidigeStatus = false;
            LaatsteUpdate = DateTime.Now;
        }

    }
}
