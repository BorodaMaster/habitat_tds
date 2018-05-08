﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Media.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class VideoInMediaCarouselFeature : Xunit.IClassFixture<VideoInMediaCarouselFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Video in Media Carousel.feature"
#line hidden
        
        public VideoInMediaCarouselFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Video in Media Carousel", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(VideoInMediaCarouselFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC1_Review default video item")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC1_ReviewDefaultVideoItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC1_Review default video item", new string[] {
                        "NeedIMplementation"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table1.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 9
 testRunner.Then("Following video presents", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC2_New video was added to Carousel")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC2_NewVideoWasAddedToCarousel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC2_New video was added to Carousel", new string[] {
                        "NeedIMplementation"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video test source"});
            table2.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 18
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Image test source"});
            table3.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\HabitatTest.jpg"});
#line 22
 testRunner.And("<Sitecore CMS.mp4> thumbnail should be added to Media library Habitat, Saved and " +
                    "Published", ((string)(null)), table3, "And ");
#line 26
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("User inserts <Sitecore CMS.mp4 path> into Link to video: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("User inserts <Habitat-001-wide path> image into Thumbnail field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table4.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
            table4.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 39
 testRunner.And("Following video presents", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table5.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 43
 testRunner.And("Following thumbnail presents", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC3_New video was added to Carousel_Link to video field i" +
            "s empty and thumbnail filled")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC3_NewVideoWasAddedToCarousel_LinkToVideoFieldIsEmptyAndThumbnailFilled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC3_New video was added to Carousel_Link to video field i" +
                    "s empty and thumbnail filled", new string[] {
                        "NeedIMplementation"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Image test source"});
            table6.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\HabitatTest.jpg"});
#line 51
 testRunner.And("<Sitecore CMS.mp4> thumbnail should be added to Media library Habitat, Saved and " +
                    "Published", ((string)(null)), table6, "And ");
#line 54
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("User inserts <Habitat-001-wide path> image into Thumbnail field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table7.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 66
 testRunner.And("Following video presents", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table8.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 69
 testRunner.And("Following video absents", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table9.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 72
 testRunner.And("Following thumbnail presents", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC4_New video was added to Carousel_Link to video field i" +
            "s empty and thumbnail empty")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC4_NewVideoWasAddedToCarousel_LinkToVideoFieldIsEmptyAndThumbnailEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC4_New video was added to Carousel_Link to video field i" +
                    "s empty and thumbnail empty", new string[] {
                        "NeedIMplementation"});
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video source"});
            table10.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 79
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table10, "And ");
#line 83
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table11.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 94
 testRunner.And("Following video presents", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table12.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 97
 testRunner.And("Following video absents", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table13.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 100
 testRunner.And("Following thumbnail absents", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC5_New video was added to Carousel_Link to video field i" +
            "s filled and thumbnail empty")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC5_NewVideoWasAddedToCarousel_LinkToVideoFieldIsFilledAndThumbnailEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC5_New video was added to Carousel_Link to video field i" +
                    "s filled and thumbnail empty", new string[] {
                        "NeedIMplementation"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video source"});
            table14.AddRow(new string[] {
                        "\\Habitat\\src\\Domain\\Navigation\\specs\\TestData\\Media Carousel\\Sitecore CMS.mp4"});
#line 107
 testRunner.And("<Sitecore CMS.mp4> video should be added to Media library Habitat, Saved and Publ" +
                    "ished", ((string)(null)), table14, "And ");
#line 111
 testRunner.When("User starts Video item creation under Habitat Shared Media", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.And("User inserts <Sitecore CMS.mp4 path> into Link to video: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("User moves <Sitecore CMS.mp4> item to Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table15.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
            table15.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore CMS.mp4"});
#line 123
 testRunner.And("Following video presents", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Thumbnail path"});
            table16.AddRow(new string[] {
                        "/-/media/Habitat/Images/Wide/HabitatTest.jpg"});
#line 127
 testRunner.And("Following thumbnail absents", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Video in Media Carousel")]
        [Xunit.TraitAttribute("Description", "Video in Media Carousel_UC6_Video was removed from carousel")]
        [Xunit.TraitAttribute("Category", "NeedIMplementation")]
        public virtual void VideoInMediaCarousel_UC6_VideoWasRemovedFromCarousel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Video in Media Carousel_UC6_Video was removed from carousel", new string[] {
                        "NeedIMplementation"});
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
 testRunner.Given("Habitat Content Editor was opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
 testRunner.When("And User selects Carousel item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.And("User removes <Sitecore-Experience.mp4> item from Selected section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("User clicks Save button on Content Editor Ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("User publishes /sitecore/content/Shared/Media item with sub-items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("User opens Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.Then("Carousel element presents at Habitat Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Video path"});
            table17.AddRow(new string[] {
                        "/-/media/Habitat/Videos/Sitecore-Experience.mp4"});
#line 142
 testRunner.And("Following video absents", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                VideoInMediaCarouselFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                VideoInMediaCarouselFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
