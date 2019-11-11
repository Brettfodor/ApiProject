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
    public class AlbumControllerTests
    {
        private AlbumController underTest;
        IRepository<Album> albumRepo;

        public AlbumControllerTests()
        {
            albumRepo = Substitute.For<IRepository<Album>>();
            underTest = new AlbumController(albumRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Albums()
        {
            var expectedAlbums = new List<Album>()
            {
                new Album(1, "Title", "image", "label", 1),
                new Album(1, "Title", "image", "label", 1),
        };
            albumRepo.GetAll().Returns(expectedAlbums);

            var result = underTest.Get();

            Assert.Equal(expectedAlbums, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Album()
        {
            var newAlbum = new Album(1, "Title", "image", "label", 1);
            var albumList = new List<Album>();

            albumRepo.When(t => t.Create(newAlbum))
                .Do(t => albumList.Add(newAlbum));

            albumRepo.GetAll().Returns(albumList);

            var result = underTest.Post(newAlbum);

            Assert.Contains(newAlbum, result);
        }

        [Fact]
        public void Delete_Removes_Album()
        {
            var albumId = 1;
            var deletedAlbum = new Album(1, "Title", "image", "label", 1);
            var albumList = new List<Album>()
            {
                deletedAlbum,
                new Album(1, "Title", "image", "label", 1)
        };

            albumRepo.GetById(albumId).Returns(deletedAlbum);
            albumRepo.When(d => d.Delete(deletedAlbum))
                .Do(d => albumList.Remove(deletedAlbum));
            albumRepo.GetAll().Returns(albumList);

            var result = underTest.Delete(albumId);

            // Assert.DoesNotContain(deletedTodo, result); Does not work in all cases
            Assert.All(result, item => Assert.Contains("Second item", item.Title));
        }

        [Fact]
        public void Put_Updates_Album()
        {
            var originalAlbum = new Album(1, "Title", "image", "label", 1); 
            var expectedAlbums = new List<Album>()
            {
                originalAlbum
            };
            var updatedAlbum = new Album(1, "Title", "image", "label", 1);

            albumRepo.When(t => albumRepo.Update(updatedAlbum))
                .Do(Callback.First(t => expectedAlbums.Remove(originalAlbum))
                .Then(t => expectedAlbums.Add(updatedAlbum)));
            albumRepo.GetAll().Returns(expectedAlbums);

            var result = underTest.Put(updatedAlbum);

            // Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Title));
        }
    }
}
