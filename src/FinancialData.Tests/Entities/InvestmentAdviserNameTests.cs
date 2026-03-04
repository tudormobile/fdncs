using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InvestmentAdviserNameTests
    {
        [TestMethod]
        public void InvestmentAdviserName_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""crd_number"": ""107665"",
    ""sec_file_number"": ""801-10746"",
    ""firm_name"": ""BlackRock, Inc.""
}";
            using var doc = JsonDocument.Parse(json);
            var adviserName = FinancialDataSerializer.Instance.Deserialize<InvestmentAdviserName>(doc);
            Assert.AreEqual("107665", adviserName.CrdNumber);
            Assert.AreEqual("801-10746", adviserName.SecFileNumber);
            Assert.AreEqual("BlackRock, Inc.", adviserName.FirmName);
        }
    }
}
