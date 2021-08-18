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
        public ListView _listView { get; set; }

        public Form2(ListView listView, String v1, String v2, String v3, String v4)
        {
            _listView = listView;

            InitializeComponent();

            label2.Text = "Venda #" + v1;

            label3.Text = "Data: " + v2;

            label4.Text = "Nome do cliente: " + v3;

            label5.Text = "Total: " + v4;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Produto", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Unitário", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Total", 150, HorizontalAlignment.Left);

            listView1.Items.AddRange((from ListViewItem item in _listView.Items select (ListViewItem)item.Clone()).ToArray());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
