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
            Film film = new Film();

            film.name = textBox1.Text;
            film.category = textBox2.Text;
            film.duration = textBox3.Text;
            film.imdb = textBox4.Text;
            film.date = textBox5.Text;
          
            film.addFilm();

            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
