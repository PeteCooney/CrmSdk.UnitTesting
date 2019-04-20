// <copyright file="IWorkflowContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using Microsoft.Xrm.Sdk.Workflow;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="IWorkflowContext"/>
    /// </summary>
    /// <seealso cref="IExecutionContextMock{TContext}"/>
    public interface IWorkflowContextMock : IExecutionContextMock<IWorkflowContext>
    {
        /// <summary>
        /// Gets or sets the parent context of the workflow being mocked
        /// </summary>
        IWorkflowContext ParentContext { get; set; }

        /// <summary>
        /// Gets or sets the execution stage name of the workflow being mocked
        /// </summary>
        string StageName { get; set; }

        /// <summary>
        /// Gets or sets the category of the workflow being mocked
        /// </summary>
        int WorkflowCategory { get; set; }

        /// <summary>
        /// Gets or sets the mode of the workflow being mocked
        /// </summary>
        int WorkflowMode { get; set; }
    }
}