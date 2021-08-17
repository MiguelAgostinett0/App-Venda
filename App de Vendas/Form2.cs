using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Vendas
{
    public partial class Form2 : Form
    {
        public Form2(String v1, String v2, String v3, String v4, String v5)
        { 

            InitializeComponent();


            label2.Text = "Venda #" + v1;

            label3.Text = "Data: " + v2;

            label4.Text = "Nome do cliente: " + v3;

            label5.Text = "Total: " + v4;

            listView1.Text = v5;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
