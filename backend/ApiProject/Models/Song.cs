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
        [Key]public int SongId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Time { get; set; }

        
        public virtual Album Album { get; set; }
        [ForeignKey("ID")] public int AlbumID { get; set; }

        public Song(int id, string title, string link, string time,  int albumId)
        {
            SongId = id;
            Title = title;
            Link = link;
            Time = time;
            AlbumID = albumId;  
            
        }
        public Song()
        {

        }


    }
}
