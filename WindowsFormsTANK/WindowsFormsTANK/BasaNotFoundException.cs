using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class BasaNotFoundException : Exception
    {
        public BasaNotFoundException(int i) : base("Не найден tank по месту "
       + i)
        { }
    }

