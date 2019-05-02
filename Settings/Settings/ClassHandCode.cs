using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    class ClassHandCode
    {

        public static void Runner()

        {


            UITestControl calcWindow = Microsoft.VisualStudio.TestTools.UITesting.ApplicationUnderTest.Launch("C:/Program Files/SOPAT GmbH/Dashboard/bin/startup/SOPAT_Startup.exe");

            WinWindow UISOPATStartupWindow = new WinWindow(calcWindow);
            UISOPATStartupWindow.SearchProperties[WinWindow.PropertyNames.Name] = "SOPAT - Startup";
            UISOPATStartupWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UISOPATStartupWindow.WindowTitles.Add("SOPAT - Startup");

            WinWindow UIProbeControllerWindow = new WinWindow(UISOPATStartupWindow);
            UIProbeControllerWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonProbeViewer";
            UIProbeControllerWindow.WindowTitles.Add("SOPAT - Startup");

            WinButton UIProbeControllerButton = new WinButton(UIProbeControllerWindow);
            UIProbeControllerButton.SearchProperties[WinButton.PropertyNames.Name] = "Probe Controller";
            UIProbeControllerButton.WindowTitles.Add("SOPAT - Startup");

            Mouse.Click(UIProbeControllerButton);
            Playback.Wait(3000);


            //Step 2

            WinWindow UIProbeControlWindow = new WinWindow();
            UIProbeControlWindow.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            UIProbeControlWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIProbeControlWindow.WindowTitles.Add("ProbeControl");

            WinMenuBar UIMenuStrip1MenuBar = new WinMenuBar(UIProbeControlWindow);
            UIMenuStrip1MenuBar.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            UIMenuStrip1MenuBar.WindowTitles.Add("ProbeControl");
            
            WinMenuItem UISettingsMenuItem = new WinMenuItem(UIMenuStrip1MenuBar);
            UISettingsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Settings";
            UISettingsMenuItem.WindowTitles.Add("ProbeControl");
           
            WinMenuItem UIAdvancedMenuItem = new WinMenuItem(UISettingsMenuItem);
            UIAdvancedMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Advanced...";
            UIAdvancedMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIAdvancedMenuItem.WindowTitles.Add("ProbeControl");


            Mouse.Click(UIAdvancedMenuItem);
            Playback.Wait(5000);


            //Step3

            WinWindow UIAdvancedSettingsWindow = new WinWindow();
            UIAdvancedSettingsWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Advanced Settings";
            UIAdvancedSettingsWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAdvancedSettingsWindow.WindowTitles.Add("Advanced Settings");
            
            WinTitleBar UIAdvancedSettingsTitleBar = new WinTitleBar(UIAdvancedSettingsWindow);
            UIAdvancedSettingsTitleBar.WindowTitles.Add("Advanced Settings");
           
            WinButton UICloseButton = new WinButton(UIAdvancedSettingsTitleBar);
            UICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton.WindowTitles.Add("Advanced Settings");

            Mouse.Click(UICloseButton);
                   
            WinTitleBar UIProbeControlTitleBar = new WinTitleBar(UIProbeControlWindow);
            UIProbeControlTitleBar.WindowTitles.Add("ProbeControl");

            WinButton UICloseButton1 = new WinButton(UIProbeControlTitleBar);
            UICloseButton1.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton1.WindowTitles.Add("ProbeControl");

            // Klicken "Close" Schaltfläche
            Mouse.Click(UICloseButton1);

            // Klicken "Close" Schaltfläche
            //Step 9
            WinTitleBar UISOPATStartupTitleBar = new WinTitleBar(UISOPATStartupWindow);
            UISOPATStartupTitleBar.WindowTitles.Add("SOPAT - Startup");

            WinButton UICloseButton2 = new WinButton(UISOPATStartupTitleBar);
            UICloseButton2.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton2.WindowTitles.Add("SOPAT - Startup");

            Mouse.Click(UICloseButton2);
 
        
        
        }

    }
}
