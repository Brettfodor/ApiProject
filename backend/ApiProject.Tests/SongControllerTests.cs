using ApiProject.Controllers;
using ApiProject.Models;
using ApiProject.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ApiProject.Tests
{
    public class SongControllerTests
    {
        private SongController underTest;
        IRepository<Song> songRepo;

        public SongControllerTests()
        {
            songRepo = Substitute.For<IRepository<Song>>();
            underTest = new SongController(songRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Songs()
        {
            var expectedSongs = new List<Song>()
            {
                new Song(1, "Title", "Link", "Time", 1,"./css/images/genericsong.jpg"),
                new Song(1, "Title", "Link", "Time", 1,"./css/images/genericsong.jpg")
        };
            songRepo.GetAll().Returns(expectedSongs);

            var result = underTest.Get();

            Assert.Equal(expectedSongs, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Artist()
        {
            var newSong = new Song(1, "Title", "Link", "Time", 1, "./css/images/genericsong.jpg");
            var songList = new List<Song>();

            songRepo.When(t => t.Create(newSong))
                .Do(t => songList.Add(newSong));

            songRepo.GetAll().Returns(songList);

            var result = underTest.Post(newSong);

            Assert.Contains(newSong, result);
        }

        [Fact]
        public void Delete_Removes_Song()
        {
            var songId = 1;
            var deletedSong = new Song(1, "Title", "Link", "Time", 1, "./css/images/genericsong.jpg");
            var songList = new List<Song>()
            {
                deletedSong,
                new Song(1, "Title", "Link", "Time", 1,"./css/images/genericsong.jpg")
        };

            songRepo.GetById(songId).Returns(deletedSong);
            songRepo.When(d => d.Delete(deletedSong))
                .Do(d => songList.Remove(deletedSong));
            songRepo.GetAll().Returns(songList);

            var result = underTest.Delete(songId);

            Assert.DoesNotContain(deletedSong, result); /*Does not work in all cases*/
            //Assert.All(result, item => Assert.Contains("Second item", item.Title));
        }

        [Fact]
        public void Put_Updates_Song()
        {
            var originalSong = new Song(1, "Title", "Link", "Time", 1, "./css/images/genericsong.jpg");
            var expectedSongs = new List<Song>()
            {
                originalSong            };
            var updatedSong = new Song(1, "Title", "Link", "Time", 1, "./css/images/genericsong.jpg");

            songRepo.When(t => songRepo.Update(updatedSong))
                .Do(Callback.First(t => expectedSongs.Remove(originalSong))
                .Then(t => expectedSongs.Add(updatedSong)));
            songRepo.GetAll().Returns(expectedSongs);

            var result = underTest.Put(updatedSong);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Title));
        }
    }
}
