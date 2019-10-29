using System;
using System.Collections.Generic;
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

        public virtual Artist Artist { get; set; }
        public int ArtistID { get; set; }
        public virtual Album Album { get; set; }
        public int AlbumID { get; set; }

        public Song(int id, string title, string link, string time, int artistID, int albumID,)
        {
            ID = id;
            Title = title;
            Link = link;
            Time = time;
            ArtistID = artistID;
            AlbumID = albumID;  
        }


    }
}
