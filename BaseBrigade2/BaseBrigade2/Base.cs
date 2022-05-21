using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBrigade2
{
    class Base
    {
        private int number_brigade;
        private string mas_brigade;
        public int[] mas_info_month_and_year = new int[12];
        private int plan_of_the_year;
        public int[] mas_fact_info_month_and_year = new int[13];

        public Base()
        {

        }

        public Base(int number_brigade, string mas_brigade, int[] mas_info_month_and_year, int plan_of_the_year, int[] mas_fact_info_month_and_year)
        {
            this.number_brigade = number_brigade;
            this.mas_brigade = mas_brigade;
            this.plan_of_the_year = plan_of_the_year;
            for (int i = 0; i < 12; i++)
            {
                this.mas_info_month_and_year[i] = mas_info_month_and_year[i];
            }

            for (int i = 0; i < 13; i++)
            {
                this.mas_fact_info_month_and_year[i] = mas_fact_info_month_and_year[i];
            }

        }
        public int Number_brigade
        {
            get => number_brigade;
            set  => number_brigade = value;
        }
        public string Mas_brigade
        {
            get => mas_brigade;
            set => mas_brigade = value;
        }

        /*
        public int this[int index]
        {
            get => mas_info_month_and_year[index];
            set => mas_info_month_and_year[index] = value;
        }
        */
        public int Plan_of_the_year
        {
            get => plan_of_the_year;
            set => plan_of_the_year = value;
        }

        /*
        public int this[int index]
        {
            get => mas_fact_info_month_and_year[index];
            set => mas_fact_info_month_and_year[index] = value;
        }
        */

    }
}
