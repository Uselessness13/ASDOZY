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
    public partial class DetailsInProducts : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Детали_в_продуктах";
        public DetailsInProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DetailsInProducts_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;

            var data1 = new List<Dvapolya>();

            dabse.OleDbCommand com = new dabse.OleDbCommand("Select Название, Номер_детали FROM Детали", Date_baseone);
            dabse.OleDbDataReader resulter = com.ExecuteReader();

            while (resulter.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter[0].ToString().Trim(),
                    firstpole = resulter[1].ToString().Trim()
                };
                data1.Add(mc);
            }

            det.DataSource = data1;
            det.DisplayMember = "secondpole";
            det.ValueMember = "firstpole";
            resulter.Close();

            var data2 = new List<Dvapolya>();

            dabse.OleDbCommand com2 = new dabse.OleDbCommand("Select Название_продукта, Номер_продукта FROM Продукты", Date_baseone);
            dabse.OleDbDataReader resulter2 = com2.ExecuteReader();

            while (resulter2.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter2[0].ToString().Trim(),
                    firstpole = resulter2[1].ToString().Trim()
                };
                data2.Add(mc);
            }

            prod.DataSource = data2;
            prod.DisplayMember = "secondpole";
            prod.ValueMember = "firstpole";
            resulter2.Close();

            List<int> kol = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                kol.Add(i);
            }
            kolichestvo.DataSource = kol;
        }

        private void add_Click(object sender, EventArgs e)
        {
            var command = new dabse.OleDbCommand();
            command.CommandText = "INSERT INTO Детали_в_продуктах (Номер_детали, Номер_продукта, Количество) VALUES (?, ?, ?)";
            command.Parameters.Add("Номер_детали", dabse.OleDbType.Integer).Value = int.Parse(det.SelectedValue.ToString());
            command.Parameters.Add("Номер_продукта", dabse.OleDbType.Integer).Value = int.Parse(prod.SelectedValue.ToString());
            command.Parameters.Add("Количество", dabse.OleDbType.Integer).Value = int.Parse(kolichestvo.SelectedValue.ToString());
            command.Connection = Date_baseone;
            command.ExecuteNonQuery();
            MessageBox.Show("Добавлена запись");
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
            command.CommandText = "UPDATE Детали_в_продуктах SET Номер_детали=?, Номер_продукта=?, Количество=? WHERE (id=?)";
            command.Parameters.Add("Номер_детали", dabse.OleDbType.Integer, 50, "Номер_детали");
            command.Parameters.Add("Номер_продукта", dabse.OleDbType.Integer, 50, "Номер_продукта");
            command.Parameters.Add("Количество", dabse.OleDbType.Integer, 50, "Количество");
            command.Parameters.Add(new dabse.OleDbParameter("Original_id", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "id", System.Data.DataRowVersion.Original, null));
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
            command.CommandText = "Delete from " + nameoftable + " where id= ?";
            command.Connection = Date_baseone;
            int shifrec = (int)dataGridView1.CurrentRow.Cells[3].Value;
            MessageBox.Show(shifrec + "");
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

        private void close_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            Close();
        }
    }
}
