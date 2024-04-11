public class Pizza  {

   public string name;
   public int price;
   
   public List<Ingredient> ingredients = new List<Ingredient>();
   
   public Pizza(string name,int price) {
       
       this.name = name;
       this.price = price;


   }
}
