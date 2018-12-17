using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Episode
    {
        //propert
        public String Story { get; set; }
        public int Season { get; set; }
        public int Year { get; set; }
        public String Title { get; set; }

        public Episode(String story, int season, int year, String title)
        {
            Story = story;
            Season = season;
            Year = year;
            Title = title;
        }
    }
}
