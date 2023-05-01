using Microsoft.VisualStudio.TestTools.UnitTesting;
using group3Database.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group3Database.Data;
using Microsoft.EntityFrameworkCore;

namespace group3Database.Controllers.Tests
{
    [TestClass()]
    public class InstructorsControllerTests
    {
        [TestMethod()]
        public async Task GetInstructorIDTest()
        {
            var connectionString = "Data Source=BIGRED\\;Initial Catalog=Group3_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<Group3_DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            Group3_DatabaseContext dbContext = new Group3_DatabaseContext(optionsBuilder.Options);

            InstructorsController sample = new InstructorsController(dbContext);

            var ret = await sample.GetInstructor(1);

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public async Task GetInstructorsTest()
        {
            var connectionString = "Data Source=BIGRED\\;Initial Catalog=Group3_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<Group3_DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            Group3_DatabaseContext dbContext = new Group3_DatabaseContext(optionsBuilder.Options);

            InstructorsController sample = new InstructorsController(dbContext);

            var ret = await sample.GetInstructors();

            Assert.IsNotNull(ret);
        }
    }
}