using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoAppFormations
{
    public class Categorie
    {
        public string Title { get; set; }

        public int Count { get; set; }

        public string Desc { get; set; }

        public string Image { get; set; }

        public Categorie(string title, int count, string desc, string image)
        {
            Title = title;
            Count = count;
            Desc = desc;
            Image = image;
        }
    }
}
