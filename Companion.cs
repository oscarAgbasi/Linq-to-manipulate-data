using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Companion
    {
        public String Name { get; set; }
        public String Actor { get; set; }
        public int Doctor { get; set; }
        public String Debut { get; set; }

        public Companion(String name, String actor, int doctor, String debut)
        {
            Name = name;
            Actor = actor;
            Doctor = doctor;
            Debut = debut;
        }

    }
}
