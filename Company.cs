using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac45
{
    class Company<P>
    {
        public P CEO { get; }
        public Company(P ceo)
        {
            CEO = ceo;
        }
        }
}
