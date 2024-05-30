using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaDukkani
{
    public partial class Form7 : Form
    {
        public event EventHandler Button1Clicked;
        private int selectedRowsCount;
        public Form7(int selectedRowsCount)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form7_FormClosed);
            this.selectedRowsCount = selectedRowsCount;
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            Button1Clicked.Invoke(this, EventArgs.Empty);
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string day = textBox1.Text;
            int price = 50 * int.Parse(day) * selectedRowsCount;
            label8.Text = $"Ücret: {price}";
            label8.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
