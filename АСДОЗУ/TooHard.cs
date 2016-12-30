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
using wooord = Microsoft.Office.Interop.Word;


namespace АСДОЗУ
{
    public partial class Запросы : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=ДОУ.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        public Запросы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT DISTINCT Детали.Номер_детали, Название FROM Детали, Склады, Приходы_деталей, Сотрудники WHERE Приходы_деталей.Номер_склада=Склады.Код_склада AND Детали.Номер_детали=Приходы_деталей.Номер_детали AND Склады.Сотрудник_склада="+ int.Parse(sotrudnik.SelectedValue.ToString());
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

            sklad4.DataSource = data3;
            sklad4.DisplayMember = "secondpole";
            sklad4.ValueMember = "firstpole";

            fifthcklad.DataSource = data3;
            fifthcklad.DisplayMember = "secondpole";
            fifthcklad.ValueMember = "firstpole";

            thirdSklad.DataSource = data3;
            thirdSklad.DisplayMember = "secondpole";
            thirdSklad.ValueMember = "firstpole";
            resulter3.Close();

            var data2 = new List<Dvapolya>();

            dabse.OleDbCommand com5 = new dabse.OleDbCommand("Select Название_цеха, Код_цеха FROM Цеха", Date_baseone);
            dabse.OleDbDataReader resulter5 = com5.ExecuteReader();

