using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    class Link : IView
    {
        public string txt;
        public decimal num;
        IView view;
        public string DataText { get { return DataText; } set { DataText = value; } }
        public decimal DataNumber { get { return DataNumber; } set { DataNumber = value; } }

        public Link(IView view)
        {
            this.view = view;
        }

        string Convertation(decimal _num)
        {
            return Convert.ToString(_num);
        }
        decimal Convertation(string _str)
        {
            decimal.TryParse(_str, out decimal r);
            return r;
        }
        public void UpdateLink(bool b)
        {
            if (b == true)
            {
                num = view.DataNumber;
                view.DataText = $"{Convertation(num):f0}";
            } else 
            {
                txt = view.DataText;
                decimal tempNumber = Convertation(txt);
                if (tempNumber >= 0 && tempNumber <= 100)
                {
                    view.DataNumber = Convertation(txt);
                }
                else if (tempNumber < 0)
                {
                    view.DataNumber = 0;
                }
                else if (tempNumber > 100)
                {
                    view.DataNumber = 100;
                }
            }

            
        }
    }
}
