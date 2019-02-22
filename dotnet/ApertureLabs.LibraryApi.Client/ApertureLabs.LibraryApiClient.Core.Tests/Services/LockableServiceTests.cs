using System;
using System.Collections.Generic;
using System.Text;
using ApertureLabs.LibraryApi.Client.Models;
using ApertureLabs.LibraryApi.Client.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApertureLabs.LibraryApiClient.Core.Tests.Services
{
    [TestClass]
    public class LockableServiceTests
    {
        #region Fields

        private static LockableService lockableService;

        public TestContext TestContext { get; set; }

        #endregion

        #region Setup/Cleanup

        public static void TestSetup(TestContext testContext)
        {
            var options = new ApiServiceOptions
            {
                Key = "rSn2NMXdnVFUOzm/0FIb2SmGF3LbH2oXmx6gLdz/PPoDfyq2iEcZDQo61WzW+wC/9nux7elCgQ==",
                OwnerToken = "AlexHayes",
                ServerUri = new Uri("https://localhost:44392")
            };

            var apiService = new ApiService(options);
            lockableService = new LockableService(apiService);
        }

        #endregion

        #region Tests

        [Description("Verifies not exceptions are thrown in the ctor.")]
        [TestMethod]
        public void LockableServiceTest()
        { }

        public void RetrieveReadOnlyTest()
        {

        }

        #endregion
    }
}
