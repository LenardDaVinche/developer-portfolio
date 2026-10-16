using EthicsWebApp.Controllers;
using EthicsWebApp.Data;
using EthicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace EthicsWebApp.Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        private HomeController _controller;
        private EthicsWebAppContext _context;
        private ILogger<HomeController> _logger;

        [SetUp]
        public void Setup()
        {
            // Create an in-memory database for testing
            var options = new DbContextOptionsBuilder<EthicsWebAppContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Initialize the context with the in-memory database options
            _context = new EthicsWebAppContext(options);
            // Initialize the controller with the actual context instance
            _controller = new HomeController(_logger, _context);
        }
        [Test]
        public void TestIndex()
        {

            // Act
            var result = _controller.Index();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<IActionResult>());
        }

        [Test]
        public void TestFinish()
        {

            // Act
            var result = _controller.Finish();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<IActionResult>());
        }

        [Test]
        public void TestPrivacy()
        {
            // Act
            var result = _controller.Privacy();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<IActionResult>());
        }

        [Test]
        public void TestError()
        {
            // Act
            var result = _controller.Error() as ViewResult;

            // Assert
            Assert.That(result, Is.InstanceOf<ViewResult>()); // Check if it returns a ViewResult
            Assert.That(result.Model, Is.Not.Null); // Check if the model is not null
            Assert.That(result.Model, Is.InstanceOf<ErrorViewModel>()); // Check if the model is of type ErrorViewModel
        }

        [Test]
        public void TestMakeSession()
        {
            // Arrange
            var formCollection = new Mock<IFormCollection>();
            formCollection.Setup(fc => fc["Country"]).Returns("TestCountry");

            var session = new Mock<ISession>();
            var httpContext = new Mock<HttpContext>();
            httpContext.SetupGet(c => c.Session).Returns(session.Object);

            var controller = new HomeController(_logger, _context);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = httpContext.Object
            };

            // Act
            var result = controller.MakeSession(formCollection.Object);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ControllerName, Is.EqualTo("Ethics"));
            Assert.That(result.ActionName, Is.EqualTo("Scenario"));
        }


    }
}