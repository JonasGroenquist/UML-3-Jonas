using UML_3_Jonas;

namespace UML_3_Jonas_Test
{
    [TestClass]
    public class MenuCatalogTest
    {
        MenuCatalog catalog;
        public void SetUp()
        {
            catalog = new MenuCatalog();
            MenuItem m1 = new Pizza(1, "Margarita", "Cheese", 75, MenuType.Pizza, true, true, true);
            catalog.Add(m1);
            //add flere menuitem
        }
        [TestMethod]
        public void Add_2MenuItem()
        {
            //Arrange
            SetUp();
            //Act
            int numbersBefore = catalog.Count;
            MenuItem m2 = new Pizza(2,"Vesuvio","Ham",80,MenuType.Pizza,false,true,true);
            catalog.Add(m2);
            int NumbersAfter = catalog.Count;
            //Assert
            Assert.AreEqual(numbersBefore+1, NumbersAfter);
        }
        [TestMethod]
        public void Delete_1MenuItem()
        {
            //Arrange
            SetUp();
            //Act
            int numbersBefore = catalog.Count;
            catalog.Delete(1);
            int NumbersAfter = catalog.Count;
            //Assert
            Assert.AreEqual(numbersBefore - 1, NumbersAfter);
        }
    }
}