using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaseBrigade2
{
    class Read_file
    {
        public static void read_file(string name_file, List<Base> brigade)
        {
            brigade.Clear();

            string line, name_brigadier;
            string[] lines;
            int[] mas_month = new int[12], mas_fact_month = new int[13];
            int plan_year, number_brigade;
            StreamReader sr = new StreamReader(name_file);

            do
            {
                line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                number_brigade = Convert.ToInt32(line);
                line = sr.ReadLine();
                name_brigadier = line;
                line = sr.ReadLine();
                lines = line.Split(' ');
                for (int i = 0; i < 12; i++)
                {
                    mas_month[i] = Convert.ToInt32(lines[i]);
                }
                line = sr.ReadLine();
                plan_year = Convert.ToInt32(line);
                line = sr.ReadLine();
                lines = line.Split(' ');
                for (int i = 0; i < 13; i++)
                {
                    mas_fact_month[i] = Convert.ToInt32(lines[i]);
                }
                Base K = new Base(number_brigade, name_brigadier, mas_month, plan_year, mas_fact_month);
                brigade.Add(K);
            } while (line != null);

                sr.Close();
            Console.WriteLine("Файл успешно загружен!");

        }
    }
}
