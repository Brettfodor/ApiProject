using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }


        public virtual ICollection<Album> Albums { get; set; }
        

        public Artist(int id, string name, string image)
        {
            ID = id;
            Name = name;
            Image = image;
        }
        public Artist()
        {

        }

    }
}
