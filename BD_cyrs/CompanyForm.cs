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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
            //Наполнение данными ListBox отделений
            CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
            CompanyBox.DisplayMember = "Name_Company";
            CompanyBox.ValueMember = "Id";
            CompanyBox.Enabled = true;
            //И отделов
            DepartmentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
            DepartmentBox.DisplayMember = "Name_Departments";
            DepartmentBox.ValueMember = "Id";
            DepartmentBox.Enabled = true;
        }
        //Обновление отделов при изменении отделений
        private void CompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentBox.Text = "";
            if (CompanyBox.Enabled == true)
            {
                DepartmentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
            }
        }

        private void Name_Company_TextChanged(object sender, EventArgs e)
        {
        }
        //Кнопки для редактирования отделений(добавления, обновления и удаления)
        private void Create_Company_Click(object sender, EventArgs e)
        {
            BD_class.connect($"INSERT INTO CompanySet VALUES ('{Name_Company.Text}')");
            CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
        }
        private void Update_Company_Click(object sender, EventArgs e)
        {
            BD_class.connect($"UPDATE CompanySet SET Name_Company= '{Name_Company.Text}' WHERE Id={CompanyBox.SelectedIndex + 1}");
            CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
        }
        private void Delete_Company_Click(object sender, EventArgs e)
        {
            BD_class.connect($"DELETE FROM CompanySet WHERE Id={CompanyBox.SelectedIndex + 1}");
            CompanyBox.DataSource = BD_class.Connec("SELECT * FROM CompanySet");
        }


        //Кнопки для редактирования отделов(добавления, обновления и удаления)
        private void Create_Department_Click(object sender, EventArgs e)
        {
            BD_class.connect($"INSERT INTO DepartmentsSet VALUES ('{Name_department.Text}',{CompanyBox.SelectedIndex + 1})");
            DepartmentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
        }
        private void Update_Department_Click(object sender, EventArgs e)
        {
            BD_class.connect($"UPDATE DepartmentsSet SET Name_Departments= '{Name_department.Text}' WHERE Id={DepartmentBox.SelectedIndex + 1}");
            DepartmentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
        }
        private void Delete_Department_Click(object sender, EventArgs e)
        {
            BD_class.connect($"DELETE FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedIndex + 1} AND Name_Departments ='{DepartmentBox.Text}'");
            DepartmentBox.DataSource = BD_class.Connec($"SELECT * FROM DepartmentsSet WHERE CompanyId={CompanyBox.SelectedValue}");
        }

        private void DepartmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


