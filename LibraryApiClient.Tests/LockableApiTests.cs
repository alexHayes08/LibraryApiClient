using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryApiClient.Tests
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Name { get; set; }
    }

    [TestClass]
    public class LockableApiTests
    {
        #region Fields

        private static LockableApi lockableApi;

        public TestContext TestContext { get; set; }

        #endregion

        #region Setup/Cleanup

        [ClassInitialize]
        public static void ClassSetup(TestContext testContext)
        {
            lockableApi = new LockableApi("https://localhost:44392");
        }

        #endregion

        #region Tests

        [Description("Verifies no exceptions are thrown.")]
        [TestMethod]
        public void LockableApiTest()
        { }

        [TestMethod]
        public void CreateTest()
        {
            var lockable = lockableApi.Create(new BaseRequestLockable
            {
                Data = new Lockable
                {
                    Categories = new List<string> { "Address", "Nop" },
                    Data = new Address
                    {
                        Address1 = "Make Believe Ln",
                        Address2 = "Suite B",
                        Name = "Alex Hayes"
                    },
                    Name = "Address"
                },
                OwnerToken = String.Empty
            });

            Assert.IsNotNull(lockable);
        }

        #endregion
    }
}
