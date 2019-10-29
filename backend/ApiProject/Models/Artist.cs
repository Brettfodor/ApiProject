using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Artist
    {   int ID { get; set; }
        string Name { get; set; }
        string Image { get; set; }


        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        public Artist(int id, string name, string image)
        {
            ID = id;
            Name = name;
            Image = image;
        }

    }
}
