using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Album
    {
        public int ID { get; set;}
        public string Title { get; set; }
        public string Image { get; set;  }
        public string Label { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
        public virtual Artist Artist { get; set;}
        public int ArtistID { get; set; }

        public Album(int id, string title, string image, string label, int artistId)
        {
            ID = id;
            Title = title;
            Image = image;
            Label = label;
            ArtistID = artistId;
        }
        public Album()
        {
        }
    }
}
