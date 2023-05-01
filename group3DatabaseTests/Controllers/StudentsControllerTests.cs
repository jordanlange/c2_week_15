using Microsoft.VisualStudio.TestTools.UnitTesting;
using group3Database.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group3Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace group3Database.Controllers.Tests
{
    [TestClass()]
    public class StudentsControllerTests
    {


        [TestMethod()]
        public async Task GetStudentIDTest()
        {
            var connectionString = "Data Source=BIGRED\\;Initial Catalog=Group3_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<Group3_DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            Group3_DatabaseContext dbContext = new Group3_DatabaseContext(optionsBuilder.Options);

            StudentsController sample = new StudentsController(dbContext);

            var ret = await sample.GetStudent(1);

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public async Task GetStudentTest()
        {
            var connectionString = "Data Source=BIGRED\\;Initial Catalog=Group3_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<Group3_DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);

            Group3_DatabaseContext dbContext = new Group3_DatabaseContext(optionsBuilder.Options);

            StudentsController sample = new StudentsController(dbContext);

            var ret = await sample.GetStudents();

            Assert.IsNotNull(ret);
        }
    }
}