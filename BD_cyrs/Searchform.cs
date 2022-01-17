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
using Microsoft.Data.SqlClient;

namespace BD_cyrs
{
    public partial class Searchform : Form
    {
        public Searchform()
        {
            InitializeComponent();
            //Наполнение данными ComboBox отделений
            CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
            CompanyBox.DisplayMember = "Name_Company";
            CompanyBox.ValueMember = "Id";
            CompanyBox.Enabled = true;
            //Наполнение данными ComboBox отделов
            Departament.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
            Departament.DisplayMember = "Name_Departments";
            Departament.ValueMember = "Id";
            Departament.Enabled = true;
        }

        //Обновление списка отделов при изменении отделения в ComboBox
        private void CompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departament.Text = "";
            if (CompanyBox.Enabled == true)
            {
                Departament.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={ CompanyBox.SelectedValue}");
            }
            
        }

        private void Personal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Departament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Кнопка поиска сотрудников из определённого отдела определённого отделений
        private void Search_Click(object sender, EventArgs e)
        {
                Personal.DataSource = BD_class.Connec($"SELECT FIO, Date_of_birth,SNILS,Name_Departments,Name_Company FROM EmployeesSet INNER JOIN DepartmentsSet ON DepartmentsSet.Id = DepartmentsId INNER JOIN CompanySet ON CompanySet.Id = CompanyId WHERE DepartmentsId={Departament.SelectedValue} AND CompanyId={CompanyBox.SelectedValue}");
        }
    }
    
}
