Just run the application and then go to /Home/Character in the Browser (like http://localhost:49702/Home/Character).
You can also find the presentation... ( e-Portfolio_MVC_4_.NET_Winter.pptx (https://github.com/hendrik-w/CharacterAdministration/blob/master/e-Portfolio_MVC_4_.NET_Winter.pptx))

Tutorial
 1. First install .Net Framework and any IDE which supports MVC 4 with Razor. 
 2. Create a new ASP .NET MVC 4 Project and select Internet Application. Under the point view engine select razor!
 3. Add a new razor view file in the Home folder under Views and name it Character.
 4. Add the following code:
```
@{
    ViewBag.Title = "title";
}

<!--View excepts a List of Characters-->
@model List<YourApplicationName.Models.Character>


<!--Action: Create (im Homecontroller)
    Parameter: characterName (The name of the parameter is important and mus match the parameter name of the Create method.) -->
<form action="Create">
    <div>
        <input name="characterName" />
        <input type="submit" value="Create Character" />
    </div>
</form>

<h2>Character</h2>

<ul>
    @foreach (var item in Model)
    {
        <li>@item.Name</li>
    }
</ul>
```

 5. Change the Name YourApplicationName into the name of your application.
 6. Go to the models folder and add a c# class called Character.
 7. Add the following Code

```
using System;
using System.Collections.Generic;


namespace YourApplicationName.Models
{
    public class Character
    {
        public String Name;

        /// <summary>
        /// Creates the specified name and add it to the GlobalVariables.
        /// </summary>
        /// <param name="name">The name.</param>
        public static void Create(String name)
        {
            Character character = new Character();
            character.Name = name;

            if(GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();

            GlobalVariables.Characters.Add(character);
        }

        /// <summary>
        /// Gets all characters in GlobalVariables.
        /// </summary>
        /// <returns></returns>
        public static List<Character> GetAll()
        {
            if (GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();

            return GlobalVariables.Characters; 
        } 
    }
}
```
 8. Change YourApplicationName
 9. Add a class GlobalVariables into the project.
 10.  Add this code into the class 
```
        public static List<Character> Characters { get; set; } 
```
 11. Go into Controller class HomeController and add the following code
```
   /// <summary>
        /// Views the character html with the param Models.Character.GetAll()
        /// </summary>
        /// <returns>Character view</returns>
        public ActionResult Character()
        {
            return View("Character", Models.Character.GetAll());
        }


        /// <summary>
        /// Creates the specified character name.
        /// </summary>
        /// <param name="characterName">Name of the character.</param>
        /// <returns></returns>
        public ActionResult Create(String characterName)
        {
            Models.Character.Create(characterName);
            return RedirectToAction("Character");
        }
```     
 12. Run the application and go to  /Home/Character (like http://localhost:49702/Home/Character)
 13. Add characters like you want.
