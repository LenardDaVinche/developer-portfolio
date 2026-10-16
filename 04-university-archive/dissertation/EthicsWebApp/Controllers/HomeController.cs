using EthicsWebApp.Data;
using EthicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EthicsWebApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EthicsWebAppContext _context;

        public HomeController(ILogger<HomeController> logger, EthicsWebAppContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public IActionResult Finish()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult SubmitAndFinish()
        {
            // Create a new User object with required data
            User newUser = new User
            {
                UserId = (int)HttpContext.Session.GetInt32("UserID"),
                Country = HttpContext.Session.GetString("SelectedCountry"),
                StartTime = DateTime.Parse(HttpContext.Session.GetString("StartDate")),
                FinishTime = DateTime.Now,
                DidFinish = true
            };

            // Edit the user created at the start to add the rest of the data
            _context.User.Update(newUser);

            // Save changes to the database
            _context.SaveChanges();

            // Redirect to landing page
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public RedirectToActionResult MakeSession(IFormCollection formCollection)
        {
            //For generating a user ID
            Random rand = new Random();

            // Generate a random number between 1000 and 9999 for ID
            int genUserID = rand.Next(1000, 10000);

            // Was originally it's own function, just grabs start date & time to be used later and stores it in a model
            DateTime startDate = DateTime.Now;

            // Grab the current region & set session variable
            string selectedCountry = formCollection["Country"];
            HttpContext.Session.SetString("SelectedCountry", selectedCountry);

            // String region = country.SelectedItem.GetValue;
            // Store token of user identity (Doesn't need to be overly secure or undecipherable as nothing important is stored here)
            String Token = "";
            HttpContext.Session.SetString("UserToken", Token);
            HttpContext.Session.SetString("TestData", "This is a test");

            // Save random ID we generated earlier
            HttpContext.Session.SetInt32("UserID", genUserID);

            // Store current date
            HttpContext.Session.SetString("StartDate", startDate.ToString());

            // Create a user with just the UserID populated, the other columns will be filled at the end
            User newUser = new User
            {
                UserId = (int)HttpContext.Session.GetInt32("UserID"),
            };

            // Add the new user to the database context
            _context.User.Add(newUser);

            // Save changes to the database
            _context.SaveChanges();


            return RedirectToAction(nameof(EthicsController.Scenario), "Ethics");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}