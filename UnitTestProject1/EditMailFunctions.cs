using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace MaslavyevAM
{
    public class EditMailFunctions : CommonFunctions
    {
        public EditMailFunctions(Manager manager) : base(manager) 
        { }

        

        public void EditEmail() 
        {
            driver.FindElement(By.Name("p_email")).Click();
            driver.FindElement(By.Name("p_email")).Clear();
            driver.FindElement(By.Name("p_email")).SendKeys("erasumus@mail.ru");
            driver.FindElement(By.CssSelector("input[type=\"button\"]")).Click();
            
        }

        public bool Email()
        {
            return IsElementPresent(By.LinkText("erasumus@mail.ru"));
        }

        public bool Telephone()
        {
            return IsElementPresent(By.LinkText("89053716207"));
        }

        public bool AssertEmailCorrect()
        {
            return Email() && Telephone() == true;
        }

        public bool AssertEmailError()
        {
            return Email() && Telephone() == false;
        }

    }
}
