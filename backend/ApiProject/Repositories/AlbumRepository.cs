using ApiProject.Context;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {
        private MusicContext db;
        public AlbumRepository(MusicContext context) : base(context)
        {

        }

        public IEnumerable<Album> GetByArtistID(int artistID)
        {
            var albums = db.Albums.Where(p => p.ArtistID == artistID);
            return albums;
        }
    }
}
