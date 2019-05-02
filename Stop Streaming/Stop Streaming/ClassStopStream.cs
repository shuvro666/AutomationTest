using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Streaming
{
    class ClassStopStream
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

            // Klicken "Actions" -> "Connect/Disconnect..." Menüelement
            WinWindow UIProbeControlWindow = new WinWindow();
            UIProbeControlWindow.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            UIProbeControlWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIProbeControlWindow.WindowTitles.Add("ProbeControl");
            
            WinMenuItem UIActionsMenuItem = new WinMenuItem(UIProbeControlWindow);
            UIActionsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Actions";
            UIActionsMenuItem.WindowTitles.Add("ProbeControl");

            WinMenuItem UIConnectDisconnectMenuItem = new WinMenuItem(UIActionsMenuItem);
            UIConnectDisconnectMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Connect/Disconnect...";
            UIConnectDisconnectMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIConnectDisconnectMenuItem.WindowTitles.Add("ProbeControl");
            
            Mouse.Click(UIConnectDisconnectMenuItem);

            // Klicken "Actions" -> "Start/Stop streaming..." Menüelement

            WinMenuItem UIStartStopstreamingMenuItem = new WinMenuItem(UIActionsMenuItem);
            UIStartStopstreamingMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Start/Stop streaming...";
            UIStartStopstreamingMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIStartStopstreamingMenuItem.WindowTitles.Add("ProbeControl");
           
            // Klicken "Actions" -> "Start/Stop streaming..." Menüelement
            Mouse.Click(UIStartStopstreamingMenuItem);
            Playback.Wait(5000);
            Playback.Cleanup();

        
        }

    }
}
