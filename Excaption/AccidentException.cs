using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excaption
{
    public class AccidentException : Exception
    {
        public string Location { get; set; }
        public AccidentException(string location,string message):base(message)
        {
            this.Location = location;
        }
    }
}
