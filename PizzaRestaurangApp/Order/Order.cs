
class Order {
   
    public int OrderNummer { get; set; }
    public User User;
    public List<Pizza> PizzaOrder { get; set; }
   

    // Konstruktor
    public Order(int orderNummer, User user) {
       
      this.OrderNummer = orderNummer;
      this.PizzaOrder = new List<Pizza>();
      this.User = user;

       
    }

    // Metod för att skriva ut orderbekräftelse
    public string Kvitto () {

        var totalt = 0;
        var kvitto = User.username + "\n";
        foreach (var pizza in PizzaOrder) {
            kvitto += pizza.name + " " +  pizza.price + "kr" + " \n";
            totalt += pizza.price;
        }
        kvitto += "Totalt: " + " " + totalt + "kr";
        return kvitto;

    }
}







