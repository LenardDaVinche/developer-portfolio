using EthicsWebApp.Data;
using EthicsWebApp.Enums;
using EthicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PluralizeService.Core;

namespace EthicsWebApp.Controllers
{
    // [Authorize]
    public class EthicsController : Controller
    {
        // The database and random class
        private readonly EthicsWebAppContext _context;
        // New random variable
        private readonly Random rand = new Random();
        // Logger
        private readonly ILogger<EthicsController> _logger;
        // Cache for counter
        private readonly IMemoryCache _cache;
        private const string CounterKey = "ScenarioCounter";

        public EthicsController(EthicsWebAppContext context, ILogger<EthicsController> logger, IMemoryCache memoryCache)
        {
            _context = context;
            _logger = logger;
            _cache = memoryCache;
        }

        public IActionResult Index()
        {
            return View();
        }

        public int CalculateScoreForVariable(string variableName)
        {
            // Query the database to retrieve the score based on the variable's name
            var rule = _context.Variable.FirstOrDefault(v => v.Name == variableName);

            // If no rule is found or if the score is null, return a default score of 0
            if (rule == null || rule.Score == null)
            {
                return 0;
            }

            return rule.Score.Value;
        }
        public IActionResult SubmitChoice(int scenarioId)
        {
            try
            {
                // Retrieve the variable name from the database using the variable ID
                var variable = _context.Variable.FirstOrDefault(v => v.VarID == scenarioId);
                if (variable == null)
                {
                    // Handle variable not found
                    Console.WriteLine($"Variable with ID '{scenarioId}' not found.");
                    return NotFound($"Variable with ID '{scenarioId}' not found.");
                }

                // Assign the variable name
                string variableName = variable.Name;

                // Calculate the score based on the variable
                int score = CalculateScoreForVariable(variableName);

                // Create a new instance of the Choice model
                var newChoice = new Choice
                {
                    UserID = (int)HttpContext.Session.GetInt32("UserID"),
                    SenID = scenarioId,
                    ChoiceMade = variableName,
                    DateDone = DateTime.Now,
                    Score = score,
                };

                // Add the new choice to the database context
                _context.Choice.Add(newChoice);
                // Save changes to persist the new choice in the database
                _context.SaveChanges();

                // Redirect to the scenario page only if the database operation was successful
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Scenario");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError(ex, "Failed to submit choice.");
                // Handle exceptions, such as database constraint violations
                return StatusCode(500, "Failed to submit choice. Please try again later.");
            }
        }

        public NormativeEthicsFramework CalculateDominantFramework(int totalScore)
        {
            // Define the mapping of frameworks to their respective score thresholds
            Dictionary<NormativeEthicsFramework, int> scoreThresholds = new Dictionary<NormativeEthicsFramework, int>
            {
                { NormativeEthicsFramework.Utilitarianism, 60 }, // Adjust these thresholds as needed
                { NormativeEthicsFramework.Deontology, 20 },
                { NormativeEthicsFramework.VirtueEthics, 40 }
            };

            // Determine the dominant framework based on the total score
            foreach (var entry in scoreThresholds.OrderByDescending(x => x.Value))
            {
                if (totalScore >= entry.Value)
                {
                    return entry.Key;
                }
            }
            // Default to Virtue Ethics if the total score doesn't meet any thresholds
            return NormativeEthicsFramework.VirtueEthics;
        }
        public IActionResult CalculateEthicsFramework()
        {
            // Fetch last 10 user choices from the Choice database
            var userResponse = _context.Choice.OrderByDescending(c => c.ChoiceID).Take(10).ToList();

            int totalScore = 0;

            // Calculate scores based on user responses
            foreach (var response in userResponse)
            {
                // Increment score based on the choice made
                totalScore += response.Score;
            }

            // Determine the dominant normative ethics framework
            var dominantFramework = CalculateDominantFramework(totalScore);

            ViewBag.dominantFramework = dominantFramework.ToString();

            // Pass the result to the view
            return View("~/Views/Home/Finish.cshtml");
        }

        public IActionResult Scenario()
        {
            int scenarioCounter = _cache.TryGetValue(CounterKey, out int counter) ? counter : 0;
            Scenario randScenario = GenerateScenario();

            if (scenarioCounter >= 9)
            {
                _cache.Remove(CounterKey);
                return RedirectToAction("CalculateEthicsFramework");
            }

            if (randScenario == null)
            {
                return View("ErrorScenario");
            }

            // Update image paths for variables
            VariableImageList();


            String scenarioString = randScenario.ToString();

            Variable var1 = _context.Find<Variable>(randScenario.Var1);
            Variable var2 = _context.Find<Variable>(randScenario.Var2);

            EthicAttribute attri1 = _context.Find<EthicAttribute>(randScenario.Attr1);
            EthicAttribute attri2 = _context.Find<EthicAttribute>(randScenario.Attr2);

            String var1String = makeVarString(var1, attri1);
            String var2String = makeVarString(var2, attri2);

            scenarioString = scenarioString.Replace("{Var1}", var1String);
            scenarioString = scenarioString.Replace("{Var2}", var2String);

            ViewBag.Var1Image = var1.Desc;
            ViewBag.Var2Image = var2.Desc;

            ViewBag.scenarioString = scenarioString;
            ViewBag.var1 = var1String;
            ViewBag.var2 = var2String;

            scenarioCounter++;
            _cache.Set(CounterKey, scenarioCounter);
            Console.WriteLine(scenarioCounter);

            return View("Scenario", randScenario);
        }

