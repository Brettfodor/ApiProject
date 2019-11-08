using ApiProject.Context;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Repositories
{
    public class SongRepository : Repository<Song>, IRepository<Song>
    {
        private MusicContext db;

        public SongRepository(MusicContext context) : base(context)
        {

        }
        public IEnumerable<Song> GetByAlbumID(int albumID)
        {
            var songs = db.Songs.Where(p => p.AlbumID == albumID);
            return songs;
        }
    }
}
