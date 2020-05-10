using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_Cok_Bicimlilik_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A a_nesnesi = new A();
            MessageBox.Show(a_nesnesi.Method());

            B b_nesnesi = new B();
            MessageBox.Show(b_nesnesi.Method());

            C c_nesnesi = new C();
            MessageBox.Show(c_nesnesi.Method());
        }
    }
}
