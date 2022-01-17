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
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
            //Наполнение DataGrid данными о персонале
            grid();
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
            personalBox.DataSource = BD_class.Connec($"SELECT * FROM PositionSet");
            personalBox.DisplayMember = "Name_Position";
            personalBox.ValueMember = "Id";
            personalBox.Enabled = true;

        }

        private void PersonalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonalGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void personalBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void Departament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SNILS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            PersonalGrid.DataSource = BD_class.Connec("SELECT FIO, Date_of_birth,SNILS,Name_Departments,Name_Company,Wage_rate,Date_of_hiring,Date_of_dismissal FROM EmployeesSet " +
                " INNER JOIN DepartmentsSet ON DepartmentsSet.Id = DepartmentsId " +
                " INNER JOIN CompanySet ON CompanySet.Id = CompanyId " +
                " INNER JOIN SenioritySet ON EmployeesSet.Id = EmployeesId" +
                $" INNER JOIN PositionSet ON PositionSet.Id = PositionId WHERE SNILS = '{SNILS.Text}'");;
        }

        //Кнопки для редактирования сотрудников(добавления, обновления и удаления)
        private void Create_Personal_Click(object sender, EventArgs e)
        {
            BD_class.connect($"INSERT INTO EmployeesSet VALUES ('{FIO.Text}','{Data_birth.Value.Date}','{SNILS.Text}',{Departament.SelectedValue},'{Mail.Text}')");
            string lisint = BD_class.Connec($"SELECT Id FROM EmployeesSet WHERE SNILS = '{SNILS.Text}'").Rows[0][0].ToString();
            int SNIL = int.Parse(lisint);
            if (DateEnd.Enabled == true)
            {
                BD_class.connect($"INSERT INTO SenioritySet VALUES ('{DateStart.Value.Date}','{DateEnd.Value.Date}',{float.Parse(Wage_rate.Text)},{SNIL},{personalBox.SelectedValue},'{Mail.Text}')");
                
            }
            else
            {
                BD_class.connect($"INSERT INTO SenioritySet VALUES ('{DateStart.Value.Date}', NULL ,{float.Parse(Wage_rate.Text)},{SNIL},{personalBox.SelectedValue})");
                Mails create = new Mails();
                create.mailpost($"{Mail.Text}", $"Вы приняты на работу в {CompanyBox.Text} в отдел {Departament.Text} на должность {personalBox.Text} с {DateStart.Value.Date.Day}.{DateStart.Value.Month}.{DateStart.Value.Date.Year}.", "Принятие на работу");
            }

            update_box();
        }
        private void Update_Personal_Click(object sender, EventArgs e)
        {
            BD_class.connect($"UPDATE EmployeesSet SET FIO = '{FIO.Text}', Date_of_birth = '{Data_birth.Value}', DepartmentsId = {Departament.SelectedValue}, Mail = '{Mail.Text}' WHERE SNILS='{SNILS.Text}'");
            string lisint = BD_class.Connec($"SELECT Id FROM EmployeesSet WHERE SNILS = '{SNILS.Text}'").Rows[0][0].ToString();
            int SNIL = int.Parse(lisint);
            if (DateEnd.Enabled == true)
            {
                BD_class.connect($"UPDATE SenioritySet SET Date_of_hiring = '{DateStart.Value.Date}', Date_of_dismissal = '{DateEnd.Value.Date}', Wage_rate = {float.Parse(Wage_rate.Text)} WHERE EmployeesId={SNIL}");
                Mails create = new Mails();
                create.mailpost($"{Mail.Text}", $"Вы уволены из {CompanyBox.Text} отдела {Departament.Text} с должности {personalBox.Text} с {DateEnd.Value.Date.Day}.{DateEnd.Value.Month}.{DateEnd.Value.Date.Year}.", "Увольнение с работы");
            } 
            else
            {
                BD_class.connect($"UPDATE SenioritySet SET Date_of_hiring = '{DateStart.Value.Date}', Wage_rate = {float.Parse(Wage_rate.Text)} WHERE EmployeesId={SNIL}");
            }
            update_box();
        }
        private void Delete_Personal_Click(object sender, EventArgs e)
        {
            BD_class.connect($"DELETE FROM EmployeesSet WHERE SNILS='{SNILS.Text}'");
            update_box();
        }
        private void update_box()
        {
            grid();
        }

        private void grid()
        {
            PersonalGrid.DataSource = BD_class.Connec("SELECT FIO, Date_of_birth,SNILS, Mail ," +
                "Name_Departments,Name_Company,Wage_rate,Date_of_hiring,Date_of_dismissal FROM EmployeesSet " +
                " INNER JOIN DepartmentsSet ON DepartmentsSet.Id = DepartmentsId " +
                " INNER JOIN CompanySet ON CompanySet.Id = CompanyId " +
                " INNER JOIN SenioritySet ON EmployeesSet.Id = EmployeesId" +
                " INNER JOIN PositionSet ON PositionSet.Id = PositionId");
        }
        private void DateStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dismissal_CheckedChanged(object sender, EventArgs e)
        {
            if (Dismissal.Checked == true)
            {
                DateEnd.Enabled = true;
            }
            else 
            {
                DateEnd.Enabled = false;
            }
        }

        private void Wage_rate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
