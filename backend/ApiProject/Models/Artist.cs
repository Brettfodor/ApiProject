using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Artist
    {
        [Key] int ArtistId { get; set; }
        string Name { get; set; }
        string Image { get; set; }


        public virtual ICollection<Album> Albums { get; set; }
        

        public Artist(int id, string name, string image)
        {
            ArtistId = id;
            Name = name;
            Image = image;
        }
        public Artist()
        {

        }

    }
}
