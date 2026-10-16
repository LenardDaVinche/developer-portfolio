The Templates are deisgned as such. (Since JSON cant accept comments)

Varible_Template:
    "Description": This is the description of the varible (to be filled in eg, "Old man")
    Additions:
        The Additions are the extra varibles to a varible, it can have none, they are objects in an array
        The Objects are for this like "On fire", "Disabled", "has Terminal Cancer" etc. and how its added to descriptions
    Chosen addition will store the location of the chosen Addition in the array (For the Choice template) starts as null
    If chosen addition remains null it means there is no addition

    In both image is for the file link to the image to use.

Choice_Template:
The idea fo this template is it stores the choices made (and what was in them) in a array of the program
    The 2 Varibles store objests of varibles (Varible_Template format).
    the Choie stores the choice the user made.
    And the description given to the user.