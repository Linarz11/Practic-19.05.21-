using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Emergency:AHospital, IHospital
    {
        int Requsts = 20;
        public int NumberOfRequests()
        {
            return Requests;
        }
        public int NumberOfSatisfiedRequests()
        {
            SatisfiedRequests = Requests - 3;
            return SatisfiedRequests;
        }
    }
}
