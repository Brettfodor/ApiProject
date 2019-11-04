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
    [Route("api/songs")]
    [ApiController]
    public class SongController : ControllerBase
    {
        //private static List<string> all = new List<string>()
        //{
        //    "Remodel Bathroom",
        //    "Finish my laser app",
        //    "Do things with kids"
        //};

        private IRepository<Song> SongRepo;

        public SongController(IRepository<Song> SongRepo)
        {
            this.SongRepo = SongRepo;
        }

        // GET api/Songs
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return SongRepo.GetAll();
        }

        // GET api/Songs/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Song";
        }

        // POST api/Songs
        [HttpPost]
        public IEnumerable<Song> Post([FromBody] Song Song)
        {
            SongRepo.Create(Song);
            return SongRepo.GetAll();
        }

        // PUT api/Songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Song)
        {
        }

        // DELETE api/Songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}