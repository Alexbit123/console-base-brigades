using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaseBrigade2
{
    class Write_file
    {
        public static void write_file_unfulfilled_plan(List<Base> brigade)
        {
            StreamWriter sw = new StreamWriter("write_file_unfulfilled_plan.txt");

            string[] month = { "Январь", "Февраль", "Март",  "Апрель",  "Май",
            "Июнь",  "Июль",  "Август",  "Сентябрь",  "Октябрь",  "Ноябрь",  "Декабрь", };

            foreach (var T in brigade)
            {
                if (T.Plan_of_the_year - T.mas_fact_info_month_and_year[12] > 0)
                {
                    sw.Write("Номер бригады: "); sw.WriteLine(T.Number_brigade);
                    for (int i = 0; i < 12; i++)
                    {
                        sw.Write(month[i]); sw.Write(": "); sw.WriteLine(T.mas_info_month_and_year[i]);
                    }
                    sw.Write("План недовыполнен на "); sw.WriteLine(T.Plan_of_the_year - T.mas_fact_info_month_and_year[12]); sw.WriteLine();
                }
            }

            sw.Close();
            Console.WriteLine("Файл записан!");
        }

        public static void write_file_all_brigades(List<Base> brigade)
        {
            StreamWriter sw = new StreamWriter("write_file_all_brigades.txt");

            string[] month = { "Январь", "Февраль", "Март",  "Апрель",  "Май",
            "Июнь",  "Июль",  "Август",  "Сентябрь",  "Октябрь",  "Ноябрь",  "Декабрь", };

            foreach (var T in brigade)
            {
                sw.WriteLine($"Номер бригады: {T.Number_brigade}     ФИО бригадира: {T.Mas_brigade}");
                sw.WriteLine("{0,-40}{1,-40}", "Информация по месяцам года:", "Фактический выпуск продукции:");
                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", month[i], T.mas_info_month_and_year[i], month[i], T.mas_fact_info_month_and_year[i]);
                }
                sw.WriteLine("{0,-11}{1,-29}{2,-23}{3,-20}\n", "План года:", T.Plan_of_the_year, "Фактический план года:", T.mas_fact_info_month_and_year[12]);
            }

            sw.Close();
            Console.WriteLine("Файл записан!");
        }

    }
}
