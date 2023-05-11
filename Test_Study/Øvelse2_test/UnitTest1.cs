using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Øvelse2;
using Moq;

namespace Øvelse2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BaristaMakeCoffee()
        {

            //Arrange
            Barista barista = new Barista();
            Drink expectedDrink = new Drink("Americano");

            //Act
            Drink actualDrink = barista.MakeCoffe("Americano");

            //Assert
            Assert.AreEqual(expectedDrink.name, actualDrink.name);

        }

        [TestMethod]
        public void WaitressTakeOrder()
        {

            //Arrange
            Waitress waitress = new Waitress();

            Mock<IOrder> mockOrder = new Mock<IOrder>();
            Mock<Barista> mockBarista = new Mock<Barista>();

            mockOrder.SetupProperty(x => x.Drink, "Espresso");
            mockBarista.Setup(x => x.MakeCoffe("Espresso")).Returns(new Drink("Espresso"));

            Drink expected = new Drink("Espresso");

            //Act
            waitress.TakeOrder(mockOrder.Object);
            waitress.GiveOrder(mockBarista.Object);
            Drink actual = waitress.ServeDrink();

            //Assert
            Assert.AreEqual(expected.name, actual.name);
        }
    }
}
