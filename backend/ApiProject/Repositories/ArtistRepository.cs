using ApiProject.Context;
using ApiProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Repositories
{
    public class ArtistRepository : Repository<Artist>, IRepository<Artist>
    {
        private DbContext db;
        public ArtistRepository(MusicContext context) : base(context)
        {
            this.db = context;
        }
        public override Artist GetById(int id)
        {
            return db.Set<Artist>().Where(i=> i.ID == id).Include("Albums").FirstOrDefault();
        }

    }
}
