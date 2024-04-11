using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program 
{
    static void Main(string[] args)
    {
       
        var userDatabase = new System.Collections.Generic.Dictionary<string, User>();
        userDatabase.Add("Liza", new User("Liza", "Liza"));
        var pizzaMeny = new PizzaMenu();

        // Orden 
       Order order1 = null;
       

        bool loggedIn = false;

        while (order1 == null)
        {
            Console.WriteLine("Ange användarnamn:");
            string username = Console.ReadLine();
            Console.WriteLine("Ange lösenord:");
            string password = Console.ReadLine();

        
            if (userDatabase.TryGetValue(username, out var user))
            {
                if(user.password == password) {
                  

                    Console.WriteLine("Inloggning lyckades!");
                    order1 = new Order(34, user);
                    loggedIn = true;
                    
                }
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord. Försök igen.");
            }

        }
        while(true){

        Console.WriteLine("-------------------------");
        Console.WriteLine("Välj en pizza från menyn");
        Console.WriteLine("-------------------------");
        foreach(var pizza in pizzaMeny.PizzaMeny) {
            Console.WriteLine(pizza.Key);

        }
         var pizzaVal = Console.ReadLine();
         if (pizzaMeny.PizzaMeny.TryGetValue(pizzaVal, out var pizzan)) {
             
             Console.WriteLine( "Det blir: " + pizzan.price + "Kr");
             Console.WriteLine(pizzan.name + " " +  pizzan.price + " Vill du ha det y/n");
             var pizzaVal2 =  Console.ReadLine();

             if (pizzaVal2 == "y") {
              
               order1?.PizzaOrder.Add(pizzan);
               Console.WriteLine(order1?.Kvitto());
               Console.WriteLine("klar med köp y/n");
               var klar = Console.ReadLine();

               if (klar == "y") {
                Console.WriteLine("Här är ditt kvitto på köpet!");
                Console.WriteLine(order1.Kvitto());
                Console.WriteLine("Tack och välkommen åter!");
                break;

               }

             }


         }else{
            Console.WriteLine("Tyvärr den pizza finns ej!");
            Console.WriteLine("Kolla gärna vår meny! ");
         }



        }
       

     
     
        
      
    }
}


