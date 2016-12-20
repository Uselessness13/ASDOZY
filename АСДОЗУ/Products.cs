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
    public partial class Products : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Продукты";
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
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
            command.CommandText = "INSERT INTO Продукты (Название_продукта, Описание_продукта) VALUES (?, ?)";
            command.Parameters.Add("Название_продукта", dabse.OleDbType.VarWChar).Value = name.Text;
            command.Parameters.Add("Описание_продукта", dabse.OleDbType.VarWChar).Value = description.Text;
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
            command.CommandText = "UPDATE Продукты SET Название_продукта = ?, Описание_продукта = ? WHERE (Номер_продукта= ?)";
            command.Parameters.Add("Название_продукта", dabse.OleDbType.VarWChar, 100, "Название_продукта");
            command.Parameters.Add("Описание_продукта", dabse.OleDbType.VarWChar, 500, "Описание_продукта");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Номер_продукта", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Номер_продукта", System.Data.DataRowVersion.Original, null));
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
            command.CommandText = "Delete from " + nameoftable + " where Номер_продукта= ?";
            command.Connection = Date_baseone;
            int shifrec = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show("" + shifrec);
            command.Parameters.Add("Номер_продукта", dabse.OleDbType.Integer, 50).Value = shifrec;
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
