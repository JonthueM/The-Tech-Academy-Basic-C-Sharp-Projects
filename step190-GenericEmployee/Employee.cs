using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step190_GenericEmployee
{
    class Employee <T> //Generic Class
    {
        public List<T> things { get; set; } //Generic List
    }
}
