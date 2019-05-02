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

                 
            //2nd step

            WinWindow  UIProbeControlWindow = new WinWindow();
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

            WinMenuItem UIStartStopTriggerAcquMenuItem = new WinMenuItem(UIActionsMenuItem);
            UIStartStopTriggerAcquMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Start/Stop Trigger Acquisition...";
            UIStartStopTriggerAcquMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIStartStopTriggerAcquMenuItem.WindowTitles.Add("ProbeControl");
           

            Mouse.Click(UIStartStopTriggerAcquMenuItem);
            Playback.Wait(3000);

            
            
            
            //Step 4


            WinWindow UIAttentionWindow = new WinWindow();
            UIAttentionWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Attention";
            UIAttentionWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            UIAttentionWindow.WindowTitles.Add("Attention");

            WinWindow UIOKWindow = new WinWindow(UIAttentionWindow);
            UIOKWindow.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            UIOKWindow.WindowTitles.Add("Attention");

            WinButton UIOKButton = new WinButton(UIOKWindow);
            UIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
            UIOKButton.WindowTitles.Add("Attention");

            Mouse.Click(UIOKButton);
            Playback.Wait(3000);


           //sTEP

            WinWindow UIEmulatedEMU0Window = new WinWindow();
            UIEmulatedEMU0Window.SearchProperties[WinWindow.PropertyNames.Name] = "Emulated - EMU-0";
            UIEmulatedEMU0Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIEmulatedEMU0Window.WindowTitles.Add("Emulated - EMU-0");
           
            WinTitleBar UIEmulatedEMU0TitleBar = new WinTitleBar(UIEmulatedEMU0Window);
            UIEmulatedEMU0TitleBar.WindowTitles.Add("Emulated - EMU-0");
           
            WinButton UICloseButton = new WinButton(UIEmulatedEMU0TitleBar);
            UICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton.WindowTitles.Add("Emulated - EMU-0");
            
            Mouse.Click(UICloseButton);

           

           //Step 5

            WinTitleBar UIProbeControlTitleBar = new WinTitleBar(UIProbeControlWindow); 
            UIProbeControlTitleBar.WindowTitles.Add("ProbeControl");

            WinButton UICloseButton1 = new WinButton(UIProbeControlTitleBar);
            UICloseButton1.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton1.WindowTitles.Add("ProbeControl");
               
             // Klicken "Close" Schaltfläche
            Mouse.Click(UICloseButton1);


            //Step 6

            WinTitleBar UISOPATStartupTitleBar = new WinTitleBar (UISOPATStartupWindow);
            UISOPATStartupTitleBar.WindowTitles.Add("SOPAT - Startup");

            WinButton UICloseButton2 = new WinButton(UISOPATStartupTitleBar);
            UICloseButton2.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton2.WindowTitles.Add("SOPAT - Startup");
                  
            // Klicken "Close" Schaltfläche
            Mouse.Click(UICloseButton2);

        
        }

    }
}
