using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.PageObjects
{
    public class LoginPage : BasePage
    {
        public By UserEmail = By.Id("user-name");
        public By UserPassword = By.Id("password");
        public By LoginButton = By.Id("login-button");
        public By ErrorMessageTitle = By.XPath("//h3[@data-test='error']");

        public LoginPage UserLogin(string userEmail, string userPassword)
        {
            EnterText(UserEmail, userEmail);
            EnterText(UserPassword, userPassword);
            Click(LoginButton);

            return this;
        }
    }
}