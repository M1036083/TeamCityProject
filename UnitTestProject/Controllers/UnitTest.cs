using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApi.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace MyWebApi.Controllers.Tests
{
    [TestClass()]
    public class EmployeeInfoApiControllerTests
    {


        [TestMethod()]
        public void GetTest()
        {
            ValuesController controller = new ValuesController(); // <1>

            // Act
            IEnumerable<string> result = controller.Get(); // <2>

            // Assert // <3>
           // Assert.IsNull(result); //test fail
            Assert.IsNotNull(result); //test successful

        }
    }

}

    
   