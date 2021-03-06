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

namespace CloseMultipleSnapShotWindows
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
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinMenuItem uICloseallwindowsMenuItem = this.UIProbeControlWindow.UIMenuStrip1MenuBar.UIViewMenuItem.UICloseallwindowsMenuItem;
            #endregion

            // Klicken "View" -> "Close all windows" Menüelement
            Mouse.Click(uICloseallwindowsMenuItem, new Point(44, 8));
        }
        
        #region Properties
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
        private UIProbeControlWindow mUIProbeControlWindow;
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
        public UIMenuStrip1MenuBar UIMenuStrip1MenuBar
        {
            get
            {
                if ((this.mUIMenuStrip1MenuBar == null))
                {
                    this.mUIMenuStrip1MenuBar = new UIMenuStrip1MenuBar(this);
                }
                return this.mUIMenuStrip1MenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuStrip1MenuBar mUIMenuStrip1MenuBar;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIMenuStrip1MenuBar : WinMenuBar
    {
        
        public UIMenuStrip1MenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            this.WindowTitles.Add("ProbeControl");
            #endregion
        }
        
        #region Properties
        public UIViewMenuItem UIViewMenuItem
        {
            get
            {
                if ((this.mUIViewMenuItem == null))
                {
                    this.mUIViewMenuItem = new UIViewMenuItem(this);
                }
                return this.mUIViewMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIViewMenuItem mUIViewMenuItem;
        #endregion
    }
    
    [GeneratedCode("Test-Generator für codierte UI", "11.0.50727.1")]
    public class UIViewMenuItem : WinMenuItem
    {
        
        public UIViewMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "View";
            this.WindowTitles.Add("ProbeControl");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UICloseallwindowsMenuItem
        {
            get
            {
                if ((this.mUICloseallwindowsMenuItem == null))
                {
                    this.mUICloseallwindowsMenuItem = new WinMenuItem(this);
                    #region Suchkriterien
                    this.mUICloseallwindowsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Close all windows";
                    this.mUICloseallwindowsMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUICloseallwindowsMenuItem.WindowTitles.Add("ProbeControl");
                    #endregion
                }
                return this.mUICloseallwindowsMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUICloseallwindowsMenuItem;
        #endregion
    }
}
