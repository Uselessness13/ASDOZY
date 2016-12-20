using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dabse = System.Data.OleDb;

namespace АСДОЗУ
{
    public partial class Stuff : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Сотрудники";
        public Stuff()
        {
            InitializeComponent();
        }

        private void Stuff_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;
        }

        private void add_Click(object sender, EventArgs e)
        {
            command.CommandText = "INSERT INTO Сотрудники (Фамилия, Имя, Отчество) VALUES (?, ?, ?)";
            command.Parameters.Add("Фамилия", dabse.OleDbType.VarWChar).Value = fam.Text;
            command.Parameters.Add("Имя", dabse.OleDbType.VarWChar).Value = imya.Text;
            command.Parameters.Add("Отчество", dabse.OleDbType.VarWChar).Value = otchestvo.Text;
            command.Connection = Date_baseone;
            command.ExecuteNonQuery();

            MessageBox.Show("Добавлена запись");
        }

        private void update_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;
        }

        private void save_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATE Сотрудники SET Фамилия= ?, Имя= ?, Отчество=? WHERE (Номер_сотрудника= ?)";
            command.Parameters.Add("Фамилия", dabse.OleDbType.VarWChar, 50, "Фамилия");
            command.Parameters.Add("Имя", dabse.OleDbType.VarWChar, 50, "Имя");
            command.Parameters.Add("Отчество", dabse.OleDbType.VarWChar, 50, "Отчество");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Номер_Сотрудника", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Номер_сотрудника", System.Data.DataRowVersion.Original, null));
            command.Connection = Date_baseone;
            adapter.UpdateCommand = command;

            try
            {
                int kol = adapter.Update(setOfData, nameoftable);
                MessageBox.Show("Обновлено " + kol + " записей");
            }
            catch (Exception Ситуация_однако)
            {
                MessageBox.Show(Ситуация_однако.Message, "Недоразумение");
            }
        }

        private void deleter_Click(object sender, EventArgs e)
        {
            command.CommandText = "Delete from " + nameoftable + " where Номер_сотрудника= ?";
            command.Connection = Date_baseone;
            int shifrec = (int)dataGridView1.CurrentRow.Cells[0].Value;
            command.Parameters.Add("Номер_сотрудника", dabse.OleDbType.Integer, 50).Value = shifrec;
            int deletedrows = command.ExecuteNonQuery();
            MessageBox.Show("Удалено " + deletedrows + " ззаписей");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            Close();
        }
    }
}
