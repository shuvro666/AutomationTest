using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    class ClassHandCodedSettings
    {
        public static void ClickMe()
        {

            UITestControl SOPATEXE = Microsoft.VisualStudio.TestTools.UITesting.ApplicationUnderTest.Launch("C:/Program Files/SOPAT GmbH/Dashboard/bin/startup/SOPAT_Startup.exe");

            WinWindow UISOPATStartupWindow = new WinWindow(SOPATEXE);
            UISOPATStartupWindow.SearchProperties[WinWindow.PropertyNames.Name] = "SOPAT - Startup";
            UISOPATStartupWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));

            WinWindow UIProbeControllerWindow = new WinWindow(UISOPATStartupWindow);
            UIProbeControllerWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonProbeViewer";

            WinButton UIProbeControllerButton = new WinButton(UIProbeControllerWindow);
            UIProbeControllerButton.SearchProperties[WinButton.PropertyNames.Name] = "Probe Controller";

            Mouse.Click(UIProbeControllerButton);


            WinWindow UIProbeControlWindow = new WinWindow();
            UIProbeControlWindow.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            UIProbeControlWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));


            WinMenuBar UIMenuStrip1MenuBar = new WinMenuBar(UIProbeControlWindow);
            UIMenuStrip1MenuBar.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";


            WinMenuItem UISettingsMenuItem = new WinMenuItem();
            UISettingsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Settings";


            WinMenuItem UIAdvancedMenuItem = new WinMenuItem(UIMenuStrip1MenuBar);
            UIAdvancedMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Advanced...";
            UIAdvancedMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);

            Mouse.Click(UIAdvancedMenuItem);
           



        }
    }
}