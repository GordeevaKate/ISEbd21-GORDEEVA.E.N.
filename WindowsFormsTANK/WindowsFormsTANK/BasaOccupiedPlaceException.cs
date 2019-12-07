using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTANK
{
    public class BasaOccupiedPlaceException : Exception
 {
 public BasaOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
 { }

}
}
