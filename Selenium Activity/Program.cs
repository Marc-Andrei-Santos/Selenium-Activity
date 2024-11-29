// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://ph.jobstreet.com/");

        var searchJob = driver.FindElement(By.Name("keywords"));
        searchJob.SendKeys("Selenium");

        var searchWhere = driver.FindElement(By.Name("where"));
        searchWhere.SendKeys("Oriental Mindoro");

        searchJob.Submit();


        if (driver.Url.Contains("keywords=Selenium") && driver.Url.Contains("where=Oriental+Mindoro"))
        {
            Console.WriteLine("Test Passed!");
        }
        else
        {
            Console.WriteLine("Test Failed!");
        }
    }
}
