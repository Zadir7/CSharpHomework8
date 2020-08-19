using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IView
    {
        string DataText { get; set; }
        decimal DataNumber { get; set; }
    }
}
