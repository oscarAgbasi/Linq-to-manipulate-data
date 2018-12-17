using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class DoCtor1
    {
        private int Ordinal { get; set; }
        private String Actor { get; set; }
        private int Series { get; set; }
        private int Age { get; set; }
        private int Debut { get; set; }



        public DoCtor1(int ordinal, String actor, int series, int age, int debut)
        {
            Ordinal = ordinal;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
        }

    }
}
