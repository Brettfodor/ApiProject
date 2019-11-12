using ApiProject.Context;
using ApiProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {
        private DbContext db;
        public AlbumRepository(MusicContext context) : base(context)
        {
            this.db = context;
        }
        public override Album GetById(int id)
        {
            return db.Set<Album>().Where(i => i.ID == id).Include("Songs").FirstOrDefault();
        }
    }
}
