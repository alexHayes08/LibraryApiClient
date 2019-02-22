using System;
using System.Collections.Generic;
using ApertureLabs.LibraryApi.Client.Models;
using ApertureLabs.LibraryApi.Client.Services;
using LibraryServerApi.Models.Lock;
using LibraryServerApi.Models.Lockable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApertureLabs.LibraryApiClient.Core.Tests.Services
{
    [TestClass]
    public class LockableManagerServiceTests
    {
        #region Fields

        private static LockableManagerService LockableManagerService;

        public TestContext TestContext { get; set; }

        #endregion

        #region Setup/Cleanup

        [ClassInitialize]
        public static void TestStartup(TestContext testContext)
        {
            var options = new ApiServiceOptions
            {
                Key = "rSn2NMXdnVFUOzm/0FIb2SmGF3LbH2oXmx6gLdz/PPoDfyq2iEcZDQo61WzW+wC/9nux7elCgQ==",
                OwnerToken = "AlexHayes",
                ServerUri = new Uri("https://localhost:44392")
            };

            var apiService = new ApiService(options);
            LockableManagerService = new LockableManagerService(apiService);
        }

        #endregion

        #region Tests

        [Description("Verifies no exceptions are thrown in the ctor.")]
        [TestMethod]
        public void LockableManagerServiceTest()
        { }

        [TestMethod]
        public void CreateTest()
        {
            var lockable = new Lockable
            {
                Categories = new List<string> { "Nop", "Address" },
                Data = new Address
                {
                    Address1 = "Make Believe Ln.",
                    Address2 = "Suite B.",
                    Name = "Address",
                    Zip = "12345-12345"
                },
                Name = "Address",
                Locks = new Lock[0]
            };

            var createdLockable = LockableManagerService.Create(lockable);

            Assert.IsNotNull(createdLockable);
            Assert.IsNotNull(createdLockable.Id);
        }

        #endregion

        #region Nested Classes

        private class Address
        {
            public string Id { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Name { get; set; }
            public string Zip { get; set; }
        }

        #endregion
    }
}
