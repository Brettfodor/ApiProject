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
        //private static List<string> all = new List<string>()
        //{
        //    "Remodel Bathroom",
        //    "Finish my laser app",
        //    "Do things with kids"
        //};

        private IRepository<Artist> ArtistRepo;

        public ArtistController(IRepository<Artist> ArtistRepo)
        {
            this.ArtistRepo = ArtistRepo;
        }

        // GET api/Artists
        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            return ArtistRepo.GetAll();
        }

        // GET api/Artists/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Artist";
        }

        // POST api/Artists
        [HttpPost]
        public IEnumerable<Artist> Post([FromBody] Artist Artist)
        {
            ArtistRepo.Create(Artist);
            return ArtistRepo.GetAll();
        }

        // PUT api/Artists/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Artist)
        {
        }

        // DELETE api/Artists/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}