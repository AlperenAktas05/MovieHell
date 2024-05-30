using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FilmKiralamaDukkani
{
    public static class Kisi
    {
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }

        public static void Register(string name, string email, string password)
        { 
            string path = "users.txt";
            string userInfo = $"{name},{email},{password}";

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(userInfo);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool Login(string email, string password)
        {
            string path = "users.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string lines = sr.ReadToEnd();
                    string[] linesArray = lines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    foreach (string line in linesArray)
                    {
                        string[] userInfo = line.Split(',');

                        if (userInfo[1] == email && userInfo[2] == password)
                        {
                            Kisi.Name = userInfo[0];
                            Kisi.Email = userInfo[1];
                            Kisi.Password = userInfo[2];

                            return true;
                        }                       
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
