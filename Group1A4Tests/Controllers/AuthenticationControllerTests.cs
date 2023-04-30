using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group1A4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group1A4.Controllers;

namespace Group1A4.Tests
{
    [TestClass()]
    public class AuthenticationControllerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
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