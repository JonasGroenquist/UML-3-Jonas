// See https://aka.ms/new-console-template for more information


using UML_3_Jonas;

IMenuCatalog catalog = new MenuCatalog();
Pizza p1 = new Pizza(1, "Margarita", "Cheese", 75, MenuType.Pizza, true, true, true);
Pizza p2 = new Pizza(1, "Margarita2", "Cheese", 75, MenuType.Pizza, true, true, true);
catalog.Add(p1);
Beverage b1 = new Beverage(2, "Beer", "6,4%", 39.95, MenuType.Drink, true, true, true);
catalog.Add(b1);
try
{
    catalog.Add(p2);
}
catch (MenuItemNumberExists existexcep)
{
    Console.WriteLine($"{existexcep.Message}");
}
catch (Exception ex)
{
    Console.WriteLine ($"Error");
}

IMenuItem foundItem = catalog.Search(2);
if (foundItem != null)
{
    Console.WriteLine($"Fandt {foundItem}");
}


//Test af FindAllVegan
List<IMenuItem> veganItems = catalog.FindAllVegan(MenuType.Pizza);
foreach(IMenuItem item in veganItems)
{
    Console.WriteLine(item);
}