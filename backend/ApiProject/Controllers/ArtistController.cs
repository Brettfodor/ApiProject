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
    [Route("api/artists")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
  
        private IRepository<Artist> artistRepo;

        public ArtistController(IRepository<Artist> artistRepo)
        {
            this.artistRepo = artistRepo;
        }

        // GET api/Artists
        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            return artistRepo.GetAll();
        }

        // GET api/Artists/5
        [HttpGet("{id}")]
        public Artist Get(int id)
        {
            return artistRepo.GetByArtistId(id);
        }

        // POST api/Artists
        [HttpPost]
        public IEnumerable<Artist> Post([FromBody] Artist artist)
        {
            artistRepo.Create(artist);
            return artistRepo.GetAll();
        }

        // PUT api/Artists/5
        [HttpPut("{id}")]
        public IEnumerable<Artist> Put([FromBody] Artist artist)
        {
            artistRepo.Update(artist);
            return artistRepo.GetAll();
        }

        // DELETE api/Artists/5
        [HttpDelete("{id}")]
        public IEnumerable<Artist> Delete(int id)
        {
            var artist = artistRepo.GetByArtistId(id);
            artistRepo.Delete(artist);
            return artistRepo.GetAll();
        }
    }
}