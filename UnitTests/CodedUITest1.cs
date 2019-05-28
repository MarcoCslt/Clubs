using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace UnitTests
{
    /// <summary>
    /// Description résumée pour CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // Pour générer le code de ce test, sélectionnez "Générer le code pour le test codé de l'interface utilisateur" dans le menu contextuel et sélectionnez un des éléments de menu.
        }

        #region Attributs de tests supplémentaires

        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :

        ////Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Pour générer le code de ce test, sélectionnez "Générer le code pour le test codé de l'interface utilisateur" dans le menu contextuel et sélectionnez un des éléments de menu.
        //}

        ////Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Pour générer le code de ce test, sélectionnez "Générer le code pour le test codé de l'interface utilisateur" dans le menu contextuel et sélectionnez un des éléments de menu.
        //}

        #endregion

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
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
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
