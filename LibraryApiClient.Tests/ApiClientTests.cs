using System;
using IO.Swagger.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryApiClient.Tests
{
    [TestClass]
    public class ApiClientTests
    {
        #region Fields

        private static ApiClient ApiClient;

        public TestContext TestContext { get; set; }

        #endregion

        #region Setup/Cleanup

        public static void ClassSetup(TestContext testContext)
        {
            ApiClient = new ApiClient("https://localhost:44392");
        }

        #endregion

        #region Tests

        [TestMethod]
        public void ApiClientTest()
        {
            var apiClient = new ApiClient();

            Assert.IsNotNull(apiClient);
        }

        #endregion
    }
}
