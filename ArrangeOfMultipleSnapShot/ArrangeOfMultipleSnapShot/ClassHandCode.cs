using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangeOfMultipleSnapShot
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


            //2nd step

            WinWindow UIProbeControlWindow = new WinWindow();
            UIProbeControlWindow.SearchProperties[WinWindow.PropertyNames.Name] = "ProbeControl";
            UIProbeControlWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIProbeControlWindow.WindowTitles.Add("ProbeControl");

            WinWindow UIToolStrip1Window = new WinWindow(UIProbeControlWindow);
            UIToolStrip1Window.SearchProperties[WinWindow.PropertyNames.ControlName] = "toolStrip1";
            UIToolStrip1Window.WindowTitles.Add("ProbeControl");

            WinButton UIToolStripButtonConneButton = new WinButton(UIToolStrip1Window);
            UIToolStripButtonConneButton.SearchProperties[WinButton.PropertyNames.Name] = "toolStripButtonConnect";
            UIToolStripButtonConneButton.WindowTitles.Add("ProbeControl");


            Mouse.Click(UIToolStripButtonConneButton);
            Playback.Wait(4000);

            // 3rd step

            WinMenuBar UIMenuStrip1MenuBar = new WinMenuBar(UIProbeControlWindow);
            UIMenuStrip1MenuBar.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            UIMenuStrip1MenuBar.WindowTitles.Add("ProbeControl");

            WinMenuItem UIActionsMenuItem = new WinMenuItem(UIMenuStrip1MenuBar);
            UIActionsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Actions";
            UIActionsMenuItem.WindowTitles.Add("ProbeControl");

            WinMenuItem UISaveSnapshotMenuItem = new WinMenuItem(UIActionsMenuItem);
            UISaveSnapshotMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Save Snapshot";
            UISaveSnapshotMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UISaveSnapshotMenuItem.WindowTitles.Add("ProbeControl");

            Mouse.Click(UISaveSnapshotMenuItem);
            Playback.Wait(5000);
          
            // Klicken "Actions" -> "Save Snapshot" Menüelement
            Mouse.Click(UISaveSnapshotMenuItem);
            Playback.Wait(2000);
            // Klicken "Actions" -> "Save Snapshot" Menüelement
            Mouse.Click(UISaveSnapshotMenuItem);
            Playback.Wait(2000);
            // Klicken "Actions" -> "Save Snapshot" Menüelement
            Mouse.Click(UISaveSnapshotMenuItem);
            Playback.Wait(2000);

            //Step 4
            // Klicken "View" -> "Arrange windows" Menüelement
            WinMenuItem UIViewMenuItem = new WinMenuItem(UIProbeControlWindow);
            UIViewMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "View";
            UIViewMenuItem.WindowTitles.Add("ProbeControl");

            WinMenuItem UIArrangewindowsMenuItem = new WinMenuItem(UIViewMenuItem);
            UIArrangewindowsMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Arrange windows";
            UIArrangewindowsMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UIArrangewindowsMenuItem.WindowTitles.Add("ProbeControl");
          
            Mouse.Click(UIArrangewindowsMenuItem);
            Playback.Wait(5000);

            try
            {
                Playback.Cleanup();

                Console.WriteLine("Does come");
            }
            catch(ExecutionEngineException)

            {

                Console.WriteLine("Doesnot come");
            }
        
        }

    }
}
