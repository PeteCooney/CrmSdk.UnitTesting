// <copyright file="IOrganizationServiceFactoryMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="IOrganizationServiceFactory"/>
    /// </summary>
    public interface IOrganizationServiceFactoryMock : IMock<IOrganizationServiceFactory>
    {
    }
}