        private String makeVarString(Variable Item, EthicAttribute Extra)
        {
            String Value = "";
            String Thing = Item.Name;
            String AttriType = Extra.Type;
            String AttriData;
            if (AttriType != "0") //Check if there is data
            {
                AttriData = Extra.Data; // If Data Exists Get the data
            }
            else // if no Data make the String and return it
            {
                Value = "1 " + Thing;
                return Value;
            }

            if (AttriType == "Num") // Check i the Attribute Type is a Number
            {
                if (AttriData == "1") // No need to Pluralize if it is one
                {
                    Value = "1 " + Thing;
                    return Value;
                }
                // if Greater than one PluralizeAction is needed
                Thing = PluralizationProvider.Pluralize(Thing);
                Value = AttriData + " " + Thing;
            }
            else if (AttriType == "Mod")
            {
                Value = "1 " + Thing; // Set the Quantity
                Value = Value + " who is " + AttriData; //Add the Context
            }
            return Value;
        }

        private bool TryGetRandomPairs(out Variable var1, out Variable var2, out EthicAttribute attr1, out EthicAttribute attr2)
        {
            var variables = _context.Variable.ToArray();
            var attributes = _context.EthicAttribute.ToArray();
            var rand = new Random();

            // Generate random numbers for variables
            int var1Number = rand.Next(variables.Length);
            int var2Number = rand.Next(variables.Length - 1);

            if (var2Number >= var1Number)
            {
                var2Number += 1;
            }

            // Generate random numbers for attributes
            int attr1Number = rand.Next(attributes.Length);
            int attr2Number = rand.Next(attributes.Length - 1);

            if (attr2Number >= attr1Number)
            {
                attr2Number += 1;
            }

            // Assign variables and attributes
            var1 = variables[var1Number] as Variable;
            var2 = variables[var2Number] as Variable;
            attr1 = attributes[attr1Number] as EthicAttribute;
            attr2 = attributes[attr2Number] as EthicAttribute;

            // Check if any of the conversions fail
            if (var1 == null || var2 == null || attr1 == null || attr2 == null)
            {
                // Return false if any conversion fails
                return false;
            }
            // Return true if all conversions are successful
            return true;
        }

        private Scenario? GenerateScenario()
        {
            // We're only doing trolley Problems now So just set as Trolley
            // To be expanded when we do other scenarios
            Scenario generated = new Scenario("Trolley");

            Variable var1, var2;
            EthicAttribute attr1, attr2;

            //attempt to get random pairs
            if (!TryGetRandomPairs(out var1, out var2, out attr1, out attr2))
            {
                //return null if conversion fails
                return null;
            }

            // Set the variables and attributes
            generated.Var1 = var1.VarID;
            generated.Var2 = var2.VarID;
            generated.Attr1 = attr1.AttrID;
            generated.Attr2 = attr2.AttrID;

            return generated;
        }

        // List of objects containing the name ("Name") of variable strings and the corresponding image path ("Desc"). 
        public void VariableImageList()
        {
            // Get all existing variables from the database
            var existingVariables = _context.Variable.ToList();

            foreach (var variable in existingVariables)
            {
                // Update the Desc property for each existing variable
                string varNameNoSpace = variable.Name.Replace(" ", "");
                variable.Desc = $"~/images/{varNameNoSpace}.png";
            }

            // Save changes to the database
            _context.SaveChanges();
        }

        // Check if data exists within Variable and Attribute SQL database tables
        public bool CheckScenario(int var1, int var2, int attr1, int attr2)
        {
            var scenarioExists = _context.Scenario.Any(s =>
            s.Var1 == var1 && s.Var2 == var2 && s.Attr1 == attr1 && s.Attr2 == attr2);

            return scenarioExists;
        }

        // Save data within Variable and Attribute SQL database tables
        public async Task<IActionResult> SaveScenario(Scenario scenario)
        {
            // Check if the scenario object is null
            if (scenario == null)
            {
                return BadRequest("Scenario object is null.");
            }

            // Check if any property is null
            if (scenario.Var1 == null || scenario.Var2 == null || scenario.Attr1 == null || scenario.Attr2 == null)
            {
                return BadRequest("Scenario properties cannot be null.");
            }

            try
            {
                // Add scenario to context
                _context.Scenario.Add(scenario);

                // Save changes to the database
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateException ex)
            {
                // Log the exception
                _logger.LogError(ex, "Failed to save scenario.");
                // Handle exceptions, such as database constraint violations
                return StatusCode(500, "Failed to save scenario. Please try again later.");
            }

            // Return created scenario
            return CreatedAtAction(nameof(CheckScenario), new { var1 = scenario.Var1, var2 = scenario.Var2, attr1 = scenario.Attr1, attr2 = scenario.Attr2 }, scenario);
        }
    }
}
