using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АСДОЗУ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
        }

        private void prods_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
            pr.Show();
        }

        private void stuff_Click(object sender, EventArgs e)
        {
            Stuff st = new Stuff();
            st.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ceha ch = new Ceha();
            ch.Show();
        }

        private void sklad_Click(object sender, EventArgs e)
        {
            Skladi sk = new Skladi();
            sk.Show();
        }

        private void comes_Click(object sender, EventArgs e)
        {
            DetailComing dc = new DetailComing();
            dc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsOfCeh poc = new ProductsOfCeh();
            poc.Show();
        }

        private void detinprods_Click(object sender, EventArgs e)
        {
            DetailsInProducts dip = new DetailsInProducts();
            dip.Show();
        }

        private void dispthirovanie_Click(object sender, EventArgs e)
        {
            Dispetchirovanie d = new Dispetchirovanie();
            d.Show();
        }
    }
}
