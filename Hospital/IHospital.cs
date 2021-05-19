using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    interface IHospital
    {
        public int NumberOfRequests();
        public int NumberOfSatisfiedRequests();

    }
}
