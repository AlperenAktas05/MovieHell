using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaDukkani
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form9_FormClosed);
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            FilmDukkani filmDukkani = new FilmDukkani();
            filmDukkani.loadTable4(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

     
    }
}
