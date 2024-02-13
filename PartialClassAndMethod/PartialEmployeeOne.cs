using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public partial class PartialEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }


        partial void PartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked.");
            PartialMethod();
        }
    }
}
