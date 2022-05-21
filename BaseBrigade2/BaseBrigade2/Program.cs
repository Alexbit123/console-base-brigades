using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBrigade2
{
    class Program
    {
        static void Main(string[] args)                                //Точка входа (главная функция)
        {
            List<Base> brigade = new List<Base>();
            Menu.menu(brigade);
        }

        public static void print(List<Base> brigade)                   //Функция печати базы бригад в консоль
        {
            string[] month = { "Январь", "Февраль", "Март",  "Апрель",  "Май",
        "Июнь",  "Июль",  "Август",  "Сентябрь",  "Октябрь",  "Ноябрь",  "Декабрь", };
            foreach (var T in brigade)
            { 
                Console.WriteLine($"Номер бригады: {T.Number_brigade}     ФИО бригадира: {T.Mas_brigade}");
                Console.WriteLine("{0,-40}{1,-40}", "Информация по месяцам года:", "Фактический выпуск продукции:");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", month[i], T.mas_info_month_and_year[i], month[i], T.mas_fact_info_month_and_year[i]);
                }
                Console.WriteLine("{0,-11}{1,-29}{2,-23}{3,-20}\n", "План года:", T.Plan_of_the_year, "Фактический план года:", T.mas_fact_info_month_and_year[12]);
            }
        }

        public static void print_true_plan(List<Base> brigade)                     //Функция печати бригад, выполнивших годовой план
        {
            foreach (var T in brigade)
            {
                if (T.Plan_of_the_year == T.mas_fact_info_month_and_year[12])
                {
                    Console.WriteLine($"Номер бригады: {T.Number_brigade}     ФИО бригадира: {T.Mas_brigade}");
                }
            }
        }
    }
}