            while (resulter5.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter5[0].ToString().Trim(),
                    firstpole = resulter5[1].ToString().Trim()
                };
                data2.Add(mc);
            }
            fifthceh.DataSource = data2;
            fifthceh.DisplayMember = "secondpole";
            fifthceh.ValueMember = "firstpole";
            ceh4.DataSource = data2;
            ceh4.DisplayMember = "secondpole";
            ceh4.ValueMember = "firstpole";
            thirdCeh.DataSource = data2;
            thirdCeh.DisplayMember = "secondpole";
            thirdCeh.ValueMember = "firstpole";
            resulter5.Close();

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
            command.CommandText = "SELECT  Детали.Номер_детали, Детали.Название FROM Диспетчирование, Детали, Склады, Приходы_деталей, Сотрудники, Цеха WHERE Приходы_деталей.Номер_склада=Склады.Код_склада AND Склады.Код_склада=" + int.Parse(thirdSklad.SelectedValue.ToString()) + " AND Детали.Номер_детали=Приходы_деталей.Номер_детали AND Склады.Сотрудник_склада=" + int.Parse(thirdSotrudnik.SelectedValue.ToString()) + " AND Диспетчирование.Код_склада=Склады.Код_склада AND Диспетчирование.Код_цеха=" + int.Parse(thirdCeh.SelectedValue.ToString()) + " AND Диспетчирование.Код_цеха=Цеха.Код_цеха AND Цеха.Сотрудник_цеха=" + int.Parse(thirdSotrudnik.SelectedValue.ToString()) + " ORDER BY Цеха.Код_цеха";
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Детали");
            thirdRequest.DataSource = setOfData;
            thirdRequest.DataMember = "Детали";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Детали.Номер_детали, Детали.Название FROM Детали, Склады, Приходы_деталей WHERE Приходы_деталей.Номер_склада=Склады.Код_склада AND Склады.Код_склада=" + int.Parse(sklad4.SelectedValue.ToString()) + " AND Детали.Номер_детали=Приходы_деталей.Номер_детали";
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Детали");
            request4.DataSource = setOfData;
            request4.DataMember = "Детали";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Продукты.Номер_продукта, Продукты.Название_продукта FROM Продукты, Цеха, Продукты_цеха WHERE Продукты.Номер_продукта=Продукты_цеха.Номер_продукта AND Цеха.Код_цеха=Продукты_цеха.Номер_цеха AND Цеха.Код_цеха=" + int.Parse(sklad4.SelectedValue.ToString());
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Цеха");
            request4.DataSource = setOfData;
            request4.DataMember = "Цеха";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT AVG(Приходы_деталей.Количество) AS [Среднее количество] FROM Приходы_деталей, Склады WHERE Склады.Код_склада=Приходы_деталей.Номер_склада AND Склады.Код_склада=" + int.Parse(fifthcklad.SelectedValue.ToString());
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Склады");
            fifth.DataSource = setOfData;
            fifth.DataMember = "Склады";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT AVG(Диспетчирование.Количество) AS [Среднее количество] FROM Диспетчирование, Цеха WHERE Цеха.Код_цеха=Диспетчирование.Код_цеха AND Цеха.Код_цеха=" + int.Parse(fifthceh.SelectedValue.ToString());
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter(command.CommandText, Date_baseone);
            adapter.Fill(setOfData, "Диспетчирование");
            fifth.DataSource = setOfData;
            fifth.DataMember = "Диспетчирование";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Продукты.Номер_продукта, Продукты.Название_продукта, Продукты.Описание_продукта FROM Продукты, Цеха, Продукты_цеха WHERE Продукты.Номер_продукта=Продукты_цеха.Номер_продукта AND Цеха.Код_цеха=Продукты_цеха.Номер_цеха AND Цеха.Код_цеха=" + int.Parse(ceh4.SelectedValue.ToString());
            command.Connection = Date_baseone;
            String number;
            String name;
            String description;
            List<String> one = new List<String>();
            List<String> two = new List<String>();
            List<String> three = new List<String>();

            dabse.OleDbDataReader result = command.ExecuteReader();
            wooord.Application app = new wooord.Application();
            Object missing = Type.Missing;
            app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            wooord.Document docec = app.ActiveDocument;
            wooord.Range range = docec.Range(Type.Missing, Type.Missing);

            while (result.Read())
            {
                number = result[1].ToString();
                name = result[0].ToString();
                description = result[0].ToString();

                one.Add(number);
                two.Add(name);
                three.Add(description);
            }

            int len = one.Count;

            range.ParagraphFormat.Alignment = wooord.WdParagraphAlignment.wdAlignParagraphCenter;
            range.Text = "Детали, ушедшие в " + ceh4.SelectedItem + " цех";
            docec.Paragraphs.Add(range);
            docec.Tables.Add(range, len + 1, 3, ref missing, ref missing);
            docec.Tables[1].Cell(1, 1).Range.Text = "Номер продукта";
            docec.Tables[1].Cell(1, 2).Range.Text = "Название";
            docec.Tables[1].Cell(1, 3).Range.Text = "Описание";
            for (int i = 0; i < len; i++)
            {
                docec.Tables[1].Cell(i + 2, 1).Range.Text = two[i];
                docec.Tables[1].Cell(i + 2, 2).Range.Text = one[i];
                docec.Tables[1].Cell(i + 2, 3).Range.Text = three[i];
            }

            wooord.Border[] bords = new wooord.Border[6];

            wooord.Table table = docec.Tables[docec.Tables.Count];

            bords[0] = table.Borders[wooord.WdBorderType.wdBorderLeft];
            bords[1] = table.Borders[wooord.WdBorderType.wdBorderRight];
            bords[2] = table.Borders[wooord.WdBorderType.wdBorderTop];
            bords[3] = table.Borders[wooord.WdBorderType.wdBorderBottom];
            bords[4] = table.Borders[wooord.WdBorderType.wdBorderVertical];
            bords[5] = table.Borders[wooord.WdBorderType.wdBorderHorizontal];

            foreach (wooord.Border border in bords)
            {
                border.LineStyle = wooord.WdLineStyle.wdLineStyleSingle;
                border.Color = wooord.WdColor.wdColorBlack;
            }
            app.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT Детали.Номер_детали, Детали.Название, Детали.Описание_детали FROM Детали, Склады, Приходы_деталей WHERE Детали.Номер_детали=Приходы_деталей.Номер_детали AND Склады.Код_склада=Приходы_деталей.Номер_склада AND Склады.Код_склада=" + int.Parse(sklad4.SelectedValue.ToString());
            command.Connection = Date_baseone;
            String number;
            String name;
            String description;
            List<String> one = new List<String>();
            List<String> two = new List<String>();
            List<String> three = new List<String>();

            dabse.OleDbDataReader result = command.ExecuteReader();
            wooord.Application app = new wooord.Application();
            Object missing = Type.Missing;
            app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            wooord.Document docec = app.ActiveDocument;
            wooord.Range range = docec.Range(Type.Missing, Type.Missing);

            while (result.Read())
            {
                number = result[1].ToString();
                name = result[0].ToString();
                description = result[2].ToString();

                one.Add(number);
                two.Add(name);
                three.Add(description);
            }

            int len = one.Count;

            range.ParagraphFormat.Alignment = wooord.WdParagraphAlignment.wdAlignParagraphCenter;
            range.Text = "Детали, прибывшие в " + sklad4.SelectedItem + " склад";
            docec.Paragraphs.Add(range);
            docec.Paragraphs.Add();
            docec.Tables.Add(range, len + 1, 3, ref missing, ref missing);
            docec.Tables[1].Cell(1, 1).Range.Text = "Номер продукта";
            docec.Tables[1].Cell(1, 2).Range.Text = "Название";
            docec.Tables[1].Cell(1, 3).Range.Text = "Описание";
            for (int i = 0; i < len; i++)
            {
                docec.Tables[1].Cell(i + 2, 1).Range.Text = two[i];
                docec.Tables[1].Cell(i + 2, 2).Range.Text = one[i];
                docec.Tables[1].Cell(i + 2, 3).Range.Text = three[i];
            }

            wooord.Border[] bords = new wooord.Border[6];

            wooord.Table table = docec.Tables[docec.Tables.Count];

            bords[0] = table.Borders[wooord.WdBorderType.wdBorderLeft];
            bords[1] = table.Borders[wooord.WdBorderType.wdBorderRight];
            bords[2] = table.Borders[wooord.WdBorderType.wdBorderTop];
            bords[3] = table.Borders[wooord.WdBorderType.wdBorderBottom];
            bords[4] = table.Borders[wooord.WdBorderType.wdBorderVertical];
            bords[5] = table.Borders[wooord.WdBorderType.wdBorderHorizontal];

            foreach (wooord.Border border in bords)
            {
                border.LineStyle = wooord.WdLineStyle.wdLineStyleSingle;
                border.Color = wooord.WdColor.wdColorBlack;
            }
            app.Visible = true;
        }
    }
}
