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
    public partial class Form1 : Form
    {
        dabse.OleDbConnection connection = new dabse.OleDbConnection("Data Source=\"ДОУ.mdb\";User " + "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();

        }
    }
}
