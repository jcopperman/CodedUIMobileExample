﻿namespace MyApp.UiTests
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITest.Input;
    using MouseButtons = Microsoft.VisualStudio.TestTools.UITest.Input.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
    using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
    public partial class UIMap
    {
        #region Properties
        public UIMyAppWindow UIMyAppWindow
        {
            get
            {
                if ((this.mUIMyAppWindow == null))
                {
                    this.mUIMyAppWindow = new UIMyAppWindow();
                }
                return this.mUIMyAppWindow;
            }
        }

        public UILoremIpsumWindow UILoremIpsumWindow
        {
            get
            {
                if ((this.mUILoremIpsumWindow == null))
                {
                    this.mUILoremIpsumWindow = new UILoremIpsumWindow();
                }
                return this.mUILoremIpsumWindow;
            }
        }
        #endregion

        #region Fields
        private UIMyAppWindow mUIMyAppWindow;

        private UILoremIpsumWindow mUILoremIpsumWindow;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMyAppWindow : Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls.XamlWindow
    {

        public UIMyAppWindow()
        {
            #region Search Criteria
            this.SearchProperties[XamlControl.PropertyNames.Name] = "MyApp";
            this.SearchProperties[XamlControl.PropertyNames.ClassName] = "Windows.UI.Core.CoreWindow";
            this.WindowTitles.Add("MyApp");
            #endregion
        }

        #region Properties
        public XamlText UITextBlockText
        {
            get
            {
                if ((this.mUITextBlockText == null))
                {
                    this.mUITextBlockText = new XamlText(this);
                    #region Search Criteria
                    this.mUITextBlockText.SearchProperties[XamlText.PropertyNames.AutomationId] = "textBlock";
                    this.mUITextBlockText.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUITextBlockText;
            }
        }

        public XamlEdit UITextBoxEdit
        {
            get
            {
                if ((this.mUITextBoxEdit == null))
                {
                    this.mUITextBoxEdit = new XamlEdit(this);
                    #region Search Criteria
                    this.mUITextBoxEdit.SearchProperties[XamlEdit.PropertyNames.AutomationId] = "textBox";
                    this.mUITextBoxEdit.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUITextBoxEdit;
            }
        }

        public UIListViewList UIListViewList
        {
            get
            {
                if ((this.mUIListViewList == null))
                {
                    this.mUIListViewList = new UIListViewList(this);
                }
                return this.mUIListViewList;
            }
        }

        public UITimepickerGroup UITimepickerGroup
        {
            get
            {
                if ((this.mUITimepickerGroup == null))
                {
                    this.mUITimepickerGroup = new UITimepickerGroup(this);
                }
                return this.mUITimepickerGroup;
            }
        }

        public UIDatepickerGroup UIDatepickerGroup
        {
            get
            {
                if ((this.mUIDatepickerGroup == null))
                {
                    this.mUIDatepickerGroup = new UIDatepickerGroup(this);
                }
                return this.mUIDatepickerGroup;
            }
        }

        public XamlComboBox UIComboBoxComboBox
        {
            get
            {
                if ((this.mUIComboBoxComboBox == null))
                {
                    this.mUIComboBoxComboBox = new XamlComboBox(this);
                    #region Search Criteria
                    this.mUIComboBoxComboBox.SearchProperties[XamlComboBox.PropertyNames.AutomationId] = "comboBox";
                    this.mUIComboBoxComboBox.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIComboBoxComboBox;
            }
        }

        public XamlCheckBox UICheckBoxCheckBox
        {
            get
            {
                if ((this.mUICheckBoxCheckBox == null))
                {
                    this.mUICheckBoxCheckBox = new XamlCheckBox(this);
                    #region Search Criteria
                    this.mUICheckBoxCheckBox.SearchProperties[XamlCheckBox.PropertyNames.AutomationId] = "checkBox";
                    this.mUICheckBoxCheckBox.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUICheckBoxCheckBox;
            }
        }

        public XamlRadioButton UIRadioButtonRadioButton
        {
            get
            {
                if ((this.mUIRadioButtonRadioButton == null))
                {
                    this.mUIRadioButtonRadioButton = new XamlRadioButton(this);
                    #region Search Criteria
                    this.mUIRadioButtonRadioButton.SearchProperties[XamlRadioButton.PropertyNames.AutomationId] = "radioButton";
                    this.mUIRadioButtonRadioButton.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIRadioButtonRadioButton;
            }
        }

        public XamlButton UIButtonButton
        {
            get
            {
                if ((this.mUIButtonButton == null))
                {
                    this.mUIButtonButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUIButtonButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "button";
                    this.mUIButtonButton.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIButtonButton;
            }
        }
        #endregion

        #region Fields
        private XamlText mUITextBlockText;

        private XamlEdit mUITextBoxEdit;

        private UIListViewList mUIListViewList;

        private UITimepickerGroup mUITimepickerGroup;

        private UIDatepickerGroup mUIDatepickerGroup;

        private XamlComboBox mUIComboBoxComboBox;

        private XamlCheckBox mUICheckBoxCheckBox;

        private XamlRadioButton mUIRadioButtonRadioButton;

        private XamlButton mUIButtonButton;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIListViewList : XamlList
    {

        public UIListViewList(XamlControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[XamlList.PropertyNames.AutomationId] = "listView";
            this.WindowTitles.Add("MyApp");
            #endregion
        }

        #region Properties
        public XamlListItem UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new XamlListItem(this);
                    #region Search Criteria
                    this.mUIItemListItem.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIItemListItem;
            }
        }

        public XamlListItem UIItemListItem1
        {
            get
            {
                if ((this.mUIItemListItem1 == null))
                {
                    this.mUIItemListItem1 = new XamlListItem(this);
                    #region Search Criteria
                    this.mUIItemListItem1.SearchProperties[XamlListItem.PropertyNames.Instance] = "2";
                    this.mUIItemListItem1.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIItemListItem1;
            }
        }
        #endregion

        #region Fields
        private XamlListItem mUIItemListItem;

        private XamlListItem mUIItemListItem1;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITimepickerGroup : XamlControl
    {

        public UITimepickerGroup(XamlControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Group";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "time picker";
            this.WindowTitles.Add("MyApp");
            #endregion
        }

        #region Properties
        public XamlButton UIItemtimepickerButton
        {
            get
            {
                if ((this.mUIItemtimepickerButton == null))
                {
                    this.mUIItemtimepickerButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUIItemtimepickerButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "FlyoutButton";
                    this.mUIItemtimepickerButton.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIItemtimepickerButton;
            }
        }
        #endregion

        #region Fields
        private XamlButton mUIItemtimepickerButton;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDatepickerGroup : XamlControl
    {

        public UIDatepickerGroup(XamlControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Group";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "date picker";
            this.WindowTitles.Add("MyApp");
            #endregion
        }

        #region Properties
        public XamlButton UIdatepiButton
        {
            get
            {
                if ((this.mUIdatepiButton == null))
                {
                    this.mUIdatepiButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUIdatepiButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "FlyoutButton";
                    this.mUIdatepiButton.WindowTitles.Add("MyApp");
                    #endregion
                }
                return this.mUIdatepiButton;
            }
        }
        #endregion

        #region Fields
        private XamlButton mUIdatepiButton;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UILoremIpsumWindow : UITestControl
    {

        public UILoremIpsumWindow()
        {
            #region Search Criteria
            this.TechnologyName = "UIA";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Window";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Lorem Ipsum";
            this.SearchProperties["FrameworkId"] = "Win32";
            this.WindowTitles.Add("Lorem Ipsum");
            #endregion
        }

        #region Properties
        public UIButtonBarToolBar UIButtonBarToolBar
        {
            get
            {
                if ((this.mUIButtonBarToolBar == null))
                {
                    this.mUIButtonBarToolBar = new UIButtonBarToolBar(this);
                }
                return this.mUIButtonBarToolBar;
            }
        }
        #endregion

        #region Fields
        private UIButtonBarToolBar mUIButtonBarToolBar;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIButtonBarToolBar : DirectUIControl
    {

        public UIButtonBarToolBar(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[DirectUIControl.PropertyNames.AutomationId] = "ButtonBar";
            this.WindowTitles.Add("Lorem Ipsum");
            #endregion
        }

        #region Properties
        public DirectUIControl UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new DirectUIControl(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[DirectUIControl.PropertyNames.AutomationId] = "Button2";
                    this.mUIYesButton.WindowTitles.Add("Lorem Ipsum");
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion

        #region Fields
        private DirectUIControl mUIYesButton;
        #endregion
    }
}
