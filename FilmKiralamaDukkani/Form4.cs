using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FilmKiralamaDukkani
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form4_FormClosed);

            FilmDukkani filmDukkani = new FilmDukkani();
            filmDukkani.addColumns(dataGridView1);
            filmDukkani.loadTable(dataGridView1);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRowsCount = dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => Convert.ToBoolean(row.Cells["checkBoxColumn"].Value));

            this.Hide();
            Form7 form7 = new Form7(selectedRowsCount);
            form7.Button1Clicked += Form7_Button1Clicked;
            form7.Show();

        }

        private void Form7_Button1Clicked(object sender, EventArgs e)
        {
            KiralananFilm kiralananFilm = new KiralananFilm();
            kiralananFilm.rentFilms(dataGridView1);
        }
    }
}
