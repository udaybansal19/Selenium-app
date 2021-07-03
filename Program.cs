using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test case started ");
            IWebDriver driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            Thread.Sleep(2000);

            // First Name
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[2]/input")).SendKeys("Uday");

            //  Last Name
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[3]/input")).SendKeys("Bansal");

            // Gender
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[4]/div/input[1]")).Click();

            // DOB
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[5]/input")).SendKeys("1999-12-19");

            // Mobile
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[6]/input")).SendKeys("8745054733");

            // Email
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[7]/input")).SendKeys("udaybansal19@gmail.com");


            // Agree to terms and conditions
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[3]/div/input")).Click();


            Thread.Sleep(5000);


            // Click on submit button
            driver.FindElement(By.XPath("/html/body/div[1]/form/div[4]/button[1]")).Click();


            Console.Write("Test case ended");
        }
    }
}
