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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form10_FormClosed);
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            FilmDukkani filmDukkani = new FilmDukkani();
            filmDukkani.addColumns3(dataGridView1);
            filmDukkani.loadTable5(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KiralananFilm kiralananFilm = new KiralananFilm();
            kiralananFilm.returnFilms2(dataGridView1);
        }
    }
}
