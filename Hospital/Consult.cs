using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Consult:AHospital, IHospital
    {
            int Requests = 30;
     
        public int NumberOfRequests()
        {
            return Requests;
        }
        public int NumberOfSatisfiedRequests()
        {
            SatisfiedRequests =   Requests-10;
            return SatisfiedRequests;
        }

    }
}
