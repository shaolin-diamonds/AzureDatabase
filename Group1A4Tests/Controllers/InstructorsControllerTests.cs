using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group1A4.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1A4.Controllers.Tests
{
    [TestClass()]
    public class InstructorsControllerTests
    {
        [TestMethod()]
        public void AuthUserTest()
        {
            AuthenticationController controller = new AuthenticationController("fakekeynotlogin1111!");

            User user = new User
            {
                username = "testusername",
                password = "testpassword!!!"
            };

            var ret = controller.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}