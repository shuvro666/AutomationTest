﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Dieser Code wurde vom codierten UI-Testbuilder generiert.
//      Version: 11.0.0.0
//
//      In dieser Datei sind spezialisierte Klassen definiert, die in einem
//      codierten UI-Test verwendet werden.
//      In dieser Datei können die erforderlichen Anpassungen vorgenommen werden.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace ConnectAndDisconnectCamera
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Verwenden Sie "RecordedMethod1Params", um Parameter an diese Methode zu übergeben.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinButton uIProbeControllerButton = this.UISOPATStartupWindow.UIProbeControllerWindow.UIProbeControllerButton;
            WinButton uIToolStripButtonConneButton = this.UIProbeControlWindow.UIToolStrip1Window.UIToolStripButtonConneButton;
            WinButton uICloseButton = this.UIProbeControlWindow.UIProbeControlTitleBar.UICloseButton;
            WinButton uICloseButton1 = this.UISOPATStartupWindow.UISOPATStartupTitleBar.UICloseButton;
            #endregion

            // "%ProgramW6432%\SOPAT GmbH\Dashboard\bin\startup\SOPAT_Startup.exe" starten
            ApplicationUnderTest uISOPATStartupWindow = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UISOPATStartupWindowExePath, this.RecordedMethod1Params.UISOPATStartupWindowAlternateExePath);

            // Klicken "Probe Controller" Schaltfläche
            Mouse.Click(uIProbeControllerButton, new Point(81, 17));

            // Klicken "toolStripButtonConnect" Schaltfläche
            Mouse.Click(uIToolStripButtonConneButton, new Point(13, 10));

            // Klicken "Close" Schaltfläche
            Mouse.Click(uICloseButton, new Point(18, 20));

            // Klicken "Close" Schaltfläche
            Mouse.Click(uICloseButton1, new Point(39, 24));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UISOPATStartupWindow UISOPATStartupWindow
        {
            get
            {
                if ((this.mUISOPATStartupWindow == null))
                {
                    this.mUISOPATStartupWindow = new UISOPATStartupWindow();
                }
                return this.mUISOPATStartupWindow;
            }
        }
        
        public UIProbeControlWindow UIProbeControlWindow
        {
            get
            {
                if ((this.mUIProbeControlWindow == null))
                {
                    this.mUIProbeControlWindow = new UIProbeControlWindow();
                }
                return this.mUIProbeControlWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UISOPATStartupWindow mUISOPATStartupWindow;
        
        private UIProbeControlWindow mUIProbeControlWindow;
        #endregion
    }
    
    /// <summary>
    /// An "RecordedMethod1" zu übergebende Parameter
    /// </summary>
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// "%ProgramW6432%\SOPAT GmbH\Dashboard\bin\startup\SOPAT_Startup.exe" starten
        /// </summary>
        public string UISOPATStartupWindowExePath = "C:\\Program Files\\SOPAT GmbH\\Dashboard\\bin\\startup\\SOPAT_Startup.exe";
        
        /// <summary>
        /// "%ProgramW6432%\SOPAT GmbH\Dashboard\bin\startup\SOPAT_Startup.exe" starten
        /// </summary>
        public string UISOPATStartupWindowAlternateExePath = "%ProgramW6432%\\SOPAT GmbH\\Dashboard\\bin\\startup\\SOPAT_Startup.exe";
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UISOPATStartupWindow : WinWindow
    {
        
        public UISOPATStartupWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SOPAT - Startup";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("SOPAT - Startup");
            #endregion
        }
        
        #region Properties
        public UIProbeControllerWindow UIProbeControllerWindow
        {
            get
            {
                if ((this.mUIProbeControllerWindow == null))
                {
                    this.mUIProbeControllerWindow = new UIProbeControllerWindow(this);
                }
                return this.mUIProbeControllerWindow;
            }
        }
        
        public UISOPATStartupTitleBar UISOPATStartupTitleBar
        {
            get
            {
                if ((this.mUISOPATStartupTitleBar == null))
                {
                    this.mUISOPATStartupTitleBar = new UISOPATStartupTitleBar(this);
                }
                return this.mUISOPATStartupTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIProbeControllerWindow mUIProbeControllerWindow;
        
        private UISOPATStartupTitleBar mUISOPATStartupTitleBar;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIProbeControllerWindow : WinWindow
    {
        
        public UIProbeControllerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonProbeViewer";
            this.WindowTitles.Add("SOPAT - Startup");
            #endregion
        }
        
        #region Properties
        public WinButton UIProbeControllerButton
        {
            get
            {
                if ((this.mUIProbeControllerButton == null))
                {
                    this.mUIProbeControllerButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUIProbeControllerButton.SearchProperties[WinButton.PropertyNames.Name] = "Probe Controller";
                    this.mUIProbeControllerButton.WindowTitles.Add("SOPAT - Startup");
                    #endregion
                }
                return this.mUIProbeControllerButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIProbeControllerButton;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UISOPATStartupTitleBar : WinTitleBar
    {
        
        public UISOPATStartupTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.WindowTitles.Add("SOPAT - Startup");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("SOPAT - Startup");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIProbeControlWindow : WinWindow
    {
        
        public UIProbeControlWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ProbeControl");
            #endregion
        }
        
        #region Properties
        public UIToolStrip1Window UIToolStrip1Window
        {
            get
            {
                if ((this.mUIToolStrip1Window == null))
                {
                    this.mUIToolStrip1Window = new UIToolStrip1Window(this);
                }
                return this.mUIToolStrip1Window;
            }
        }
        
        public UIProbeControlTitleBar UIProbeControlTitleBar
        {
            get
            {
                if ((this.mUIProbeControlTitleBar == null))
                {
                    this.mUIProbeControlTitleBar = new UIProbeControlTitleBar(this);
                }
                return this.mUIProbeControlTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIToolStrip1Window mUIToolStrip1Window;
        
        private UIProbeControlTitleBar mUIProbeControlTitleBar;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIToolStrip1Window : WinWindow
    {
        
        public UIToolStrip1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "toolStrip1";
            this.WindowTitles.Add("ProbeControl");
            #endregion
        }
        
        #region Properties
        public WinButton UIToolStripButtonConneButton
        {
            get
            {
                if ((this.mUIToolStripButtonConneButton == null))
                {
                    this.mUIToolStripButtonConneButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUIToolStripButtonConneButton.SearchProperties[WinButton.PropertyNames.Name] = "toolStripButtonConnect";
                    this.mUIToolStripButtonConneButton.WindowTitles.Add("ProbeControl");
                    #endregion
                }
                return this.mUIToolStripButtonConneButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIToolStripButtonConneButton;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIProbeControlTitleBar : WinTitleBar
    {
        
        public UIProbeControlTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.WindowTitles.Add("ProbeControl");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("ProbeControl");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}