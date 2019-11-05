using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Models;
using ApiProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        //private static List<string> all = new List<string>()
        //{
        //    "Remodel Bathroom",
        //    "Finish my laser app",
        //    "Do things with kids"
        //};

        private IRepository<Album> AlbumRepo;

        public AlbumController(IRepository<Album> AlbumRepo)
        {
            this.AlbumRepo = AlbumRepo;
        }

        // GET api/Albums
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return AlbumRepo.GetAll();
        }

        // GET api/Albums/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return AlbumRepo.GetById(id);
        }

        // POST api/Albums
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album Album)
        {
            AlbumRepo.Create(Album);
            return AlbumRepo.GetAll();
        }

        // PUT api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<Album> Put([FromBody] Album Album)
        {
            AlbumRepo.Update(Album);
            return AlbumRepo.GetAll();
        }

        // DELETE api/Albums/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            var album = AlbumRepo.GetById(id);
            AlbumRepo.Delete(album);
            return AlbumRepo.GetAll();
        }
    }
}