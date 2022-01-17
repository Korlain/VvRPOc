using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_cyrs
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Redactbutton_Click(object sender, EventArgs e)
        {
            Redactform frm = new Redactform();
            frm.Show();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Searchform frm = new Searchform();
            frm.Show();
        }

        private void Statisticabutton_Click(object sender, EventArgs e)
        {
            Statisticaform frm = new Statisticaform();
            frm.Show();
        }
    }
}
