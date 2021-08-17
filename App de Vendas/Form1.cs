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
    public partial class Form1 : Form
    {
        double newtotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Produto",150, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Unitário", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Total", 150, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double ttl;

            if (textBox4.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Preencha o produto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox5.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Preencha a quantidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox6.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Preencha o valor de unidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lit = new ListViewItem(textBox4.Text.Trim());
            lit.SubItems.Add(textBox5.Text.Trim());
            lit.SubItems.Add(textBox6.Text.Trim());

            n1 = Convert.ToDouble(textBox5.Text);
            n2 = Convert.ToDouble(textBox6.Text);

            ttl = n1 * n2;
            lit.SubItems.Add(Convert.ToString(ttl));

            Convert.ToDouble(newtotal);
            newtotal = ttl + newtotal;

            listView1.Items.Add(lit);

            label9.Text = "R$ " + Convert.ToString(newtotal);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            listView1.Items.Clear();
            label9.Text = "R$ 00";
            newtotal = 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {          
            Form2 form2 = new Form2(textBox1.Text, textBox2.Text, textBox3.Text, label9.Text, listView1.Items);
            form2.ShowDialog();
        }
    }
}
