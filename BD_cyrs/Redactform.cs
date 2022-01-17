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
    public partial class Redactform : Form
    {
        public Redactform()
        {
            InitializeComponent();
        }

        private void Companybutton_Click(object sender, EventArgs e)
        {
            CompanyForm frm = new CompanyForm();
            frm.Show();
        }

        private void Personalbutton_Click(object sender, EventArgs e)
        {
            PersonalForm frm = new PersonalForm();
            frm.Show();
        }

        private void Positionbutton_Click(object sender, EventArgs e)
        {
            Positionform frm = new Positionform();
            frm.Show();
        }
    }
}
