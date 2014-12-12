using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelationAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Girl girl1 = new Girl();
            girl1.GirlName = girlNametextBox.Text;

            Boy boy = new Boy();
            boy.BoyName = boyNametextBox.Text;
         
            boy.GetSetGirl = girl1;
            MessageBox.Show("Happy Couple: "+ boy.BoyName+" and "+boy.showName());
        }
    }
}
