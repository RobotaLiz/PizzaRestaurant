using System.Security.Cryptography.X509Certificates;

public class Ingredient {

 public string name;

  
public Ingredient (string name) {
     

    this.name = name;

      Dictionary<string, Ingredient> ingredients = new Dictionary<string, Ingredient>
        {
            { "cheese", new Ingredient("Cheese") },
            { "tomatoSauce", new Ingredient("Tomato Sauce") },
            { "pepperoni", new Ingredient("Pepperoni") },
            { "pineapple", new Ingredient("Pineapple") },
            { "mushrooms", new Ingredient("Mushrooms") },
            { "bellPeppers", new Ingredient("Bell Peppers") }
        };


  }


}