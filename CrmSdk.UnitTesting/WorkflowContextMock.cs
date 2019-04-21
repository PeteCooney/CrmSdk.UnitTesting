// <copyright file="WorkflowContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using Microsoft.Xrm.Sdk.Workflow;

    /// <summary>
    /// A mocked instance of <seealso cref="IWorkflowContext"/>
    /// </summary>
    /// <seealso cref="IWorkflowContextMock"/>
    /// <seealso cref="ExecutionContextMock{TContext}"/>
    public class WorkflowContextMock : ExecutionContextMock<IWorkflowContext>, IWorkflowContextMock
    {
        private IWorkflowContext parentContext;
        private string stageName;
        private int workflowCategory;
        private int workflowMode;

        /// <summary>
        /// Initialises a new instance of the <see cref="WorkflowContextMock"/> class
        /// </summary>
        public WorkflowContextMock()
            : base()
        {
        }

        /// <inheritdoc />
        public IWorkflowContext ParentContext
        {
            get
            {
                return this.parentContext;
            }

            set
            {
                this.parentContext = value;
                this.SetupGet(context => context.ParentContext).Returns(value);
            }
        }

        /// <inheritdoc />
        public string StageName
        {
            get
            {
                return this.stageName;
            }

            set
            {
                this.stageName = value;
                this.SetupGet(context => context.StageName).Returns(value);
            }
        }

        /// <inheritdoc />
        public int WorkflowCategory
        {
            get
            {
                return this.workflowCategory;
            }

            set
            {
                this.workflowCategory = value;
                this.SetupGet(context => context.WorkflowCategory).Returns(value);
            }
        }

        /// <inheritdoc />
        public int WorkflowMode
        {
            get
            {
                return this.workflowMode;
            }

            set
            {
                this.workflowMode = value;
                this.SetupGet(context => context.WorkflowMode).Returns(value);
            }
        }
    }
}