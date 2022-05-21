using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBrigade2
{
    class Menu
    {
        public static void menu(List<Base> brigade)
        {
            bool fl = true;
            int k;
            Console.WriteLine("Здравствуйте, программа готова к работе!");
            while (fl)
            {
                Console.Write("Что требуется сделать?\n1-Загрузить файл для начала работы\n2-Показать базу бригад\n3-Показать список бригад, полностью выполнивших план года\n4-Сформировать отдельный файл бригад, недовыполненных годовой план\n5-Добавить бригаду\n6-Удалить бригаду\n7-Изменить данные бригады\n8-Сформировать файл всех бригад\n0-Завершить программу\n");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 0:
                        {
                            fl = false;
                            Console.WriteLine("Программа завершила работу!");
                            break;
                        }
                    case 1:
                        {
                            string name_file;
                            Console.WriteLine("Введите имя файла в формате имя.txt");
                            name_file = Console.ReadLine();
                            Read_file.read_file(name_file, brigade);                        //Функция чтения данных из файла

                            break;
                        }
                    case 2:
                        {
                            Program.print(brigade);                                         //Функция печати дбазы бригад в консоль
                            break;
                        }
                    case 3:
                        {
                            Program.print_true_plan(brigade);                               //Функция печати бригад в консоль, выполнивших годовой план
                            break;
                        }
                    case 4:
                        {
                            Write_file.write_file_unfulfilled_plan(brigade);
                            break;
                        }
                    case 5:
                        {
                            string mas_brigade;
                            string[] month = { "Январь", "Февраль", "Март",  "Апрель",  "Май",
                            "Июнь",  "Июль",  "Август",  "Сентябрь",  "Октябрь",  "Ноябрь",  "Декабрь", };
                            int[] mas_month = new int[12], mas_fact_month = new int[13];
                            int plan_year, number_brigade;
                            bool FL = true;

                            Console.WriteLine("Введите номер бригады");
                            number_brigade = Convert.ToInt32(Console.ReadLine());

                            foreach (var T in brigade)                                             //Если бригада с таким номером уже существует, то флаг=false и выходим 
                            {
                                if (T.Number_brigade == number_brigade)
                                {
                                    FL = false;
                                    Console.WriteLine("Такая бригада уже существует!");
                                }
                            }

                            if (FL)                                                               //Если бригада не существует, то флаг=true и заполняем данные новой бригады
                            {
                                Console.WriteLine("Введите ФИО бригадира");
                                mas_brigade = Console.ReadLine();

                                Console.WriteLine("Введите информацию по месяцам");
                                for (int i = 0; i < 12; i++)
                                {
                                    Console.Write(month[i]);
                                    Console.Write(": ");
                                    mas_month[i] = Convert.ToInt32(Console.ReadLine());
                                }

                                Console.WriteLine("Введите годовой план");
                                plan_year = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите фактический выпуск продукции");
                                for (int i = 0; i < 12; i++)
                                {
                                    Console.Write(month[i]);
                                    Console.Write(": ");
                                    mas_fact_month[i] = Convert.ToInt32(Console.ReadLine());
                                }

                                Console.WriteLine("Введите фактический годовой план");
                                mas_fact_month[12] = Convert.ToInt32(Console.ReadLine());

                                Base K = new Base(number_brigade, mas_brigade, mas_month, plan_year, mas_fact_month);
                                brigade.Add(K);                                                                         //Добавляем бригаду в конец списка

                                Console.WriteLine("Бригада добавлена!");
                            }
                            break;
                        }
                    case 6:
                        {
                            int number_brigade;
                            bool FL = true;
                            Console.WriteLine("Введите номер бригады");
                            number_brigade = Convert.ToInt32(Console.ReadLine());
                            foreach (var T in brigade)                                                          //Если бригада с таким номером существует, то 
                            {
                                if (T.Number_brigade == number_brigade)
                                {
                                    brigade.Remove(T);                                                          //Удаляем её 
                                    Console.WriteLine("Бригада удалена!");
                                    FL = false;
                                    break;
                                }
                            }
                            if (FL)                                                                             //Если бригада с таким номерос не существует, то 
                            {
                                Console.WriteLine("Такой бригады не существует!");                              //выводим сообщение об этом
                            }
                            break;
                        }
                    case 7:
                        {
                            int number_brigade;
                            string mas_brigade;
                            bool FL = true;
                            Console.WriteLine("Введите номер бригады");
                            number_brigade = Convert.ToInt32(Console.ReadLine());
                            foreach (var T in brigade)                                                          
                            {
                                if (T.Number_brigade == number_brigade)                                        //Если бригада с таким номером существует, то
                                {
                                    Console.WriteLine("Введите новое ФИО бригадира");
                                    mas_brigade = Console.ReadLine();
                                    T.Mas_brigade = mas_brigade;                                               //Изменяем ФИО бригадира
                                    Console.WriteLine("Запись отредактирована!");
                                    FL = false;
                                    break;
                                }
                            }
                            if (FL)                                                                            //Если не существует, то вывод сообщения об этом
                            {
                                Console.WriteLine("Такой бригады не существует!");
                            }
                            break;
                        }
                    case 8:
                        {
                            Write_file.write_file_all_brigades(brigade);
                            break;
                        }
                    default: Console.WriteLine("Введено некорректное значение!"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
