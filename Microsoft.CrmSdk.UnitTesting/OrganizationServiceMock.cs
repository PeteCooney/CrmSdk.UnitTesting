// <copyright file="OrganizationServiceMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;
    using Moq;
    using Moq.Language.Flow;

    /// <summary>
    /// A mocked instance of <seealso cref="IOrganizationService"/>
    /// </summary>
    /// <seealso cref="IOrganizationServiceMock"/>
    public class OrganizationServiceMock : Mock<IOrganizationService>, IOrganizationServiceMock
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="OrganizationServiceMock"/> class
        /// </summary>
        public OrganizationServiceMock()
            : base()
        {
        }

        /// <inheritdoc />
        public IThrowsResult SetupAssociate(string logicalName, Guid entityId, string relationshipName, Exception exception)
        {
            return this
                .Setup(service => service.Associate(
                    It.Is<string>(x => x == logicalName),
                    It.Is<Guid>(x => x == entityId),
                    It.Is<Relationship>(r => r.SchemaName == relationshipName),
                    It.IsAny<EntityReferenceCollection>()))
                .Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupAssociate(Exception exception)
        {
            return this
                .Setup(service => service.Associate(
                    It.IsAny<string>(),
                    It.IsAny<Guid>(),
                    It.IsAny<Relationship>(),
                    It.IsAny<EntityReferenceCollection>()))
                .Throws(exception);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupCreate(string logicalName, Guid returnId)
        {
            return this.Setup(service => service.Create(It.Is<Entity>(e => e.LogicalName == logicalName))).Returns(returnId);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupCreate(string logicalName)
        {
            return this.Setup(service => service.Create(It.Is<Entity>(e => e.LogicalName == logicalName))).Returns(Guid.NewGuid());
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupCreate(Guid returnId)
        {
            return this.Setup(service => service.Create(It.IsAny<Entity>())).Returns(returnId);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupCreate()
        {
            return this.Setup(service => service.Create(It.IsAny<Entity>())).Returns(Guid.NewGuid());
        }

        /// <inheritdoc />
        public IThrowsResult SetupCreate(string logicalName, Exception exception)
        {
            return this.Setup(service => service.Create(It.Is<Entity>(e => e.LogicalName == logicalName))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupCreate(Exception exception)
        {
            return this.Setup(service => service.Create(It.IsAny<Entity>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupDelete(string logicalName, Guid entityId, Exception exception)
        {
            return this.Setup(service => service.Delete(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupDelete(string logicalName, Exception exception)
        {
            return this.Setup(service => service.Delete(It.Is<string>(x => x == logicalName), It.IsAny<Guid>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupDelete(Exception exception)
        {
            return this.Setup(service => service.Delete(It.IsAny<string>(), It.IsAny<Guid>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupDisassociate(string logicalName, Guid entityId, string relationshipName, Exception exception)
        {
            return this
                .Setup(service => service.Disassociate(
                    It.Is<string>(x => x == logicalName),
                    It.Is<Guid>(x => x == entityId),
                    It.Is<Relationship>(r => r.SchemaName == relationshipName),
                    It.IsAny<EntityReferenceCollection>()))
                .Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupDisassociate(Exception exception)
        {
            return this
                .Setup(service => service.Disassociate(
                    It.IsAny<string>(),
                    It.IsAny<Guid>(),
                    It.IsAny<Relationship>(),
                    It.IsAny<EntityReferenceCollection>()))
                .Throws(exception);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupExecute<TRequest>(OrganizationResponse returnResponse)
            where TRequest : OrganizationRequest
        {
            return this.Setup(service => service.Execute(It.Is<OrganizationRequest>(x => x is TRequest))).Returns(returnResponse);
        }

        /// <inheritdoc />
        public IThrowsResult SetupExecute<TRequest>(Exception exception)
            where TRequest : OrganizationRequest
        {
            return this.Setup(service => service.Execute(It.Is<OrganizationRequest>(x => x is TRequest))).Throws(exception);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupExecute<TRequest>(Expression<Func<TRequest, bool>> match, OrganizationResponse returnResponse)
            where TRequest : OrganizationRequest
        {
            return this.Setup(service => service.Execute(It.Is<TRequest>(match))).Returns(returnResponse);
        }

        /// <inheritdoc />
        public IThrowsResult SetupExecute<TRequest>(Expression<Func<TRequest, bool>> match, Exception exception)
            where TRequest : OrganizationRequest
        {
            return this.Setup(service => service.Execute(It.Is<TRequest>(match))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieve(string logicalName, Guid entityId, Exception exception)
        {
            return this.Setup(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId), It.IsAny<ColumnSet>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieve(string logicalName, Exception exception)
        {
            return this.Setup(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.IsAny<Guid>(), It.IsAny<ColumnSet>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieve(Exception exception)
        {
            return this.Setup(service => service.Retrieve(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<ColumnSet>())).Throws(exception);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieve(string logicalName, Guid entityId, Entity returnEntity)
        {
            return this.Setup(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId), It.IsAny<ColumnSet>())).Returns(returnEntity);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieve(string logicalName, Entity returnEntity)
        {
            return this.Setup(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.IsAny<Guid>(), It.IsAny<ColumnSet>())).Returns(returnEntity);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieve(Entity returnEntity)
        {
            return this.Setup(service => service.Retrieve(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<ColumnSet>())).Returns(returnEntity);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieveMultiple(string logicalName, params Entity[] returnEntityCollection)
        {
            return this.Setup(service => service.RetrieveMultiple(It.Is<QueryExpression>(qe => qe.EntityName == logicalName))).Returns(new EntityCollection(returnEntityCollection));
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieveMultiple(params Entity[] returnEntityCollection)
        {
            return this.Setup(service => service.RetrieveMultiple(It.IsAny<QueryBase>())).Returns(new EntityCollection(returnEntityCollection));
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieveMultiple(string logicalName, Exception exception)
        {
            return this.Setup(service => service.RetrieveMultiple(It.Is<QueryExpression>(qe => qe.EntityName == logicalName))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieveMultiple(Exception exception)
        {
            return this.Setup(service => service.RetrieveMultiple(It.IsAny<QueryBase>())).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Exception exception)
            where TQuery : QueryBase
        {
            return this.Setup(service => service.RetrieveMultiple(It.Is<TQuery>(match))).Throws(exception);
        }

        /// <inheritdoc />
        public IReturnsResult<IOrganizationService> SetupRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, params Entity[] returnEntityCollection)
            where TQuery : QueryBase
        {
            return this.Setup(service => service.RetrieveMultiple(It.Is<TQuery>(match))).Returns(new EntityCollection(returnEntityCollection));
        }

        /// <inheritdoc />
        public IThrowsResult SetupUpdate(string logicalName, Exception exception)
        {
            return this.Setup(service => service.Update(It.Is<Entity>(x => x.LogicalName == logicalName))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupUpdate(string logicalName, Guid entityId, Exception exception)
        {
            return this.Setup(service => service.Update(It.Is<Entity>(x => x.LogicalName == logicalName && x.Id == entityId))).Throws(exception);
        }

        /// <inheritdoc />
        public IThrowsResult SetupUpdate(Exception exception)
        {
            return this.Setup(service => service.Update(It.IsAny<Entity>())).Throws(exception);
        }

        /// <inheritdoc />
        public void VerifyAssociate(string logicalName, Guid entityId, string relationshipName, Func<Times> times)
        {
            this
                .Verify(
                    service => service.Associate(
                        It.Is<string>(x => x == logicalName),
                        It.Is<Guid>(x => x == entityId),
                        It.Is<Relationship>(r => r.SchemaName == relationshipName),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyAssociate(string logicalName, Guid entityId, string relationshipName, Times times)
        {
            this
                .Verify(
                    service => service.Associate(
                        It.Is<string>(x => x == logicalName),
                        It.Is<Guid>(x => x == entityId),
                        It.Is<Relationship>(r => r.SchemaName == relationshipName),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyAssociate(Func<Times> times)
        {
            this
                .Verify(
                    service => service.Associate(
                        It.IsAny<string>(),
                        It.IsAny<Guid>(),
                        It.IsAny<Relationship>(),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyAssociate(Times times)
        {
            this
                .Verify(
                    service => service.Associate(
                        It.IsAny<string>(),
                        It.IsAny<Guid>(),
                        It.IsAny<Relationship>(),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyCreate(string logicalName, Func<Times> times)
        {
            this.Verify(service => service.Create(It.Is<Entity>(e => e.LogicalName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyCreate(string logicalName, Times times)
        {
            this.Verify(service => service.Create(It.Is<Entity>(e => e.LogicalName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyCreate(Func<Times> times)
        {
            this.Verify(service => service.Create(It.IsAny<Entity>()), times);
        }

        /// <inheritdoc />
        public void VerifyCreate(Times times)
        {
            this.Verify(service => service.Create(It.IsAny<Entity>()), times);
        }

        /// <inheritdoc />
        public void VerifyCreate(Expression<Func<Entity, bool>> match, Func<Times> times)
        {
            this.Verify(service => service.Create(It.Is<Entity>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyCreate(Expression<Func<Entity, bool>> match, Times times)
        {
            this.Verify(service => service.Create(It.Is<Entity>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(string logicalName, Guid entityId, Func<Times> times)
        {
            this.Verify(service => service.Delete(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId)), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(string logicalName, Guid entityId, Times times)
        {
            this.Verify(service => service.Delete(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId)), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(string logicalName, Func<Times> times)
        {
            this.Verify(service => service.Delete(It.Is<string>(x => x == logicalName), It.IsAny<Guid>()), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(string logicalName, Times times)
        {
            this.Verify(service => service.Delete(It.Is<string>(x => x == logicalName), It.IsAny<Guid>()), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(Func<Times> times)
        {
            this.Verify(service => service.Delete(It.IsAny<string>(), It.IsAny<Guid>()), times);
        }

        /// <inheritdoc />
        public void VerifyDelete(Times times)
        {
            this.Verify(service => service.Delete(It.IsAny<string>(), It.IsAny<Guid>()), times);
        }

        /// <inheritdoc />
        public void VerifyDisassociate(string logicalName, Guid entityId, string relationshipName, Func<Times> times)
        {
            this
                .Verify(
                    service => service.Disassociate(
                        It.Is<string>(x => x == logicalName),
                        It.Is<Guid>(x => x == entityId),
                        It.Is<Relationship>(r => r.SchemaName == relationshipName),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyDisassociate(string logicalName, Guid entityId, string relationshipName, Times times)
        {
            this
                .Verify(
                    service => service.Disassociate(
                        It.Is<string>(x => x == logicalName),
                        It.Is<Guid>(x => x == entityId),
                        It.Is<Relationship>(r => r.SchemaName == relationshipName),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyDisassociate(Func<Times> times)
        {
            this
                .Verify(
                    service => service.Disassociate(
                        It.IsAny<string>(),
                        It.IsAny<Guid>(),
                        It.IsAny<Relationship>(),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyDisassociate(Times times)
        {
            this
                .Verify(
                    service => service.Disassociate(
                        It.IsAny<string>(),
                        It.IsAny<Guid>(),
                        It.IsAny<Relationship>(),
                        It.IsAny<EntityReferenceCollection>()),
                    times);
        }

        /// <inheritdoc />
        public void VerifyExecute<TRequest>(Func<Times> times)
            where TRequest : OrganizationRequest
        {
            this.Verify(service => service.Execute(It.IsAny<TRequest>()), times);
        }

        /// <inheritdoc />
        public void VerifyExecute<TRequest>(Times times)
            where TRequest : OrganizationRequest
        {
            this.Verify(service => service.Execute(It.IsAny<TRequest>()), times);
        }

        /// <inheritdoc />
        public void VerifyExecute<TRequest>(Expression<Func<TRequest, bool>> match, Func<Times> times)
            where TRequest : OrganizationRequest
        {
            this.Verify(service => service.Execute(It.Is<TRequest>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyExecute<TRequest>(Expression<Func<TRequest, bool>> match, Times times)
            where TRequest : OrganizationRequest
        {
            this.Verify(service => service.Execute(It.Is<TRequest>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(string logicalName, Guid entityId, Func<Times> times)
        {
            this.Verify(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(string logicalName, Guid entityId, Times times)
        {
            this.Verify(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.Is<Guid>(x => x == entityId), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(string logicalName, Func<Times> times)
        {
            this.Verify(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.IsAny<Guid>(), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(string logicalName, Times times)
        {
            this.Verify(service => service.Retrieve(It.Is<string>(x => x == logicalName), It.IsAny<Guid>(), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(Func<Times> times)
        {
            this.Verify(service => service.Retrieve(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieve(Times times)
        {
            this.Verify(service => service.Retrieve(It.IsAny<string>(), It.IsAny<Guid>(), It.IsAny<ColumnSet>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple(string logicalName, Func<Times> times)
        {
            this.Verify(service => service.RetrieveMultiple(It.Is<QueryExpression>(qe => qe.EntityName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple(string logicalName, Times times)
        {
            this.Verify(service => service.RetrieveMultiple(It.Is<QueryExpression>(qe => qe.EntityName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple(Func<Times> times)
        {
            this.Verify(service => service.RetrieveMultiple(It.IsAny<QueryBase>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple(Times times)
        {
            this.Verify(service => service.RetrieveMultiple(It.IsAny<QueryBase>()), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Func<Times> times)
            where TQuery : QueryBase
        {
            this.Verify(service => service.RetrieveMultiple(It.Is<TQuery>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Times times)
            where TQuery : QueryBase
        {
            this.Verify(service => service.RetrieveMultiple(It.Is<TQuery>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(string logicalName, Guid entityId, Func<Times> times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(e => e.LogicalName == logicalName && e.Id == entityId)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(string logicalName, Guid entityId, Times times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(e => e.LogicalName == logicalName && e.Id == entityId)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(string logicalName, Func<Times> times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(e => e.LogicalName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(string logicalName, Times times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(e => e.LogicalName == logicalName)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(Func<Times> times)
        {
            this.Verify(service => service.Update(It.IsAny<Entity>()), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(Times times)
        {
            this.Verify(service => service.Update(It.IsAny<Entity>()), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(Expression<Func<Entity, bool>> match, Func<Times> times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(match)), times);
        }

        /// <inheritdoc />
        public void VerifyUpdate(Expression<Func<Entity, bool>> match, Times times)
        {
            this.Verify(service => service.Update(It.Is<Entity>(match)), times);
        }
    }
}