using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndDisconnectCamera
{
    class ClassDisconnectButton
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
            // Klicken "Actions" -> "Connect/Disconnect..." Menüelement


            //Step 2

            WinWindow UIProbeControlWindow = new WinWindow();
            UIProbeControlWindow.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            UIProbeControlWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIProbeControlWindow.WindowTitles.Add("ProbeControl");

            WinMenuBar UIMenuStrip1MenuBar = new WinMenuBar(UIProbeControlWindow);
            UIMenuStrip1MenuBar.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            UIMenuStrip1MenuBar.WindowTitles.Add("ProbeControl");

            WinMenuItem UIActionsMenuItem = new WinMenuItem(UIMenuStrip1MenuBar);
            UIActionsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Actions";
            UIActionsMenuItem.WindowTitles.Add("ProbeControl");

            WinMenuItem UIConnectDisconnectMenuItem = new WinMenuItem(UIActionsMenuItem);
            UIConnectDisconnectMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Connect/Disconnect...";
            UIConnectDisconnectMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIConnectDisconnectMenuItem.WindowTitles.Add("ProbeControl");


            Mouse.Click(UIConnectDisconnectMenuItem);
            Playback.Wait(3000);
            // Klicken "Actions" -> "Connect/Disconnect..." Menüelement
            Mouse.Click(UIConnectDisconnectMenuItem);
            Playback.Wait(5000);

            //Close pc
            WinTitleBar UIProbeControlTitleBar = new WinTitleBar(UIProbeControlWindow);
            UIProbeControlTitleBar.WindowTitles.Add("ProbeControl");

            WinButton UICloseButton = new WinButton(UIProbeControlTitleBar);
            UICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton.WindowTitles.Add("ProbeControl");

            Mouse.Click(UICloseButton);

            //Close dashboar
            // Klicken "Close" Schaltfläche
            WinTitleBar UISOPATStartupTitleBar = new WinTitleBar(UISOPATStartupWindow);
            UISOPATStartupTitleBar.WindowTitles.Add("SOPAT - Startup");

            WinButton UICloseButton1 = new WinButton(UISOPATStartupTitleBar);
            UICloseButton1.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton1.WindowTitles.Add("SOPAT - Startup");

            Mouse.Click(UICloseButton1);
        
        }

    }
}
