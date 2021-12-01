using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class NameModel
    {
        public String FirstName { set; get; }

        public String LastName { set; get; }

        public NameModel(String fn, String ln)
        {
            FirstName = fn;
            LastName = ln;
        }
    }
}
