using System;
using System.Collections.Generic;
public class PizzaMenu  {
 

    public string Name { get; set; }
    public double Price { get; set; }
    public Dictionary<string, Ingredient> Ingredients { get; set; }
    public Dictionary<string, Pizza> PizzaMeny {get; set;}

    public PizzaMenu()
    {
     
        PizzaMeny = new Dictionary<string, Pizza>();
        
        PizzaMeny.Add("Vesuvio", new Pizza("vesuvio", 89));
        PizzaMeny.Add("Acapulco", new Pizza("Acapulco", 99));
        PizzaMeny.Add("Italia", new Pizza("Italia", 85));
        PizzaMeny.Add("Capricosa", new Pizza("Capricosa", 79));

    }
}





