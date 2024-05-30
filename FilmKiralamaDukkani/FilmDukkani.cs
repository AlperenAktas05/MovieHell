using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaDukkani
{
    internal class FilmDukkani
    {
        public string owner { get; set; }
        public string name { get; set; }

        public void addColumns(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Film Adı", "Film Adı");
            dataGridView1.Columns.Add("Film Türü", "Film Türü");
            dataGridView1.Columns.Add("Film Süresi", "Film Süresi");
            dataGridView1.Columns.Add("IMDB Puanı", "IMDB Puanı");
            dataGridView1.Columns.Add("Yayınlanma Tarihi", "Yayınlanma Tarihi");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seç";
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        public void loadTable(DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();

                string path = "films.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] filmInfo = line.Split(',');

                            dataGridView1.Rows.Add(filmInfo[0], filmInfo[1], filmInfo[2], filmInfo[3], filmInfo[4], false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void addColumns2(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Film Adı", "Film Adı");
            dataGridView1.Columns.Add("Film Türü", "Film Türü");
            dataGridView1.Columns.Add("Film Süresi", "Film Süresi");
            dataGridView1.Columns.Add("IMDB Puanı", "IMDB Puanı");
            dataGridView1.Columns.Add("Yayınlanma Tarihi", "Yayınlanma Tarihi");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seç";
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        public void loadTable2(DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();

                string path = "rented_films.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] rentedFilmInfo = line.Split(',');

                            if (rentedFilmInfo[0] == Kisi.Email)
                            {
                                dataGridView1.Rows.Add(rentedFilmInfo[1], rentedFilmInfo[2], rentedFilmInfo[3], rentedFilmInfo[4], rentedFilmInfo[5], false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void loadTable3(DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();

                string path = "users.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] userInfo = line.Split(',');

                            dataGridView1.Rows.Add(userInfo[0], userInfo[1], userInfo[2]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void loadTable4(DataGridView dataGridView1) 
        {
            try
            {
                dataGridView1.Rows.Clear();

                string path = "films.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] filmInfo = line.Split(',');

                            dataGridView1.Rows.Add(filmInfo[0], filmInfo[1], filmInfo[2], filmInfo[3], filmInfo[4]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void addColumns3(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Film Sahibi", "Film Sahibi");
            dataGridView1.Columns.Add("Film Adı", "Film Adı");
            dataGridView1.Columns.Add("Film Türü", "Film Türü");
            dataGridView1.Columns.Add("Film Süresi", "Film Süresi");
            dataGridView1.Columns.Add("IMDB Puanı", "IMDB Puanı");
            dataGridView1.Columns.Add("Yayınlanma Tarihi", "Yayınlanma Tarihi");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Seç";
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        public void loadTable5(DataGridView dataGridView1) 
        {
            try
            {
                dataGridView1.Rows.Clear();

                string path = "rented_films.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] rentedFilmInfo = line.Split(',');

                            dataGridView1.Rows.Add(rentedFilmInfo[0], rentedFilmInfo[1], rentedFilmInfo[2], rentedFilmInfo[3], rentedFilmInfo[4], rentedFilmInfo[5], false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
