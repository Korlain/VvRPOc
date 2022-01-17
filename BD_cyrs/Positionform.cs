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
    public partial class Positionform : Form
    {
        public Positionform()
        {
            InitializeComponent();
            //Наполнение данными ListBox должностями
            PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet");
            PositionBox.DisplayMember = "Name_Position";
            PositionBox.ValueMember = "Id";
            PositionBox.Enabled = true;
        }

        private void Createlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Datalist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void PositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Name_Position.Text = PositionBox.Text;
        }
        private void Name_Position_TextChanged(object sender, EventArgs e)
        {

        }

        //Кнопки для редактирования должностей(добавления, обновления и удаления)
        private void Create_Position_Click(object sender, EventArgs e)
        {
            BD_class.connect($"INSERT INTO PositionSet VALUES ('{Name_Position.Text}')");
            PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet");
        }
        private void Update_Position_Click(object sender, EventArgs e)
        {
            BD_class.connect($"UPDATE PositionSet SET Name_Position= '{Name_Position.Text}' WHERE Id={PositionBox.SelectedIndex + 1}");
            PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet");
        }
        private void Delete_Position_Click(object sender, EventArgs e)
        {
            BD_class.connect($"DELETE FROM PositionSet WHERE Id={PositionBox.SelectedIndex + 1}");
            PositionBox.DataSource = BD_class.Connec("SELECT * FROM PositionSet");
        }
    }
}
