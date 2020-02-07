using Microsoft.VisualStudio.TestTools.UnitTesting;
using detaclon;

namespace Test_detaclon
{
    [TestClass]
    public class UnitTestDetaclon
    {
        [TestMethod]
        public void TestLoginok()
        {
            // Arrange
            bool connect = true;
            string name = "Aubin GOUHIER"; //name ok 
            string password = "PolytechTours"; //password ok
            LoginForm form = new LoginForm();

            // Act
            form.connect(name, password);

            // Assert
            Assert.AreEqual(connect, form.stateconnexion, "User login ok");
        }

        public void TestLoginko()
        {
            // Arrange
            bool connect = false;
            string name = "Aubin GOUHIER"; //name ok
            string password = "PolytechTours"; //password ko
            LoginForm form = new LoginForm();

            // Act
            form.connect(name, password);

            // Assert
            Assert.AreEqual(connect, form.stateconnexion, "User login Ko");
        }

        public void TestAddProduct()
        {
            // Arrange
            string name_article="velo";
            decimal qtyadded = 48;

            AddingProductForm form = new AddingProductForm();

            // Act
            decimal qtystart = form.qty_product(name_article);
            decimal qtyexpected = qtystart+qtyadded;
            form.add_product(name_article, qtyadded);
            decimal qtyreal = form.qty_product(name_article);

            // Assert
            Assert.AreEqual(qtyexpected,qtyreal, "Add Product OK");
        }

    }
}
