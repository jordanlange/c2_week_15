using Microsoft.VisualStudio.TestTools.UnitTesting;
using group3Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group3Database.Controllers;

namespace group3Database.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("passwordpassword1234");

            User user = new User
            {
                username = "testusername",
                password = "testpassword1234"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}