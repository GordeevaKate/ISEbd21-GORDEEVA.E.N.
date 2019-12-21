using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTANK
{
    public class BasaAlreadyHaveException : Exception
    {
        public BasaAlreadyHaveException() : base("На парковке уже есть такая машина")
        { }
    }
}
