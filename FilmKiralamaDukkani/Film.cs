using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FilmKiralamaDukkani
{
    internal class Film
    {
        public string name { get; set; }
        public string category { get; set; }
        public string duration { get; set; }
        public string imdb { get; set; }
        public string date { get; set; }

        public void addFilm(string name, string category, string duration, string imdb, string date)
        {
            this.name = name;
            this.category = category;
            this.duration = duration;
            this.imdb = imdb;
            this.date = date;

            string path = "films.txt";
            string filmInfo = $"{name},{category},{duration},{imdb},{date}";

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(filmInfo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
