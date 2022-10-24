using Microsoft.AspNetCore.Mvc;
using UnitTestApp Controllers;
using UnitTestApp.Models;
using Mog;
using Xunit;
using System.Collections.Generic;
using System.Ling;

namespace UnitTestApp.Tests

{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResulthithAListofusers()
        {
            // Arrange

            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestUsers());
            var controller = new HomeController(mock.Object);

            // act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
            Assert.Equal(GetTestUsers().Count, model.count());

        }
        private List<User> GetTestUsers()
        {
            var users = new List<User>
        {
            new User { Id=1, Name="Tom", Age=35},
            new User { Id=2, Name="Alice", Age=29},
            new User { Id=3, Name="Sam", Age=32},
            new User { Id=4, Name="Kate", Age=30}
};