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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FilmKiralamaDukkani
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form5_FormClosed);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label6.Text = Kisi.Name;
            label7.Text = Kisi.Email;
            label8.Text = new string('*', Kisi.Password.Length);

            if(Kisi.Email == "aktasalperen0@gmail.com" && Kisi.Password == "alperen05aktas")
            {
                button3.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }

            FilmDukkani filmDukkani = new FilmDukkani();
            filmDukkani.addColumns2(dataGridView1);
            filmDukkani.loadTable2(dataGridView1);
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Göster")
            {
                label8.Text = Kisi.Password;
                button1.Text = "Gizle";
            }
            else if (button1.Text == "Gizle")
            {
                label8.Text = new string('*', Kisi.Password.Length);
                button1.Text = "Göster";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KiralananFilm kiralananFilm = new KiralananFilm();
            kiralananFilm.returnFilms(dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }
    }
}
