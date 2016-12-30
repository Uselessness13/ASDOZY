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
    public partial class Details : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Детали";
        public Details()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand("INSERT INTO Детали (" + "Название, Описание_детали) VALUES (?, ?)", Date_baseone);
            //command.CommandText = ;
            command.Parameters.Add("Название", dabse.OleDbType.VarWChar).Value = name.Text;
            //name.Text = "";
            command.Parameters.Add("Описание_детали", dabse.OleDbType.VarWChar).Value = description.Text;
            //description.Text = "";
            //command.Connection = Date_baseone;
            command.ExecuteNonQuery();

            MessageBox.Show("Добавлена запись");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            Close();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand("UPDATE Детали SET Название = ?, Описание_детали = ? WHERE (Номер_детали= ?)", Date_baseone);
            
            command.Parameters.Add("Название", dabse.OleDbType.VarWChar, 50, "Название");
            command.Parameters.Add("Описание_детали", dabse.OleDbType.VarWChar, 50, "Описание_детали");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Номер_детали", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Номер_детали", System.Data.DataRowVersion.Original, null));
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

        private void update_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;
        }

        private void deleter_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand("Delete from " + nameoftable + " where Номер_детали = ?", Date_baseone);

            int shifrec = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show(""+shifrec);
            command.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = shifrec;
            try
            {
                int deletedrows = command.ExecuteNonQuery();
                MessageBox.Show("Удалено " + deletedrows + " записей");
            }
            catch (Exception)
            {
                MessageBox.Show("Данную запись нелььзя удалить, так как она связана с другими");
            }
        }
    }
}
