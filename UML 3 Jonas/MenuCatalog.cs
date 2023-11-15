using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Jonas
{
    public class MenuCatalog:IMenuCatalog
    {
        private List<IMenuItem> _menuItems;
        public MenuCatalog()
        {
            _menuItems = new List<IMenuItem>();
        }

        public int Count { get { return _menuItems.Count; } }

        

        public void Add(IMenuItem aMenuItem)
        {
            //foreach (IMenuItem item in _menuItems)
            //{
            //    if (aMenuItem.Number == item.Number)
            //    {
            //        throw new MenuItemNumberExists("There is already an item with existing number in List");
            //    }
            //    else
            //    {
            //        _menuItems.Add(aMenuItem);
            //    }
            //}

            if (Search(aMenuItem.Number) == null)
            {
                _menuItems.Add(aMenuItem);
            }
            else
            {
                throw new MenuItemNumberExists("There is already an item with existing number in List");
            }
        }
        public IMenuItem Search(int number)
        {
            foreach (IMenuItem menuItem in  _menuItems) 
            {
                if (number == menuItem.Number)
                    return menuItem;
            }
            return null;
        }
        public void Delete(int number)
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                if (_menuItems[i].Number == number)
                {
                    _menuItems.RemoveAt(i);
                    break;
                }
            }
        }
        public void PrintPizzasMenu()
        {
            foreach (var menuItem in _menuItems)
                if (menuItem.Type == MenuType.Pizza)
                {
                     Console.WriteLine(menuItem + " ");
                }
        }
        public void PrintBeveragesMenu()
        {
            foreach (var menuItem in _menuItems)
                if (menuItem.Type == MenuType.Drink /*|| menuItem.Type ==MenuType.AlcoholicDrink*/)
                {
                    Console.WriteLine(menuItem + " ");
                }
        }
        public void PrintToppingsMenu()
        {
            //kan springes over
        }
        public void Update(int number, IMenuItem theMenuItem)
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                if (_menuItems[i].Number == number)
                {
                    _menuItems.RemoveAt(i);
                    _menuItems.Insert(i, theMenuItem);
                    //_menuItems[i] = theMenuItem;
                }
            }
        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();

            //gennemløb collection
            //tag et item ud af gangen
            //undersøg om det er af typen "type" og er vegansk
            //hvis det er tilfældet så add det til returnList
            foreach (var menuItem in _menuItems)
            {
                if (menuItem.IsVegan == true && menuItem.Type == type)
                {
                    returnList.Add(menuItem);
                }
            }
            return returnList;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();
            foreach (var menuItem in _menuItems)
            {
                if (menuItem.IsOrganic == true && menuItem.Type == type)
                {
                    returnList.Add(menuItem);
                }
            }
            return returnList;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            if (!_menuItems.Any())
            { return null; }
            else
            {
                int index = 0;
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    if (_menuItems[i].Price > _menuItems[index].Price)
                        index = i;
                }

                return _menuItems[index];
            }
        }

    }
}
