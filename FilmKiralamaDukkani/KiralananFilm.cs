using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaDukkani
{
    internal class KiralananFilm
    {
        public string owner { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string duration { get; set; }
        public string imdb { get; set; }
        public string date { get; set; }

        public void rentFilms(DataGridView dataGridView1)
        {
            var selectedRows = dataGridView1.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToBoolean(row.Cells["Seç"].Value)).ToList();

            try
            {
                string path = "rented_films.txt";

                string[] allLines = File.ReadAllLines("films.txt").Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                var newLines = allLines.ToList();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    foreach (var row in selectedRows)
                    {
                        owner = Kisi.Email;
                        name = row.Cells["Film Adı"].Value.ToString();
                        category = row.Cells["Film Türü"].Value.ToString();
                        duration = row.Cells["Film Süresi"].Value.ToString();
                        imdb = row.Cells["IMDB Puanı"].Value.ToString();
                        date = row.Cells["Yayınlanma Tarihi"].Value.ToString();

                        string rentFilmInfo = $"{owner},{name},{category},{duration},{imdb},{date}";
                        sw.WriteLine(rentFilmInfo);

                        string filmInfo = $"{name},{category},{duration},{imdb},{date}";
                        newLines.Remove(filmInfo);

                        dataGridView1.Rows.Remove(row);

                    }
                }

                File.WriteAllLines("films.txt", newLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void returnFilms(DataGridView dataGridView1)
        {
            var selectedRows = dataGridView1.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToBoolean(row.Cells["Seç"].Value)).ToList();

            try
            {
                string path = "films.txt";

                string[] allLines = File.ReadAllLines("rented_films.txt").Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                var newLines = allLines.ToList();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    foreach (var row in selectedRows)
                    {
                        owner = Kisi.Email;
                        name = row.Cells["Film Adı"].Value.ToString();
                        category = row.Cells["Film Türü"].Value.ToString();
                        duration = row.Cells["Film Süresi"].Value.ToString();
                        imdb = row.Cells["IMDB Puanı"].Value.ToString();
                        date = row.Cells["Yayınlanma Tarihi"].Value.ToString();

                        string filmInfo = $"{name},{category},{duration},{imdb},{date}";
                        sw.WriteLine(filmInfo);

                        string rentedFilmInfo = $"{owner},{name},{category},{duration},{imdb},{date}";
                        newLines.Remove(rentedFilmInfo);

                        dataGridView1.Rows.Remove(row);

                    }
                }

                File.WriteAllLines("rented_films.txt", newLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void returnFilms2(DataGridView dataGridView1)
        {
            var selectedRows = dataGridView1.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToBoolean(row.Cells["Seç"].Value)).ToList();

            try
            {
                string path = "films.txt";

                string[] allLines = File.ReadAllLines("rented_films.txt").Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                var newLines = allLines.ToList();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    foreach (var row in selectedRows)
                    {
                        owner = row.Cells["Film Sahibi"].Value.ToString();
                        name = row.Cells["Film Adı"].Value.ToString();
                        category = row.Cells["Film Türü"].Value.ToString();
                        duration = row.Cells["Film Süresi"].Value.ToString();
                        imdb = row.Cells["IMDB Puanı"].Value.ToString();
                        date = row.Cells["Yayınlanma Tarihi"].Value.ToString();

                        string filmInfo = $"{name},{category},{duration},{imdb},{date}";
                        sw.WriteLine(filmInfo);

                        string rentedFilmInfo = $"{owner},{name},{category},{duration},{imdb},{date}";
                        newLines.Remove(rentedFilmInfo);

                        dataGridView1.Rows.Remove(row);

                    }
                }

                File.WriteAllLines("rented_films.txt", newLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
