using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.PageObjects
{
    public class HomePage : BasePage
    {
        public By BurgerMenuButton = By.Id("react-burger-menu-btn");
        public By LogOutButton = By.Id("logout_sidebar_link");
        public By productSortContainer = By.XPath("//select[@class='product_sort_container']");
        public By ProductsTitle = By.XPath("//span[@class='title']");

        // Add - Shopping Cart Items
        public By SauceLabsBackPack = By.Id("add-to-cart-sauce-labs-backpack");
        public By SauceLabsBikeLight = By.Id("add-to-cart-sauce-labs-bike-light");
        public By SauceLabsOnesies = By.Name("add-to-cart-sauce-labs-onesie");
        public By SauceLabsTShirtRed = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");

        // Remove - Shopping Cart Items
        public By RemoveSauceLabsBackPack = By.Id("remove-sauce-labs-backpack");
        public By RemoveSauceLabsBikeLight = By.Id("remove-sauce-labs-bike-light");
        public By RemoveSauceLabsOnesies = By.Id("remove-sauce-labs-onesie");
        public By RemoveSauceLabsTShirtRed = By.Id("remove-test.allthethings()-t-shirt-(red)");

        //Shopping Cart
        public By ShoppingCartButton = By.XPath("//a[@class='shopping_cart_link']");
        public By InventoryItemName = By.XPath("//div[@class='inventory_item_name']");

        public By CheckOutButton = By.Id("checkout");
        public By CheckOut_FirstName = By.Id("first-name");
        public By CheckOut_LastName = By.Id("last-name");
        public By CheckOut_ZipCode = By.Id("postal-code");
        public By CheckOut_ContinueButton = By.Id("continue");

        public By PaymentInformation = By.XPath("//div[@class='summary_value_label']");

        // Titles
        public string Itemtitle = "Sauce Labs Onesie";

        BasePage basePage = new BasePage();

        public HomePage AddToShoppingCart(By element)
        {
            Click(element);

            /*
            Click(SauceLabsBikeLight);
            Click(SauceLabsOnesies);
            Click(SauceLabsTShirtRed);
            */

            return this;
        }

        public HomePage OpenShoppingCart()
        {
            Click(ShoppingCartButton);

            return this;
        }

        public HomePage CheckOutProduct()
        {

            Click(CheckOutButton);

            basePage.WaitTime(CheckOut_FirstName);

            EnterText(CheckOut_FirstName, "FirstName");
            EnterText(CheckOut_LastName, "LastName");
            EnterText(CheckOut_ZipCode, "12345");

            Click(CheckOut_ContinueButton);

            return this;
        }

        public HomePage LogOut()
        {
            Click(BurgerMenuButton);
            basePage.WaitTime(LogOutButton);
            Click(LogOutButton);

            return this;
        }

        public string SelectDropDown(SortContainer sort)
        {
            string option = null;

            switch(sort)
            {
                case SortContainer.AtoZ:
                    option = "Name (A to Z)";
                    break;

                case SortContainer.ZtoA:
                    option = "Name (Z to A)";
                    break;

                case SortContainer.LowtoHigh:
                    option = "Price (low to high)";
                    break;

                case SortContainer.HightoLow:
                    option = "Price(high to low)";
                    break;
            }

            return option;
        }
    }

    public enum SortContainer
    {
        AtoZ,
        ZtoA,
        LowtoHigh,
        HightoLow
    }
}