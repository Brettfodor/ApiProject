using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }

        
        public virtual Album Album { get; set; }
        public int AlbumID { get; set; }

        public Song(int id, string title, string link, string time, int albumId, string image)
        {
            ID = id;
            Title = title;
            Link = link;
            Time = time;
            AlbumID = albumId;
            Image = image;

        }
        public Song()
        {

        }


    }
}
