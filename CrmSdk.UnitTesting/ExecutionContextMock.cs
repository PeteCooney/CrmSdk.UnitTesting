// <copyright file="ExecutionContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// A mocked instance of <seealso cref="IExecutionContext"/>
    /// </summary>
    /// <typeparam name="TContext">The type of <see cref="IExecutionContext"/> being mocked</typeparam>
    /// <seealso cref="IExecutionContextMock{TContext}"/>
    public abstract class ExecutionContextMock<TContext> : Mock<TContext>, IExecutionContextMock<TContext>
        where TContext : class, IExecutionContext
    {
        private Guid businessUnitId;
        private Guid correlationId;
        private int depth;
        private Guid initiatingUserId;
        private ParameterCollection inputParameters;
        private bool isExecutingOffline;
        private bool isInTransaction;
        private bool isOfflinePlayback;
        private int isolationMode;
        private string messageName;
        private int mode;
        private DateTime operationCreatedOn;
        private Guid operationId;
        private Guid organizationId;
        private string organizationName;
        private ParameterCollection outputParameters;
        private EntityReference owningExtension;
        private EntityImageCollection postEntityImages;
        private EntityImageCollection preEntityImages;
        private Guid primaryEntityId;
        private string primaryEntityName;
        private Guid? requestId;
        private string secondaryEntityName;
        private ParameterCollection sharedVariables;
        private Guid userId;

        /// <summary>
        /// Initialises a new instance of the <see cref="ExecutionContextMock{TContext}"/> class
        /// </summary>
        public ExecutionContextMock()
            : base()
        {
            // Initialise collections
            this.InputParameters = new ParameterCollection();
            this.OutputParameters = new ParameterCollection();
            this.PostEntityImages = new EntityImageCollection();
            this.PreEntityImages = new EntityImageCollection();
            this.SharedVariables = new ParameterCollection();
        }

        /// <inheritdoc />
        public Guid BusinessUnitId
        {
            get
            {
                return this.businessUnitId;
            }

            set
            {
                this.businessUnitId = value;
                this.SetupGet(context => context.BusinessUnitId).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid CorrelationId
        {
            get
            {
                return this.correlationId;
            }

            set
            {
                this.correlationId = value;
                this.SetupGet(context => context.CorrelationId).Returns(value);
            }
        }

        /// <inheritdoc />
        public int Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                this.depth = value;
                this.SetupGet(context => context.Depth).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid InitiatingUserId
        {
            get
            {
                return this.initiatingUserId;
            }

            set
            {
                this.initiatingUserId = value;
                this.SetupGet(context => context.InitiatingUserId).Returns(value);
            }
        }

        /// <inheritdoc />
        public ParameterCollection InputParameters
        {
            get
            {
                return this.inputParameters;
            }

            set
            {
                this.inputParameters = value;
                this.SetupGet(context => context.InputParameters).Returns(value);
            }
        }

        /// <inheritdoc />
        public bool IsExecutingOffline
        {
            get
            {
                return this.isExecutingOffline;
            }

            set
            {
                this.isExecutingOffline = value;
                this.SetupGet(context => context.IsExecutingOffline).Returns(value);
            }
        }

        /// <inheritdoc />
        public bool IsInTransaction
        {
            get
            {
                return this.isInTransaction;
            }

            set
            {
                this.isInTransaction = value;
                this.SetupGet(context => context.IsInTransaction).Returns(value);
            }
        }

        /// <inheritdoc />
        public bool IsOfflinePlayback
        {
            get
            {
                return this.isOfflinePlayback;
            }

            set
            {
                this.isOfflinePlayback = value;
                this.SetupGet(context => context.IsOfflinePlayback).Returns(value);
            }
        }

        /// <inheritdoc />
        public int IsolationMode
        {
            get
            {
                return this.isolationMode;
            }

            set
            {
                this.isolationMode = value;
                this.SetupGet(context => context.IsolationMode).Returns(value);
            }
        }

        /// <inheritdoc />
        public string MessageName
        {
            get
            {
                return this.messageName;
            }

            set
            {
                this.messageName = value;
                this.SetupGet(c => c.MessageName).Returns(value);
            }
        }

        /// <inheritdoc />
        public int Mode
        {
            get
            {
                return this.mode;
            }

            set
            {
                this.mode = value;
                this.SetupGet(context => context.Mode).Returns(value);
            }
        }

        /// <inheritdoc />
        public DateTime OperationCreatedOn
        {
            get
            {
                return this.operationCreatedOn;
            }

            set
            {
                this.operationCreatedOn = value;
                this.SetupGet(context => context.OperationCreatedOn).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid OperationId
        {
            get
            {
                return this.operationId;
            }

            set
            {
                this.operationId = value;
                this.SetupGet(context => context.OperationId).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid OrganizationId
        {
            get
            {
                return this.organizationId;
            }

            set
            {
                this.organizationId = value;
                this.SetupGet(context => context.OrganizationId).Returns(value);
            }
        }

        /// <inheritdoc />
        public string OrganizationName
        {
            get
            {
                return this.organizationName;
            }

            set
            {
                this.organizationName = value;
                this.SetupGet(context => context.OrganizationName).Returns(value);
            }
        }

        /// <inheritdoc />
        public ParameterCollection OutputParameters
        {
            get
            {
                return this.outputParameters;
            }

            set
            {
                this.outputParameters = value;
                this.SetupGet(context => context.OutputParameters).Returns(value);
            }
        }

        /// <inheritdoc />
        public EntityReference OwningExtension
        {
            get
            {
                return this.owningExtension;
            }

            set
            {
                this.owningExtension = value;
                this.SetupGet(context => context.OwningExtension).Returns(value);
            }
        }

        /// <inheritdoc />
        public EntityImageCollection PostEntityImages
        {
            get
            {
                return this.postEntityImages;
            }

            set
            {
                this.postEntityImages = value;
                this.SetupGet(context => context.PostEntityImages).Returns(value);
            }
        }

        /// <inheritdoc />
        public EntityImageCollection PreEntityImages
        {
            get
            {
                return this.preEntityImages;
            }

            set
            {
                this.preEntityImages = value;
                this.SetupGet(context => context.PreEntityImages).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid PrimaryEntityId
        {
            get
            {
                return this.primaryEntityId;
            }

            set
            {
                this.primaryEntityId = value;
                this.SetupGet(context => context.PrimaryEntityId).Returns(value);
            }
        }

        /// <inheritdoc />
        public string PrimaryEntityName
        {
            get
            {
                return this.primaryEntityName;
            }

            set
            {
                this.primaryEntityName = value;
                this.SetupGet(context => context.PrimaryEntityName).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid? RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.requestId = value;
                this.SetupGet(context => context.RequestId).Returns(value);
            }
        }

        /// <inheritdoc />
        public string SecondaryEntityName
        {
            get
            {
                return this.secondaryEntityName;
            }

            set
            {
                this.secondaryEntityName = value;
                this.SetupGet(context => context.SecondaryEntityName).Returns(value);
            }
        }

        /// <inheritdoc />
        public ParameterCollection SharedVariables
        {
            get
            {
                return this.sharedVariables;
            }

            set
            {
                this.sharedVariables = value;
                this.SetupGet(context => context.SharedVariables).Returns(value);
            }
        }

        /// <inheritdoc />
        public Guid UserId
        {
            get
            {
                return this.userId;
            }

            set
            {
                this.userId = value;
                this.SetupGet(context => context.UserId).Returns(value);
            }
        }

        /// <inheritdoc />
        public virtual void AddPreImage(string imageName, Entity image)
        {
            this.PreEntityImages.Add(imageName, image);
        }

        /// <inheritdoc />
        public virtual void AddPostImage(string imageName, Entity image)
        {
            this.PostEntityImages.Add(imageName, image);
        }
    }
}