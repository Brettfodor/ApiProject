using ApiProject.Controllers;
using ApiProject.Models;
using ApiProject.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ApiProject.Tests
{
    public class ArtistControllerTests
    {
        private ArtistController underTest;
        IRepository<Artist> artistRepo;

        public ArtistControllerTests()
        {
            artistRepo = Substitute.For<IRepository<Artist>>();
            underTest = new ArtistController(artistRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Artists()
        {
            var expectedArtists = new List<Artist>()
            {
                new Artist(1, "Name", "image"),
                new Artist(1, "Name", "image")
        };
            artistRepo.GetAll().Returns(expectedArtists);

            var result = underTest.Get();

            Assert.Equal(expectedArtists, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Artist()
        {
            var newArtist = new Artist(1, "Name", "image");
            var todoList = new List<Artist>();

            artistRepo.When(t => t.Create(newArtist))
                .Do(t => todoList.Add(newArtist));

            artistRepo.GetAll().Returns(todoList);

            var result = underTest.Post(newArtist);

            Assert.Contains(newArtist, result);
        }

        [Fact]
        public void Delete_Removes_Artist()
        {
            var artistId = 1;
            var deletedArtist = new Artist(1, "Name", "image");
            var artistList = new List<Artist>()
            {
                deletedArtist,
                new Artist(1, "Name", "image")
        };

            artistRepo.GetById(artistId).Returns(deletedArtist);
            artistRepo.When(d => d.Delete(deletedArtist))
                .Do(d => artistList.Remove(deletedArtist));
            artistRepo.GetAll().Returns(artistList);

            var result = underTest.Delete(artistId);

            Assert.DoesNotContain(deletedArtist, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Name));
        }

        [Fact]
        public void Put_Updates_Artist()
        {
            var originalArtist = new Artist(1, "Name", "image"); ;
            var expectedArtists = new List<Artist>()
            {
                originalArtist
            };
            var updatedArtist = new Artist(1, "Name", "image"); 

            artistRepo.When(t => artistRepo.Update(updatedArtist))
                .Do(Callback.First(t => expectedArtists.Remove(originalArtist))
                .Then(t => expectedArtists.Add(updatedArtist)));
            artistRepo.GetAll().Returns(expectedArtists);

            var result = underTest.Put(updatedArtist);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}

