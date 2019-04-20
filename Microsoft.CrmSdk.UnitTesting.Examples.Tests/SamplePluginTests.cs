// <copyright file="SamplePluginTests.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting.Examples.Tests
{
    using System;
    using System.ServiceModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// Test fixture for the <see cref="SamplePlugin"/> class.
    /// </summary>
    [TestClass]
    public class SamplePluginTests : PluginTest<SamplePlugin>
    {
        /// <summary>
        /// Test that the Execute method invokes <see cref="ITracingService.Trace(string, object[])"/>
        /// </summary>
        [TestMethod]
        public void Execute_LogsInitialTrace()
        {
            // Arrange
            this.OrganizationServiceMock.SetupRetrieveMultiple(new FaultException<OrganizationServiceFault>(new OrganizationServiceFault()));

            // Act
            this.ExecutePlugin();

            // Assert
            this.TracingServiceMock.VerifyTrace(Times.AtLeastOnce);
        }

        /// <summary>
        /// Test that the Execute method retrieves the record specified in the Target
        /// </summary>
        [TestMethod]
        public void Execute_RetrievesTarget()
        {
            // Arrange
            const string LogicalName = "account";
            var id = Guid.NewGuid();
            this.PluginExecutionContextMock.InputParameters.Add("Target", new Entity(LogicalName, id));

            // Act
            this.ExecutePlugin();

            // Assert
            this.OrganizationServiceMock.VerifyRetrieve(LogicalName, id, Times.Once);
        }
    }
}
