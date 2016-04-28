using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SteamSpySharp.Tests
{
    [TestClass]
    public class ApiClientTests
    {
        private ApiClient apiClient;

        [TestInitialize]
        public void Initialize()
        {
            this.apiClient = new ApiClient();
        }

        [TestMethod]
        public async Task GetAppDetailsAsync()
        {
            var appDetails = await this.apiClient.GetAppDetailsAsync(730);

            Assert.AreEqual(730, appDetails.AppId);
            Assert.AreEqual("Counter-Strike: Global Offensive", appDetails.Name);
            Assert.AreEqual("Valve", appDetails.Developers);
            Assert.AreEqual("Valve", appDetails.Publishers);
            Assert.IsTrue(appDetails.ScoreRank > 0);
            Assert.IsTrue(appDetails.Owners > 0);
            Assert.IsTrue(appDetails.OwnersVariance > 0);
            Assert.IsTrue(appDetails.PlayersForever > 0);
            Assert.IsTrue(appDetails.PlayersForeverVariance > 0);
            Assert.IsTrue(appDetails.PlayersLastTwoWeeks > 0);
            Assert.IsTrue(appDetails.PlayersLastTwoWeeksVariance > 0);
            Assert.IsTrue(appDetails.AverageForever > 0);
            Assert.IsTrue(appDetails.AverageLastTwoWeeks > 0);
            Assert.IsTrue(appDetails.MedianForever > 0);
            Assert.IsTrue(appDetails.MedianTwoWeeks > 0);
            Assert.IsTrue(appDetails.ConcurrentUsers > 0);
        }
    }
}
