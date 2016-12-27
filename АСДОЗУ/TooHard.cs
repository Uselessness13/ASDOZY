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
    public partial class TooHard : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        public TooHard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Детали.Номер_детали, Название FROM Детали, Склады, Приходы_деталей, Сотрудники WHERE Приходы_деталей.Номер_склада=Склады.Код_склада AND Детали.Номер_детали=Приходы_деталей.Номер_детали AND Склады.Сотрудник_склада="+ int.Parse(sotrudnik.SelectedValue.ToString());
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Детали");
            firstRequest.DataSource = setOfData;
            firstRequest.DataMember = "Детали";
        }

        private void TooHard_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();

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

            sotrudnik.DataSource = data;
            sotrudnik.DisplayMember = "secondpole";
            sotrudnik.ValueMember = "firstpole";
            secondSotrudnik.DataSource = data;
            secondSotrudnik.DisplayMember = "secondpole";
            secondSotrudnik.ValueMember = "firstpole";
            thirdSotrudnik.DataSource = data;
            thirdSotrudnik.DisplayMember = "secondpole";
            thirdSotrudnik.ValueMember = "firstpole";
            resulter2.Close();

            var data3 = new List<Dvapolya>();

            dabse.OleDbCommand com3 = new dabse.OleDbCommand("Select Название_склада, Код_склада FROM Склады", Date_baseone);
            dabse.OleDbDataReader resulter3 = com3.ExecuteReader();

            while (resulter3.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter3[0].ToString().Trim(),
                    firstpole = resulter3[1].ToString().Trim()
                };
                data3.Add(mc);
            }

            third.DataSource = data3;
            third.DisplayMember = "secondpole";
            third.ValueMember = "firstpole";
            resulter3.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT COUNT(Детали.Номер_детали) AS [Количество деталей] FROM Детали, Склады, Приходы_деталей, Сотрудники WHERE Приходы_деталей.Номер_склада=Склады.Код_склада AND Детали.Номер_детали=Приходы_деталей.Номер_детали AND Склады.Сотрудник_склада=" + int.Parse(sotrudnik.SelectedValue.ToString());
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Детали");
            secondRequest.DataSource = setOfData;
            secondRequest.DataMember = "Детали";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //выборка диспетируемых деталей по сотруднику и цеху и сортировкой по цеху
            command.CommandText = "";
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Детали");
            firstRequest.DataSource = setOfData;
            firstRequest.DataMember = "Детали";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
