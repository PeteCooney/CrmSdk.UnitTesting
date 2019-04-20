// <copyright file="IServiceProviderMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using System;
    using Moq;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="IServiceProvider"/>
    /// </summary>
    public interface IServiceProviderMock : IMock<IServiceProvider>
    {
    }
}