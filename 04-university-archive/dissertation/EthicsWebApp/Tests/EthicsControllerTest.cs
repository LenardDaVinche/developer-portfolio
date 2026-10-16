using EthicsWebApp.Controllers;
using EthicsWebApp.Data;
using EthicsWebApp.Enums;
using EthicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using NUnit.Framework;

namespace EthicsWebApp.Tests
{
    [TestFixture]
    public class EthicsControllerTest
    {
        private EthicsController _controller;
        private EthicsWebAppContext _context;
        private ILogger<EthicsController> _logger;
        private IMemoryCache _memoryCache;

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
            _controller = new EthicsController(_context, _logger, _memoryCache);
        }
        
        [Test]
        public void TestVariableImageList()
        {
            // Arrange
            // Create an in-memory database for testing with known existing entries
            var options = new DbContextOptionsBuilder<EthicsWebAppContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Initialize the context with the in-memory database options
            using (var context = new EthicsWebAppContext(options))
            {
                // Add some existing variables to the database
                context.Variable.AddRange(new List<Variable>
                {
                    new Variable { VarID = 1, Name = "Variable 1", Desc = null },
                    new Variable { VarID = 2, Name = "Variable 2", Desc = null },
                    // Add more existing variables as needed
                });
                context.SaveChanges();
            }
            
            var controller = new EthicsController(_context, _logger, _memoryCache);

            // Act
            // Call the method to update existing entries in the database
            controller.VariableImageList();

            // Assert
            // Query the database to check if the Desc property has been populated as expected
            var variableWithImages = _context.Variable.Where(v => v.Desc != null).ToList();
    
            // Assert that there are records with non-null Desc values
            Assert.That(variableWithImages, Is.Not.Empty);

            // Assert that the Desc values are populated as expected
            foreach (var variable in variableWithImages)
            {
                string expectedDesc = $"~/images/{variable.Name.Replace(" ", "")}.png";
                Assert.That(variable.Desc, Is.EqualTo(expectedDesc));
            }
        }
        [Test]
        public void CheckScenario_ExistingScenario_ReturnsTrue()
        {
            // Arrange
            var scenario = new Scenario { Background = "Trolley", Var1 = 1, Var2 = 2, Attr1 = 3, Attr2 = 4 };
            _context.Scenario.Add(scenario);
            _context.SaveChanges();

            // Act
            var result = _controller.CheckScenario(1, 2, 3, 4);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckScenario_NonExistingScenario_ReturnsFalse()
        {
            // Arrange - No scenarios added to the database

            // Act
            var result = _controller.CheckScenario(5, 6, 7, 8);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task SaveScenario_ValidScenario_ReturnsCreatedAtAction()
        {
            // Arrange
            var scenario = new Scenario { Background = "Trolley", Var1 = 1, Var2 = 2, Attr1 = 3, Attr2 = 4 };

            // Act
            var result = await _controller.SaveScenario(scenario) as CreatedAtActionResult;

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo(nameof(EthicsController.CheckScenario)));
            Assert.That(result.RouteValues["var1"], Is.EqualTo(scenario.Var1));
            Assert.That(result.RouteValues["var2"], Is.EqualTo(scenario.Var2));
            Assert.That(result.RouteValues["attr1"], Is.EqualTo(scenario.Attr1));
            Assert.That(result.RouteValues["attr2"], Is.EqualTo(scenario.Attr2));
            Assert.That(result.Value, Is.EqualTo(scenario));
        }

        [Test]
        public async Task SaveScenario_NullScenario_ReturnsBadRequest()
        {
            // Act
            var result = await _controller.SaveScenario(null) as BadRequestObjectResult;

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.StatusCode, Is.EqualTo(400));
            Assert.That(result.Value, Is.EqualTo("Scenario object is null."));
        }

        [Test]
        public async Task SaveScenario_NullProperties_ReturnsBadRequest()
        {
            // Arrange
            var scenario = new Scenario { Background = "Trolley", Var1 = null, Var2 = 2, Attr1 = 3, Attr2 = 4 };

            // Act
            var result = await _controller.SaveScenario(scenario) as BadRequestObjectResult;

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.StatusCode, Is.EqualTo(400));
            Assert.That(result.Value, Is.EqualTo("Scenario properties cannot be null."));
        }

        [Test]
        public void CalculateDominantFramework_ReturnsCorrectFramework()
        {
            // Arrange
            var totalScore = 70;

            // Act
            var result = _controller.CalculateDominantFramework(totalScore);

            // Assert
            Assert.That(result, Is.EqualTo(NormativeEthicsFramework.Utilitarianism));
        }
    }
}