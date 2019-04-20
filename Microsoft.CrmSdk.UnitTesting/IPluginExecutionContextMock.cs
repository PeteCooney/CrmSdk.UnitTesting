// <copyright file="IPluginExecutionContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using Microsoft.Xrm.Sdk;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="IPluginExecutionContext"/>
    /// </summary>
    /// <seealso cref="IExecutionContextMock{TContext}"/>
    public interface IPluginExecutionContextMock : IExecutionContextMock<IPluginExecutionContext>
    {
        /// <summary>
        /// Gets or sets the parent context of the plugin being mocked
        /// </summary>
        IPluginExecutionContext ParentContext { get; set; }

        /// <summary>
        /// Gets or sets the execution stage of the plugin being mocked
        /// </summary>
        int Stage { get; set; }
    }
}