using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Doctor
    {
        public int Ordinal { get; set; }
        public String Actor { get; set; }
        public int Series { get; set; }
        public int Age { get; set; }
        public int Debut { get; set; }


        public Doctor(int ordinal, String actor, int series, int age, int debut)
        {
            Ordinal = ordinal;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
        }


    }
}
