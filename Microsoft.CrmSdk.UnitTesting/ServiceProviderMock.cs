// <copyright file="ServiceProviderMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// A mocked instance of <seealso cref="IServiceProvider"/>
    /// </summary>
    /// <seealso cref="IServiceProviderMock"/>
    public class ServiceProviderMock : Mock<IServiceProvider>, IServiceProviderMock
    {
        private readonly IOrganizationServiceFactoryMock organizationServiceFactoryMock;
        private readonly ITracingServiceMock tracingServiceMock;
        private readonly IPluginExecutionContextMock pluginExecutionContextMock;

        /// <summary>
        /// Initialises a new instance of the <see cref="ServiceProviderMock"/> class
        /// </summary>
        /// <param name="pluginExecutionContextMock">An instance of <see cref="IPluginExecutionContextMock"/> used for querying plugin activities</param>
        /// <param name="organizationServiceFactoryMock">An instance of <see cref="IOrganizationServiceFactoryMock"/> used for creating an <see cref="IOrganizationService"/></param>
        /// <param name="tracingServiceMock">An instance of <see cref="ITracingServiceMock"/> used for verifying calls to the tracing service</param>
        public ServiceProviderMock(IPluginExecutionContextMock pluginExecutionContextMock, IOrganizationServiceFactoryMock organizationServiceFactoryMock, ITracingServiceMock tracingServiceMock)
            : base()
        {
            this.pluginExecutionContextMock = pluginExecutionContextMock ?? throw new ArgumentNullException(nameof(pluginExecutionContextMock));
            this.organizationServiceFactoryMock = organizationServiceFactoryMock ?? throw new ArgumentNullException(nameof(organizationServiceFactoryMock));
            this.tracingServiceMock = tracingServiceMock ?? throw new ArgumentNullException(nameof(tracingServiceMock));

            this.Setup(provider => provider.GetService(It.Is<Type>(t => t == typeof(IPluginExecutionContext)))).Returns(this.pluginExecutionContextMock.Object);
            this.Setup(provider => provider.GetService(It.Is<Type>(t => t == typeof(IOrganizationServiceFactory)))).Returns(this.organizationServiceFactoryMock.Object);
            this.Setup(provider => provider.GetService(It.Is<Type>(t => t == typeof(ITracingService)))).Returns(this.tracingServiceMock.Object);
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ServiceProviderMock"/> class
        /// </summary>
        /// <param name="pluginExecutionContextMock">An instance of <see cref="IPluginExecutionContextMock"/> used for querying plugin activities</param>
        /// <param name="organizationServiceMock">An instance of <see cref="IOrganizationServiceMock"/> for mocking calls to Dynamics 365</param>
        /// /// <param name="tracingServiceMock">An instance of <see cref="ITracingServiceMock"/> used for verifying calls to the tracing service</param>
        public ServiceProviderMock(IPluginExecutionContextMock pluginExecutionContextMock, IOrganizationServiceMock organizationServiceMock, ITracingServiceMock tracingServiceMock)
            : this(pluginExecutionContextMock, new OrganizationServiceFactoryMock(organizationServiceMock), tracingServiceMock)
        {
        }
    }
}