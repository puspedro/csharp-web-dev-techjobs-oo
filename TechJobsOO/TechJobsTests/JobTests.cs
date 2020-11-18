using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsTrue(testJob2.Id - testJob1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job1.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job1.JobType.ToString(), "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Persistence");
            Assert.IsNotNull(job1.Id);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobToStringMethodBeginningAndEnding()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string[] stringTest = job1.ToString().Split("\n");
            string expectedString = "";
            //Assert.IsTrue(stringTest.StartsWith(expectedString) && stringTest.EndsWith(expectedString));
            Assert.IsTrue(stringTest[0] == expectedString);
            Assert.IsTrue(stringTest[stringTest.Length - 1] == expectedString);
        }

        [TestMethod]
        public void TestJobToStringMethodLabels()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string[] stringTest = job1.ToString().Split("\n");
            string[] jobsLabels = { "ID", "Name", "Employer", "Location", "Position Type", "Core Competency" };
            Assert.IsTrue(stringTest[1].StartsWith(jobsLabels[0]));
            Assert.IsTrue(stringTest[2].StartsWith(jobsLabels[1]));
            Assert.IsTrue(stringTest[3].StartsWith(jobsLabels[2]));
            Assert.IsTrue(stringTest[4].StartsWith(jobsLabels[3]));
            Assert.IsTrue(stringTest[5].StartsWith(jobsLabels[4]));
            Assert.IsTrue(stringTest[6].StartsWith(jobsLabels[5]));
        }

        [TestMethod]
        public void TestJobsToStringMethodData()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string[] stringTest = job1.ToString().Split("\n");
            Assert.IsTrue(stringTest[1].EndsWith("1"));
            Assert.IsTrue(stringTest[2].EndsWith("Product tester"));
            Assert.IsTrue(stringTest[3].EndsWith("ACME"));
            Assert.IsTrue(stringTest[4].EndsWith("Desert"));
            Assert.IsTrue(stringTest[5].EndsWith("Quality control"));
            Assert.IsTrue(stringTest[6].EndsWith("Persistence"));
        }

        [TestMethod]
        public void TestJobsToStringMethodFieldsEmpty()
        {
            Job job1 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string[] stringTest = job1.ToString().Split("\n");
            Assert.IsTrue(stringTest[2].EndsWith("Data not available"));
        }

        //[TestMethod]
        //public void TestJobsToStringMethodJobNull()
        //{
        //    Job job1 = new Job();
        //    string stringTest = job1.ToString();
        //    Assert.IsTrue(stringTest == "OOPS! This job does not seem to exist.");
        //    //Assert.AreEqual(stringTest, "OOPS! This job does not seem to exist.");
        //}

    }
}
