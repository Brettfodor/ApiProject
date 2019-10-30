using ApiProject.Controllers;
using System;
using System.Linq;
using Xunit;

namespace ApiProject.Tests
{
    public class ArtistControllerTests
    {
        [Fact]
        public void Get_Returns_List_of_Artists()
        {
            var underTest = new ArtistController();

            var result = underTest.Get();

            Assert.Equal(2, result.Value.Count());

        }
        //[Fact]
        //public void Post_Creates_New_Artist()
        //{

        //    var underTest = new TodoController();

        //    var result = underTest.Post("New Task");

        //    Assert.Contains("New task", result.Value);

        //}
    }
}
