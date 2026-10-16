
// Code goes here


function pullData() {
    //This would be the function to get the data from the file
    //For now this is empty and we just put the data into the JS directly
}

let scenario = 1;
let choice1;
let choice2;

// Array to store all the current user's choices
var choices = []

/**
Prevents "submit" from refreshing page 
*/
function main() {

    const myForm = document.getElementById("formChoices");
    function handleForm(event) { event.preventDefault(); }
    myForm.addEventListener('submit', handleForm);

    generate();
}

/**
Sets limit to the amount of Scenarios; Assings IDs for the scenarios; Assings variables to RNG; Assigns names to values
*/
function generate() {

    //Stops the scenarios after 10 
    if (scenario > 10) {
        displayFinalScore();
        return;
    }

    //Set the scenario number and increase
    document.getElementById("num").innerText = scenario;

    //Console.log("Loaded");

    //Get the random numbers and assign vars from them
    const rands = getRandom(data.length);
    choice1 = data[rands[0]];
    choice2 = data[rands[1]];

    //Change the descriptions
    document.getElementById("desc1").innerText = choice1.Description;
    document.getElementById("desc2").innerText = choice2.Description;

    //Change option labels to match
    document.getElementById("optDesc1").innerText = choice1.Description;
    document.getElementById("optDesc2").innerText = choice2.Description;

    //Give the options the object names as their values (Should make it easy to see which was chosen)
    document.getElementById("ch1").setAttribute("value", choice1.Name);
    document.getElementById("ch2").setAttribute("value", choice2.Name);
}

/**
Checks value of selected radio button and returns the value of selected radio button
*/
function formSubmit() {
    // console.log("Form submit");

    //Give "choice" variable a value
    var choiceMade = document.querySelector('input[name="choice"]:checked').value;
    /*
    if (choiceMade == null) {
        return false;
    }
    */
    //choiceMade == choiceMade.value
    scenario++;

    // Options and choice for current scenario
    var choiceArray = {
        "Var1": choice1,
        "Var2": choice2,
        "Chosen": choiceMade
    };

    // Append to choices array
    choices.push(choiceArray);
    choices = JSON.stringify(choices);
    //alert(choiceJSON);

    //Checks if radio button was pressed
    var radButton = document.getElementsByName("choice");
    for (var i = 0; i < radButton.length; i++) {
        radButton[i].checked = false;
    }

    generate();

    //Display value
    document.getElementById("prevChoice").innerText = "You previously chose: " + choiceMade;
}

/**
Displays all the final choices
*/
function displayFinalScore() {

    //Clear the document to present Choices
    document.getElementById("header1").innerText = "Choices Made";
    const container = document.getElementById("container");
    while (container.firstChild) {
        container.removeChild(container.firstChild);
    }
    /*
    let toAdd = document.createElement('p');    
    toAdd.innerText = "THIS SENTANCE IS FALSE!"
    container.appendChild(toAdd);
    */

    //For all choices
    //Print choice 1, choice 2, chosen option
    for(let i = 0; i < choices.length; i++) {
        //Get the data to use
        const item = choices[i];
        const opt1 = item.Var1;
        const opt2 = item.Var2;
        const picked = item.Chosen;

        //Add the senario Number as a header 
        let scenarioH2 = document.createElement('h2');
        scenarioH2.innerText = "Senario " + (i+1)
        container.appendChild(scenarioH2)

        //Create and prepare pargraph elements
        let scenarioOpt1 = document.createElement('p');
        scenarioOpt1.innerText = "Option 1: " + opt1.Name;
        let scenarioOpt2 = document.createElement('p');
        scenarioOpt2.innerText = "Option 2: " + opt2.Name;
        let scenarioPick = document.createElement('p');
        scenarioPick.innerText = "Chosen: " + picked;

        //Append the parpagrah option elements to the main div
        container.appendChild(scenarioOpt1);
        container.appendChild(scenarioOpt2);
        container.appendChild(scenarioPick);

        //All of this would be much better in a table but that had a lot of extra overhead work to format correctly
        //This is a good enough proof of concept as all the information is here and can be reformatted
    }


    /*
    //Create variable called wrapper, containing div 
    var wrapper = document.createElement('div');
    //Creates link to the html body 
    var Score = document.querySelectorAll('.Score');
    //Adds new div element to main body of the html
    Score[0].parentElement.appendChild(wrapper);
    wrapper.id = 'wrapper';

    //Populates new div element with contents of array
    for(var i = 0; i < choices.length; i++){
        wrapper.appendChild(choices[i]["Chosen"]);
    }
    */
}

/**
Returns 2 random numbers between 0 and Supplied number
*/
function getRandom(max) {
    const rand1 = Math.floor(Math.random() * max);
    //Slightly more performant on average (No chance to get stuck in a inf loop compared to the very slim chance)
    //Make the number generate one less than the max value
    let rand2 = Math.floor(Math.random() * (max - 1));
    if (rand2 >= rand1) {
        rand2 += 1;
    }
    return [rand1, rand2];
}

/**
JSON Data array conatining all the possible choices
*/
const data = [{
    "Name": "Old man",
    "Image": null,
    "Description": "an Old man",
    "Chosen Addition": null,
    "Additions": []
},
{
    "Name": "Old lady",
    "Image": null,
    "Description": "an Old lady",
    "Chosen Addition": null,
    "Additions": []
},
{
    "Name": "Baby",
    "Image": null,
    "Description": "a Baby",
    "Chosen Addition": null,
    "Additions": []
},
{
    "Name": "Teenager",
    "Image": null,
    "Description": "a Teenager",
    "Chosen Addition": null,
    "Additions": []
},
{
    "Name": "Young Child",
    "Image": null,
    "Description": "a Young Child",
    "Chosen Addition": null,
    "Additions": []
},
{
    "Name": "Adult",
    "Image": null,
    "Description": "an Adult",
    "Chosen Addition": null,
    "Additions": []
}]
