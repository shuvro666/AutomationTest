﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace StartAndStopTriggerAcquisition
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

            //this.UIMap.RecordedMethod1();

            StopTriggerAcquisition.Runner();

            // ClassHandCode.Runner();
            // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Test der codierten UI generieren" aus, und wählen Sie eine der Menüelemente aus.

            // Weitere Informationen über generierten Code finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=179463".
        }

        #region Zusätzliche Testattribute

        // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:

        ////Verwenden Sie "TestInitialize", um vor dem Ausführen der einzelnen Tests Code auszuführen 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Test der codierten UI generieren" aus, und wählen Sie eine der Menüelemente aus.
        //    // Weitere Informationen über generierten Code finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=179463".
        //}

        ////Verwenden Sie "TestCleanup", um nach dem Ausführen der einzelnen Tests Code auszuführen
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Wählen Sie zum Generieren von Code für den Test im Kontextmenü "Code für Test der codierten UI generieren" aus, und wählen Sie eine der Menüelemente aus.
        //    // Weitere Informationen über generierten Code finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=179463".
        //}

        #endregion

        /// <summary>
        ///Dient zum Abrufen oder Festlegen des Textkontexts, der Informationen über
        ///den aktuellen Testlauf  und dessen Funktionalität bereitstellt.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;


    }
}
