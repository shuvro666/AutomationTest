using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAndStopTriggerAcquisition
{
    class StopTriggerAcquisition
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


            //2nd step

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


            //3rd step

            WinWindow UITabControl1Window = new WinWindow(UIProbeControlWindow);
            UITabControl1Window.SearchProperties[WinWindow.PropertyNames.ControlName] = "tabControl1";
            UITabControl1Window.WindowTitles.Add("ProbeControl");
            
            WinTabList UICurrentpositionTabList = new WinTabList(UITabControl1Window); 
            UICurrentpositionTabList.SearchProperties[WinTabList.PropertyNames.Name] = "Current position";
            UICurrentpositionTabList.WindowTitles.Add("ProbeControl");
            
            WinTabPage UITriggeringTabPage = new WinTabPage(UICurrentpositionTabList);
            UITriggeringTabPage.SearchProperties[WinTabPage.PropertyNames.Name] = "Triggering";
            UITriggeringTabPage.WindowTitles.Add("ProbeControl");

            Mouse.Click(UITriggeringTabPage);

            //Step 4
            // "10" in "textNumberOfTriggers" Textfeld eingeben

            WinWindow UIItem1Window = new WinWindow(UIProbeControlWindow);
            UIItem1Window.SearchProperties[WinWindow.PropertyNames.ControlName] = "textNumberOfTriggers";
            UIItem1Window.WindowTitles.Add("ProbeControl");
          
            WinEdit UITextNumberOfTriggersEdit = new WinEdit(UIItem1Window);
            UITextNumberOfTriggersEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Frames per trigger [-]";
            UITextNumberOfTriggersEdit.WindowTitles.Add("ProbeControl");

            UITextNumberOfTriggersEdit.Text = "10";

            // "{Enter}" in "textNumberOfTriggers" Textfeld eingeben
            Keyboard.SendKeys(UITextNumberOfTriggersEdit, "{Enter}");

            // Step 5
            //"5" in "textFramesPerTrigger" Textfeld eingeben
            WinWindow UIItem1Window1 = new WinWindow(UIProbeControlWindow);
            UIItem1Window1.SearchProperties[WinWindow.PropertyNames.ControlName] = "textFramesPerTrigger";
            UIItem1Window1.WindowTitles.Add("ProbeControl");
            
            WinEdit UITextFramesPerTriggerEdit = new WinEdit(UIItem1Window1);
            UITextFramesPerTriggerEdit.WindowTitles.Add("ProbeControl");

            UITextFramesPerTriggerEdit.Text = "5";

            // "{Enter}" in "textFramesPerTrigger" Textfeld eingeben
            Keyboard.SendKeys(UITextFramesPerTriggerEdit, "{Enter}");

            //Step 6
            // Klicken "Actions" -> "Start/Stop Trigger Acquisition..." Menüelement
            WinMenuItem UIStartStopTriggerAcquMenuItem = new WinMenuItem(UIActionsMenuItem);
            UIStartStopTriggerAcquMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Start/Stop Trigger Acquisition...";
            UIStartStopTriggerAcquMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIStartStopTriggerAcquMenuItem.WindowTitles.Add("ProbeControl");

            Mouse.Click(UIStartStopTriggerAcquMenuItem);
            Playback.Wait(10);
           
            //Step 7
            // Klicken "Actions" -> "Start/Stop Trigger Acquisition..." Menüelement
            WinWindow UIEmulatedEMU0Window = new WinWindow();
            UIEmulatedEMU0Window.SearchProperties[WinWindow.PropertyNames.Name] = "Emulated - EMU-0";
            UIEmulatedEMU0Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIEmulatedEMU0Window.WindowTitles.Add("Emulated - EMU-0");
          
            WinTitleBar UIEmulatedEMU0TitleBar = new WinTitleBar(UIEmulatedEMU0Window);
            UIEmulatedEMU0TitleBar.WindowTitles.Add("Emulated - EMU-0");
            
            WinButton UICloseButton = new WinButton(UIEmulatedEMU0TitleBar);
            UICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton.WindowTitles.Add("Emulated - EMU-0");
          

            // Klicken "Close" Schaltfläche
            Mouse.Click(UICloseButton);
            Playback.Wait(5000);

            //Step 8
            
            WinTitleBar UIProbeControlTitleBar = new WinTitleBar(UIProbeControlWindow);
            UIProbeControlTitleBar.WindowTitles.Add("ProbeControl");
            
            WinButton UICloseButton1 = new WinButton(UIProbeControlTitleBar);
            UICloseButton1.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton1.WindowTitles.Add("ProbeControl");
                  
            // Klicken "Close" Schaltfläche
            Mouse.Click(UICloseButton1);
            Playback.Wait(5000);
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
