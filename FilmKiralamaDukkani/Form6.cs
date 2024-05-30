using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FilmKiralamaDukkani
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form6_FormClosed);
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string category = textBox2.Text;
            string duration = textBox3.Text;
            string imdb = textBox4.Text;
            string date = textBox5.Text;

            Film film = new Film();
            film.addFilm(name, category, duration, imdb, date);

            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
