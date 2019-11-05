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
        public SongRepository(MusicContext context) : base(context)
        {

        }
    }
}
