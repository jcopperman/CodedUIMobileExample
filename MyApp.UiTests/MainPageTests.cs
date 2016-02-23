using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace MyApp.UiTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class MainPageTests
    {
        public MainPageTests()
        {
        }

        [TestMethod]
        public void MyApp_WhenLaunched_TextIsBlockDisplayed()
        {
            XamlWindow myAppWindow = XamlWindow.Launch("2f97ff00-c4d4-40e2-bb45-4fa1a9a867b8_b3r19t9dwpk1r!App");
         
            var textBlockText = this.UIMap.UIMyAppWindow.UITextBlockText.DisplayText;

            Assert.AreEqual("TextBlock", textBlockText);
        }

        [TestMethod]
        public void MessageDialog_WhenButtonClicked_ButtonTextIsYes()
        {
            XamlWindow myAppWindow = XamlWindow.Launch("2f97ff00-c4d4-40e2-bb45-4fa1a9a867b8_b3r19t9dwpk1r!App");

            var btn = this.UIMap.UIMyAppWindow.UIButtonButton;          

            Gesture.Tap(btn);

            var messagedialog = this.UIMap.UILoremIpsumWindow.Name;

            Assert.AreEqual("Lorem Ipsum", messagedialog);         
        }

        [TestMethod]
        public void MessageDialog_WhenButtonClicked_ShowPopupTextDisplaysYes()
        {
            XamlWindow myAppWindow = XamlWindow.Launch("2f97ff00-c4d4-40e2-bb45-4fa1a9a867b8_b3r19t9dwpk1r!App");

            var btn = this.UIMap.UIMyAppWindow.UIButtonButton;
            
            Gesture.Tap(btn);

            var yesBtn = this.UIMap.UILoremIpsumWindow.UIButtonBarToolBar.UIYesButton;

            Gesture.Tap(yesBtn);

            var messagedialog = this.UIMap.UILoremIpsumWindow.Name;

            Assert.AreEqual("Result: Yes (0)", btn.DisplayText);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
