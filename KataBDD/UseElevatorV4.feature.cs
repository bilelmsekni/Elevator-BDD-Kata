﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Elevator
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UseElevatorV4")]
    public partial class UseElevatorV4Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UseElevatorV4.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UseElevatorV4", "In order to test my elevator\r\nAs a manufacturer\r\nI want to have multiple users wi" +
                    "th different needs", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
 #line 8
 testRunner.Given("the elevator is on the 0 floor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MultipleUsers")]
        [NUnit.Framework.CategoryAttribute("version4")]
        public virtual void MultipleUsers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MultipleUsers", new string[] {
                        "version4"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "CurrentFloor",
                        "GoingTo"});
            table1.AddRow(new string[] {
                        "Matt",
                        "1",
                        "0"});
            table1.AddRow(new string[] {
                        "Scott",
                        "0",
                        "3"});
            table1.AddRow(new string[] {
                        "Emily",
                        "3",
                        "0"});
#line 12
 testRunner.When("the following elevator users:", ((string)(null)), table1, "When ");
#line 17
 testRunner.And("the elevator operates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Floor"});
            table2.AddRow(new string[] {
                        "1"});
            table2.AddRow(new string[] {
                        "0"});
            table2.AddRow(new string[] {
                        "3"});
#line 18
 testRunner.Then("the elevator will open its door in this order:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MultipleUsersWithDifferentNeeds")]
        [NUnit.Framework.CategoryAttribute("version4")]
        public virtual void MultipleUsersWithDifferentNeeds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MultipleUsersWithDifferentNeeds", new string[] {
                        "version4"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "CurrentFloor",
                        "GoingTo"});
            table3.AddRow(new string[] {
                        "Matt",
                        "1",
                        "2"});
            table3.AddRow(new string[] {
                        "Scott",
                        "0",
                        "3"});
            table3.AddRow(new string[] {
                        "Emily",
                        "-1",
                        "2"});
#line 27
 testRunner.When("the following elevator users:", ((string)(null)), table3, "When ");
#line 32
 testRunner.And("the elevator operates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Floor"});
            table4.AddRow(new string[] {
                        "1"});
            table4.AddRow(new string[] {
                        "2"});
            table4.AddRow(new string[] {
                        "0"});
            table4.AddRow(new string[] {
                        "-1"});
            table4.AddRow(new string[] {
                        "2"});
            table4.AddRow(new string[] {
                        "3"});
#line 33
 testRunner.Then("the elevator will open its door in this order:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
