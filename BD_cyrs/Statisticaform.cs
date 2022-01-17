using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_cyrs;

namespace BD_cyrs
{
    public partial class Statisticaform : Form
    {
        public Statisticaform()
        {
            InitializeComponent();
        }


        private void CompanyCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DepartamentCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void PositionCheck_CheckedChanged(object sender, EventArgs e)
        {
        }


        /*if (Combobox == CompanyBox)
        {

        }
        else if(Combobox)
        PersonalGrid.DataSource = BD_class.Connec("SELECT FIO, Date_of_birth,SNILS,Name_Departments,Name_Company FROM EmployeesSet INNER JOIN DepartmentsSet ON DepartmentsSet.Id = DepartmentsId INNER JOIN CompanySet ON CompanySet.Id = CompanyId");
        CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
        DepartamentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
        PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet");*/

        private void CompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet INNER JOIN DepartmentsSet ON DepartmentsSet.Id = DepartmentsSetId INNER JOIN CompanySet ON CompanySet.Id = CompanyId WHERE CompanySet = CompanySet.Id");
        }

        private void DepartamentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Statistica_Click(object sender, EventArgs e)
        {
            Statistica stat = new Statistica();
            Years.Text = stat.Yearlable().ToString();
        }

        private void Years_Click(object sender, EventArgs e)
        {

        }

        private void Dismissal_Click(object sender, EventArgs e)
        {
            Mails mails = new Mails();
            mails.mailpost("santovskij@mail.ru","Тестовых дел","Тестовый мастер");
        }
    }
}

