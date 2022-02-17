using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryPractice;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int first = int.Parse(tbFirst.Text);
            int second = int.Parse(tbSecond.Text);
            Resault.Text = ClassLibraryPractice;
        }

        private void Multi_Click(object sender, EventArgs e)
        {

        }
    }
}
