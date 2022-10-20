//Kent Tupas
//10/20/2022
//github mini challenge 9
//
//

string pick = "YES";
Console.Clear();
while(pick == "YES"){
bool choices = false;
string category = " ";
Random random = new Random();
string[] pizza = {"Pizza Hut", "Dominos", "Costco", "Papa Johns","Papa Murphys","Vip Pizza", "Leonardi's Pizza", "Eddie pizza", "Chuckie Chesse Pizza","Pizza Guys"};
string[] burger = {"Mc Donalds", "Red Robin", "Carls Jr","Wendys","Burger King", "Five guys","In n Out","Flip's Burger", "Habit Burger", "Moo moo's Burger Barn"};
string[] mexican = {"Taqueria La Mexicana","El Comal Taco truck", "La Casita","Tacos Chapala","La Korita","Nena's on B St","Acapulco Gardens mexican Food","El Poblana taco Truck","Birriera Jalisco","Taco Bell"};

while (!choices)
{
Console.WriteLine(" Pick a category? pizza, burger, mexican");
category = Console.ReadLine().ToLower();
switch(category)
{
      case "pizza":
      choices = true;
      int pizzaIndex = random.Next(pizza.Length);
      Console.WriteLine("");
      Console.WriteLine(pizza[pizzaIndex]);
 break;

 case "burger":
 choices = true;
 int burgerIndex = random.Next(burger.Length);
 Console.WriteLine("");
 Console.WriteLine(burger[burgerIndex]);
 break;

 case "mexican":
 choices = true;
 int mexicanIndex = random.Next(mexican.Length);
 Console.WriteLine("");
 Console.WriteLine(mexican[mexicanIndex]);
 break;

 default:
 Console.WriteLine("Thats not not a category");
 Console.WriteLine("Enter a catrgory");
 break;
}
}
Console.WriteLine("");
Console.WriteLine("Want to pick a another category? yes or no");
pick = Console.ReadLine().ToUpper();
if(pick == "NO"){
    Console.WriteLine("Have a nice day");

}
}





