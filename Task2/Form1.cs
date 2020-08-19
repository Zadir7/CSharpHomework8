using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form, IView
    {
        Link l;
        public Form1()
        {
            InitializeComponent();
        }

        public string DataText { get { return txtB.Text; } set { txtB.Text = value; } }
        public decimal DataNumber { get { return numUpDown.Value; } set { numUpDown.Value = value; } }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new Link(this);
            l.UpdateLink(true);
        }
        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            l.UpdateLink(true);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            l.UpdateLink(false);
        }
    }
}
