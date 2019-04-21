// <copyright file="OrganizationServiceFactoryMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// A mocked instance of <seealso cref="IOrganizationServiceFactory"/>
    /// </summary>
    /// <seealso cref="IOrganizationServiceFactoryMock"/>
    public class OrganizationServiceFactoryMock : Mock<IOrganizationServiceFactory>, IOrganizationServiceFactoryMock
    {
        private readonly IOrganizationServiceMock organizationServiceMock;

        /// <summary>
        /// Initialises a new instance of the <see cref="OrganizationServiceFactoryMock"/> class
        /// </summary>
        /// <param name="organizationServiceMock">An instance of <see cref="IOrganizationServiceMock"/> for mocking calls to Dynamics 365</param>
        public OrganizationServiceFactoryMock(IOrganizationServiceMock organizationServiceMock)
            : base()
        {
            this.organizationServiceMock = organizationServiceMock;

            this.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid>())).Returns(this.organizationServiceMock.Object);
        }
    }
}