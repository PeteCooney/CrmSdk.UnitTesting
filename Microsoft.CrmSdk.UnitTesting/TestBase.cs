// <copyright file="TestBase.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Abstract base class for a test fixture
    /// </summary>
    [TestClass]
    public abstract class TestBase
    {
        /// <summary>
        /// Gets an instance of <see cref="IOrganizationServiceMock"/> for mocking calls to Dynamics 365
        /// </summary>
        protected OrganizationServiceMock OrganizationServiceMock { get; private set; }

        /// <summary>
        /// Setup basic mocks that are used throughout the test fixture.
        /// </summary>
        [TestInitialize]
        public virtual void Initialize()
        {
            this.OrganizationServiceMock = new OrganizationServiceMock();
        }
    }
}