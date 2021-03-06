﻿using System;
using TechTalk.SpecFlow;
using Training8A.PageObjects;
using Training8A.Utilities;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;

        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"Click on register link")]
        public void WhenClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }


        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the click on signUp")]
        public void WhenTheClickOnSignUp()
        {
            registration.ClickSignUP();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
