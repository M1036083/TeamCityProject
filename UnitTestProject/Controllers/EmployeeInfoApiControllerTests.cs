using Microsoft.VisualStudio.TestTools.UITest.Common.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCApp.Controllers;
using MyWebApi.Controllers;
using MyWebApi.DataAccessRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyWebApi.Controllers.Tests
{
    [TestClass()]
    public class EmployeeInfoApiControllerTests1
    {


        [TestMethod()]
        public void Get()
        {



            ////Arrange
            //EmployeeInfoApiController controller = new EmployeeInfoApiController();

            //// Act
            //IEnumerable<EmployeeInfo> result = controller.Get();

            //// Assert

            ////Assert.AreEqual(5, result);
            //Assert.IsNotNull(result);

            clsDataAccessRepository emp = new clsDataAccessRepository();
            EmployeeInfoApiController controller = new EmployeeInfoApiController(emp);
            IEnumerable<EmployeeInfo> result = controller.Get();
            //Assert.AreEqual(6, result);
            Assert.IsNotNull(result);
        }
    }
}