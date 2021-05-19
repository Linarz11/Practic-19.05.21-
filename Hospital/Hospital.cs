using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   public abstract class AHospital
    {
        public int Requests { get; protected set; }
        public int SatisfiedRequests { get; protected set; }

        public int Staff { get; protected set; }
        public int Rooms { get; protected set; }


    }
}
