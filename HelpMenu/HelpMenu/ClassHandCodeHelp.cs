using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMenu
{
    class ClassHandCodeHelp
    {

        public static void HelpRunner()
        
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

            WinMenuItem UIHelpMenuItem = new WinMenuItem(UIMenuStrip1MenuBar);
            UIHelpMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Help";
            Playback.Wait(5000);

            WinMenuItem UIAboutMenuItem = new WinMenuItem(UIHelpMenuItem);
            UIAboutMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "About";
            Playback.Wait(5000);

            UIAboutMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            Mouse.Click(UIAboutMenuItem);
            Playback.Wait(10000);

            //Step 4

            WinWindow UIAboutWindow = new WinWindow();
            UIAboutWindow.SearchProperties[WinWindow.PropertyNames.Name] = "About";
            UIAboutWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAboutWindow.WindowTitles.Add("About");
           
            WinWindow UIOKWindow = new WinWindow(UIAboutWindow);
            UIOKWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            UIOKWindow.WindowTitles.Add("About");
            
            WinButton UIOKButton = new WinButton(UIOKWindow);
            UIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
            UIOKButton.WindowTitles.Add("About");

            Mouse.Click(UIOKButton);
            //Step 8

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
