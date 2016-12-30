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
    public partial class Ceha : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Цеха";
        public Ceha()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand();
            command.CommandText = "INSERT INTO Цеха (Название_цеха, Сотрудник_цеха) VALUES (?, ?)";
            command.Parameters.Add("Название_цеха", dabse.OleDbType.VarWChar).Value = name.Text;
            command.Parameters.Add("Сотрудник_цеха", dabse.OleDbType.Integer).Value = int.Parse(sotr.SelectedValue.ToString());
            command.Connection = Date_baseone;
            command.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
        }

        private void Ceha_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;

            var data = new List<Dvapolya>();

            dabse.OleDbCommand com2 = new dabse.OleDbCommand("Select Фамилия, Имя, Отчество, Номер_сотрудника FROM Сотрудники", Date_baseone);
            dabse.OleDbDataReader resulter2 = com2.ExecuteReader();

            while (resulter2.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter2[0].ToString().Trim() + " " + resulter2[1].ToString().Trim() + " " + resulter2[2].ToString().Trim(),
                    firstpole = resulter2[3].ToString().Trim()
                };
                data.Add(mc);
            }

            sotr.DataSource = data;
            sotr.DisplayMember = "secondpole";
            sotr.ValueMember = "firstpole";
            resulter2.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone);
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand();
            command.CommandText = "UPDATE Цеха SET Название_цеха=?, Сотрудник_цеха=? WHERE (Код_цеха= ?)";
            command.Parameters.Add("Название_цеха", dabse.OleDbType.VarWChar, 150, "Название_цеха");
            command.Parameters.Add("Сотрудник_цеха", dabse.OleDbType.Integer, 50, "Сотрудник_цеха");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Код_цеха", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Код_цеха", System.Data.DataRowVersion.Original, null));
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
            var command = new dabse.OleDbCommand();
            command.CommandText = "Delete from " + nameoftable + " where Код_цеха= ?";
            command.Connection = Date_baseone;
            int shifrec = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show(shifrec+"");
            command.Parameters.Add("Код_цеха", dabse.OleDbType.Integer, 50).Value = shifrec;
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

        private void close_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            Close();
        }
    }
}
