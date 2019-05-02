using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewCalibrationData
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

            //Step 3

            WinWindow UITabControl1Window = new WinWindow(UIProbeControlWindow); 
            UITabControl1Window.SearchProperties[WinWindow.PropertyNames.ControlName] = "tabControl1";
            UITabControl1Window.WindowTitles.Add("ProbeControl");
            
            WinTabList UICurrentpositionTabList = new WinTabList(UITabControl1Window);
            UICurrentpositionTabList.SearchProperties[WinTabList.PropertyNames.Name] = "Current position";
            UICurrentpositionTabList.WindowTitles.Add("ProbeControl");
            
            WinTabPage UIProbeControlTabPage = new WinTabPage(UICurrentpositionTabList);
            UIProbeControlTabPage.SearchProperties[WinTabPage.PropertyNames.Name] = "Probe Control";
            UIProbeControlTabPage.WindowTitles.Add("ProbeControl");

            Mouse.Click(UIProbeControlTabPage);
            Playback.Wait(3000);

            
            //Step 4
            // Klicken "Setup" Schaltfläche
            WinWindow UISetupWindow = new WinWindow(UIProbeControlWindow);
            UISetupWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnFocusSetup";
            UISetupWindow.WindowTitles.Add("ProbeControl");
            
            WinButton UISetupButton = new WinButton(UISetupWindow);
            UISetupButton.SearchProperties[WinButton.PropertyNames.Name] = "Setup";
            UISetupButton.WindowTitles.Add("ProbeControl");
            
            Mouse.Click(UISetupButton);
            Playback.Wait(3000);
            
            //Step 5
            // Klicken "Setup calibration data" Schaltfläche
            
            WinWindow UIFocusmotorsetupWindow = new WinWindow();
            UIFocusmotorsetupWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Focus motor setup";
            UIFocusmotorsetupWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIFocusmotorsetupWindow.WindowTitles.Add("Focus motor setup");
           
            WinWindow UISetupcalibrationdataWindow = new WinWindow(UIFocusmotorsetupWindow);
            UISetupcalibrationdataWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnSetupCalibrationData";
            UISetupcalibrationdataWindow.WindowTitles.Add("Focus motor setup");
           
            WinButton UISetupcalibrationdataButton = new WinButton(UISetupcalibrationdataWindow);
            UISetupcalibrationdataButton.SearchProperties[WinButton.PropertyNames.Name] = "Setup calibration data";
            UISetupcalibrationdataButton.WindowTitles.Add("Focus motor setup");

            Mouse.Click(UISetupcalibrationdataButton);
            Playback.Wait(3000);

            //Step 6
            
            WinWindow UICalibrationdataWindow = new WinWindow();
            UICalibrationdataWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calibration data";
            UICalibrationdataWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UICalibrationdataWindow.WindowTitles.Add("Calibration data");
            
            WinWindow UILoadWindow = new WinWindow(UICalibrationdataWindow);
            UILoadWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnLoad";
            UILoadWindow.WindowTitles.Add("Calibration data");
          
            WinButton UILoadButton = new WinButton(UILoadWindow);
            UILoadButton.SearchProperties[WinButton.PropertyNames.Name] = "Load";
            UILoadButton.WindowTitles.Add("Calibration data");
           
            // Klicken "Load" Schaltfläche
            Mouse.Click(UILoadButton);
            Playback.Wait(3000);

            //Step 7
            // Klicken "Name" Textfeld

            WinWindow UIOpenWindow = new WinWindow();
            UIOpenWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Open";
            UIOpenWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            UIOpenWindow.WindowTitles.Add("Open");
            
            WinWindow UIItemWindow = new WinWindow(UIOpenWindow);
            UIItemWindow.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            UIItemWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            UIItemWindow.WindowTitles.Add("Open");

            WinListItem UIItem20161115_NEW_BarListItem = new WinListItem(UIItemWindow);
            UIItem20161115_NEW_BarListItem.SearchProperties[WinListItem.PropertyNames.Name] = "20161115_NEW_Barry_fix.json";
            UIItem20161115_NEW_BarListItem.WindowTitles.Add("Open");

            WinEdit UINameEdit = new WinEdit(UIItem20161115_NEW_BarListItem);
            UINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
            UINameEdit.WindowTitles.Add("Open");

            Mouse.Click(UINameEdit);
            Playback.Wait(3000);


            WinWindow UITreeViewWindow = new WinWindow(UIOpenWindow);
            UITreeViewWindow.SearchProperties[WinWindow.PropertyNames.ControlId] = "100";
            UITreeViewWindow.WindowTitles.Add("Open");
            
            WinTreeItem UIQuickaccessTreeItem = new WinTreeItem(UITreeViewWindow);
            UIQuickaccessTreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = "Quick access";
            UIQuickaccessTreeItem.SearchProperties["Value"] = "0";
            UIQuickaccessTreeItem.WindowTitles.Add("Open");
            
            WinTreeItem UISOPATGmbHpinnedTreeItem = new WinTreeItem(UIQuickaccessTreeItem);
            UISOPATGmbHpinnedTreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = "SOPAT GmbH (pinned)";
            UISOPATGmbHpinnedTreeItem.SearchProperties["Value"] = "1";
            UISOPATGmbHpinnedTreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UISOPATGmbHpinnedTreeItem.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            UISOPATGmbHpinnedTreeItem.WindowTitles.Add("Open");


            Mouse.DoubleClick(UISOPATGmbHpinnedTreeItem);

            // Doppelklicken "Name" Textfeld

            WinWindow UIItemWindow1 = new WinWindow(UIOpenWindow);
            UIItemWindow1.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            UIItemWindow1.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            UIItemWindow1.WindowTitles.Add("Open");
            
            WinListItem UIMonitoringProgramsListItem = new WinListItem(UIItemWindow1);
            UIMonitoringProgramsListItem.SearchProperties[WinListItem.PropertyNames.Name] = "monitoringPrograms";
            UIMonitoringProgramsListItem.WindowTitles.Add("Open");
           
            WinEdit UINameEdit1 = new WinEdit(UIMonitoringProgramsListItem);
            UINameEdit1.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
            UINameEdit1.WindowTitles.Add("Open");

            Mouse.DoubleClick(UINameEdit1);

            // Doppelklicken "Name" Textfeld

            WinWindow UIItemWindow2 = new WinWindow(UIOpenWindow);
            UIItemWindow2.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            UIItemWindow2.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            UIItemWindow2.WindowTitles.Add("Open");
           
            WinListItem UICamcontrolListItem = new WinListItem(UIItemWindow2);
            UICamcontrolListItem.SearchProperties[WinListItem.PropertyNames.Name] = "camcontrol";
            UICamcontrolListItem.WindowTitles.Add("Open");

            WinEdit UINameEdit2 = new WinEdit(UICamcontrolListItem);
            UINameEdit2.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
            UINameEdit2.WindowTitles.Add("Open");
           
            Mouse.DoubleClick(UINameEdit2);

            // Doppelklicken "Name" Textfeld
            WinWindow UIItemWindow3 = new WinWindow(UIOpenWindow);
            UIItemWindow3.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            UIItemWindow3.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            UIItemWindow3.WindowTitles.Add("Open");
           
            WinListItem UICalibrationListItem = new WinListItem(UIItemWindow3);
            UICalibrationListItem.SearchProperties[WinListItem.PropertyNames.Name] = "calibration";
            UICalibrationListItem.WindowTitles.Add("Open");

            WinEdit UINameEdit3 = new WinEdit(UICalibrationListItem);
            UINameEdit3.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
            UINameEdit3.WindowTitles.Add("Open");
            
            Mouse.DoubleClick(UINameEdit3);

            // Klicken "Name" Textfeld
            WinWindow UIItemWindow4 = new WinWindow(UIOpenWindow);
            UIItemWindow4.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            UIItemWindow4.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            UIItemWindow4.WindowTitles.Add("Open");
            
            WinListItem UIItem20161115_NEW_BarListItem1 = new WinListItem(UIItemWindow4);
            UIItem20161115_NEW_BarListItem1.SearchProperties[WinListItem.PropertyNames.Name] = "20161115_NEW_Barry_fix.json";
            UIItem20161115_NEW_BarListItem1.WindowTitles.Add("Open");
            
            WinEdit UINameEdit4 = new WinEdit(UIItem20161115_NEW_BarListItem1);
            UINameEdit4.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
            UINameEdit4.WindowTitles.Add("Open");

            Mouse.Click(UINameEdit4);

            
            //Step 8
            // Klicken "&Open" Schaltfläche

            WinWindow UIOpenWindow1 = new WinWindow(UIOpenWindow);
            UIOpenWindow1.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            UIOpenWindow1.WindowTitles.Add("Open");
           
            WinButton UIOpenButton = new WinButton(UIOpenWindow1);
            UIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
            UIOpenButton.WindowTitles.Add("Open");
            
            Mouse.Click(UIOpenButton);
            Playback.Wait(3000);

            //Step 9
            // Klicken "OK" Schaltfläche

            WinWindow UIOKWindow1 = new WinWindow(UICalibrationdataWindow);
            UIOKWindow1.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOK";
            UIOKWindow1.WindowTitles.Add("Calibration data");
            
            WinButton UIOKButton = new WinButton(UIOKWindow1);
            UIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
            UIOKButton.WindowTitles.Add("Calibration data");
         
            Mouse.Click(UIOKButton);
            Playback.Wait(3000);

            //Step 10
            // Klicken "OK" Schaltfläche
            WinWindow UIOKWindow = new WinWindow(UIFocusmotorsetupWindow);
            UIOKWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOK";
            UIOKWindow.WindowTitles.Add("Focus motor setup");
           
            WinButton UIOKButton1 = new WinButton(UIOKWindow);
            UIOKButton1.SearchProperties[WinButton.PropertyNames.Name] = "OK";
            UIOKButton1.WindowTitles.Add("Focus motor setup");
           
            Mouse.Click(UIOKButton1);
            Playback.Wait(3000);

            //Step 11
            // Klicken "View" -> "Calibration data" Menüelement
            
            WinMenuItem UIViewMenuItem = new WinMenuItem(UIProbeControlWindow);
            UIViewMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "View";
            UIViewMenuItem.WindowTitles.Add("ProbeControl");

            WinMenuItem UICalibrationdataMenuItem = new WinMenuItem(UIViewMenuItem);
            UICalibrationdataMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Calibration data";
            UICalibrationdataMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            UICalibrationdataMenuItem.WindowTitles.Add("ProbeControl");

            Mouse.Click(UICalibrationdataMenuItem);
            Playback.Wait(5000);

            //
            WinTitleBar UICalibrationDataTitleBar = new WinTitleBar(UICalibrationdataWindow);
            UICalibrationDataTitleBar.WindowTitles.Add("Calibration Data");
           
            WinButton UICloseButton = new WinButton(UICalibrationDataTitleBar);
            UICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
            UICloseButton.WindowTitles.Add("Calibration Data");

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
