using IS.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IS.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {
        //dado o HomeController
        [TestMethod]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //arrange (Ambiente, estrutura necessária)
            var homeController = new HomeController();

            //action
            var result = homeController.Index();

            //assert (Testar se o resultado é o esperado)
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }

    }
}
