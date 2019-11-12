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

        private IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        // GET api/Albums
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumRepo.GetAll();
        }

        // GET api/Albums/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumRepo.GetById(id);
        }

        // POST api/Albums
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album album)
        {
            albumRepo.Create(album);
            return albumRepo.GetAll();
        }

        // PUT api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<Album> Put([FromBody] Album album)
        {
            albumRepo.Update(album);
            return albumRepo.GetAll();
        }

        // DELETE api/Albums/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            var album = albumRepo.GetById(id);
            albumRepo.Delete(album);
            return albumRepo.GetAll();
        }
    }
}