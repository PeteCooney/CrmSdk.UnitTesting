// <copyright file="IExecutionContextMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="IExecutionContextMock{TContext}"/>
    /// </summary>
    /// <typeparam name="TContext">The type of <see cref="IExecutionContext"/> being mocked</typeparam>
    public interface IExecutionContextMock<TContext> : IMock<TContext>
        where TContext : class, IExecutionContext
    {
        /// <summary>
        /// Gets or sets the id of the Business Unit for the context being mocked
        /// </summary>
        Guid BusinessUnitId { get; set; }

        /// <summary>
        /// Gets or sets the correlation id of the context being mocked
        /// </summary>
        Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the execution depth of the context being mocked
        /// </summary>
        int Depth { get; set; }

        /// <summary>
        /// Gets or sets the id of the initiating User for the context being mocked
        /// </summary>
        Guid InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets a collection of input parameters for the context being mocked
        /// </summary>
        ParameterCollection InputParameters { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mocked context is being executed offline
        /// </summary>
        bool IsExecutingOffline { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mocked context is being executed in a transaction
        /// </summary>
        bool IsInTransaction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mocked context is being executed in offline playback mode
        /// </summary>
        bool IsOfflinePlayback { get; set; }

        /// <summary>
        /// Gets or sets the isolation mode of the context being mocked
        /// </summary>
        int IsolationMode { get; set; }

        /// <summary>
        /// Gets or sets the message name of the context being mocked
        /// </summary>
        string MessageName { get; set; }

        /// <summary>
        /// Gets or sets the mode of the context being mocked
        /// </summary>
        int Mode { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DateTime"/> the context being mocked was started
        /// </summary>
        DateTime OperationCreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the operation id of the context being mocked
        /// </summary>
        Guid OperationId { get; set; }

        /// <summary>
        /// Gets or sets the organization id for the context being mocked
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the organization name for the context being mocked
        /// </summary>
        string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets a collection of output parameters for the context being mocked
        /// </summary>
        ParameterCollection OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the owning extension of the context being mocked
        /// </summary>
        EntityReference OwningExtension { get; set; }

        /// <summary>
        /// Gets or sets a collection of Post-images for the context being mocked
        /// </summary>
        EntityImageCollection PostEntityImages { get; set; }

        /// <summary>
        /// Gets or sets a collection of Pre-images for the context being mocked
        /// </summary>
        EntityImageCollection PreEntityImages { get; set; }

        /// <summary>
        /// Gets or sets the id of the entity invoking the context being mocked
        /// </summary>
        Guid PrimaryEntityId { get; set; }

        /// <summary>
        /// Gets or sets the primary logical name of the entity invoking the context being mocked
        /// </summary>
        string PrimaryEntityName { get; set; }

        /// <summary>
        /// Gets or sets the request id of the context being mocked
        /// </summary>
        Guid? RequestId { get; set; }

        /// <summary>
        /// Gets or sets the secondary logical name of the entity invoking the context being mocked
        /// </summary>
        string SecondaryEntityName { get; set; }

        /// <summary>
        /// Gets or sets a collection of shared variables for the context being mocked
        /// </summary>
        ParameterCollection SharedVariables { get; set; }

        /// <summary>
        /// Gets or sets the id of the User as whom the mocked context is being executed
        /// </summary>
        Guid UserId { get; set; }

        /// <summary>
        /// Add an image to the PreEntityImages collection
        /// </summary>
        /// <param name="imageName">The alias of the image being added</param>
        /// <param name="image">The image being added</param>
        void AddPreImage(string imageName, Entity image);

        /// <summary>
        /// Add an image to the PostEntityImages collection
        /// </summary>
        /// <param name="imageName">The alias of the image being added</param>
        /// <param name="image">The image being added</param>
        void AddPostImage(string imageName, Entity image);
    }
}