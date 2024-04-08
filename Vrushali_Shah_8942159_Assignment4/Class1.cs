﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class InsuranceQuoteTests
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    string baseURL = "http://localhost/prog8171a04/";

    [Test]
    public void InsuranceQuote01_VS_25and3and0_Quote4500()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("198 N Park St");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("Vshah2159@conestogac.on.ca");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$4500"));
        }
    }
    [Test]
    public void InsuranceQuote02_VS_25and3and2_Quote4500()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$4500"));
        }
    }
    [Test]
    public void InsuranceQuote03_VS_35and10and4_QuoteNoInsurance()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(3)")).Click();
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void InsuranceQuote04_VS_27and3and0_PhoneInvalid()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("1234567890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    }
    [Test]
    public void InsuranceQuote05_VS_28and3and0_EmailInvalid()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hshshs");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }
    [Test]
    public void InsuranceQuote06_VS_35and17and1_PostalCodeInvalid()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("NYYYY1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }
    [Test]
    public void InsuranceQuote07_VS_Omitand5and0_AgeOmit()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }
    [Test]
    public void InsuranceQuote08_VS_37and8andOmit_AccidentsOmit()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void InsuranceQuote09_VS_45andOmitand0_DrivingExpOmit()
    {

        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1105, 720);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Vrushali");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Shah");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("349, Huron Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4J1");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7890");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }
}
