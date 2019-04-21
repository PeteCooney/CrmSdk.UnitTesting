// <copyright file="PluginExecutionContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using Microsoft.Xrm.Sdk;

    /// <summary>
    /// A mocked instance of <seealso cref="IPluginExecutionContext"/>
    /// </summary>
    /// <seealso cref="IPluginExecutionContextMock"/>
    /// <seealso cref="ExecutionContextMock{TContext}"/>
    public class PluginExecutionContextMock : ExecutionContextMock<IPluginExecutionContext>, IPluginExecutionContextMock
    {
        private IPluginExecutionContext parentContext;
        private int stage;

        /// <summary>
        /// Initialises a new instance of the <see cref="PluginExecutionContextMock"/> class
        /// </summary>
        public PluginExecutionContextMock()
            : base()
        {
        }

        /// <inheritdoc />
        public IPluginExecutionContext ParentContext
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
        public int Stage
        {
            get
            {
                return this.stage;
            }

            set
            {
                this.stage = value;
                this.SetupGet(context => context.Stage).Returns(value);
            }
        }
    }
}