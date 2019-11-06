using ApiProject.Context;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Repositories
{
    public class ArtistRepository : Repository<Artist>, IRepository<Artist>
    {
        public ArtistRepository(MusicContext context) : base(context)
        {

        }
    }
}
