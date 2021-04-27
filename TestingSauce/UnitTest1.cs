using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SauceDemo;
using SauceDemo.PageObjects;

namespace TestingSauce
{
    [TestClass]
    public class UnitTest1
    {
        // Before tests
        LoginPage login = new LoginPage();
        UserInformation user = new UserInformation();
        HomePage home = new HomePage();
        BasePage basePage = new BasePage();

        [TestInitialize]
        public void Initialize()
        {
            basePage
                .InitializeDriver()
                .OpenBrowser();
        }

        [TestMethod]
        public void ValidUserTest()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);
        }

        [TestMethod]
        public void InValidUserTest()
        {
            user.InValid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(login.ErrorMessageTitle), basePage.ErrorMessageText);
        }

        [TestMethod]
        public void ValidUserTest_Logout()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);

            home.LogOut();
            
            Assert.AreEqual(basePage.ElementDisplayed(login.UserEmail), true);
        }

        [TestMethod]
        public void SortProducts()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);

            home.SelectDropDown(SortContainer.LowtoHigh);
        }

        [TestMethod]
        public void AddMultpleItemsToShoppingCart()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);

            home.AddToShoppingCart(home.SauceLabsBackPack);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsBackPack), "REMOVE");

            home.AddToShoppingCart(home.SauceLabsBikeLight);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsBikeLight), "REMOVE");

            home.AddToShoppingCart(home.SauceLabsOnesies);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsOnesies), "REMOVE");

            home.AddToShoppingCart(home.SauceLabsTShirtRed);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsTShirtRed), "REMOVE");
        }

        [TestMethod]
        public void AddProductToShoppingCart()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);

            home.SelectDropDown(SortContainer.LowtoHigh);

            basePage.WaitTime(home.SauceLabsOnesies);
            home.AddToShoppingCart(home.SauceLabsOnesies);

            basePage.WaitTime(home.RemoveSauceLabsOnesies);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsOnesies), "REMOVE");

            home.OpenShoppingCart();
            Assert.AreEqual(basePage.ObtainText(home.InventoryItemName), home.Itemtitle);
        }

        [TestMethod]
        public void CheckOutProduct()
        {
            user.Valid_UserInformation();

            login.UserLogin(user.UserEmail, user.UserPassword);
            Assert.AreEqual(basePage.ObtainText(home.ProductsTitle), basePage.ProductsTitleText);

            home.SelectDropDown(SortContainer.LowtoHigh);

            basePage.WaitTime(home.SauceLabsOnesies);
            home.AddToShoppingCart(home.SauceLabsOnesies);

            basePage.WaitTime(home.RemoveSauceLabsOnesies);
            Assert.AreEqual(basePage.ObtainText(home.RemoveSauceLabsOnesies), "REMOVE");

            home.OpenShoppingCart();
            Assert.AreEqual(basePage.ObtainText(home.InventoryItemName), home.Itemtitle);

            home.CheckOutProduct();
            basePage.WaitTime(home.PaymentInformation);
            Assert.IsNotNull(basePage.ObtainText(home.PaymentInformation));
        }

        [TestCleanup]
        public void TestClose()
        {
            basePage.CloseDriver();
        }
    }
}
