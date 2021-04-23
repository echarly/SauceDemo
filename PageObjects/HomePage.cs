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
        public By SauceLabsOnesies = By.Id("add-to-cart-sauce-labs-onesie");
        public By SauceLabsTShirtRed = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");

        // Remove - Shopping Cart Items
        public By RemoveSauceLabsBackPack = By.Id("remove-sauce-labs-backpack");
        public By RemoveSauceLabsBikeLight = By.Id("remove-sauce-labs-bike-light");
        public By RemoveSauceLabsOnesies = By.Id("remove-sauce-labs-onesie");
        public By RemoveSauceLabsTShirtRed = By.Id("remove-test.allthethings()-t-shirt-(red)");

        //Shopping Cart
        public By ShoppingCartButton = By.XPath("//a[@class='shopping_cart_link']");

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