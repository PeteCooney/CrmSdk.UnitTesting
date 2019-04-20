// <copyright file="IOrganizationServiceMock.cs" author="Peter Cooney">
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
    /// Interface describing a mocked instance of <seealso cref="IOrganizationService"/>
    /// </summary>
    public interface IOrganizationServiceMock : IMock<IOrganizationService>
    {
        /// <summary>
        /// Setup calls to the Associate method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupAssociate(Exception exception);

        /// <summary>
        /// Setup calls to the Associate method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupAssociate(string logicalName, Guid entityId, string relationshipName, Exception exception);

        /// <summary>
        /// Setup calls to the Create method to return a random <see cref="Guid"/>
        /// </summary>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupCreate();

        /// <summary>
        /// Setup calls to the Create method, with the specified arguments, to return a random <see cref="Guid"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupCreate(string logicalName);

        /// <summary>
        /// Setup calls to the Create method to return a known <see cref="Guid"/>
        /// </summary>
        /// <param name="returnId">A known <see cref="Guid"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupCreate(Guid returnId);

        /// <summary>
        /// Setup calls to the Create method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupCreate(Exception exception);

        /// <summary>
        /// Setup calls to the Create method, with the specified arguments, to return a known <see cref="Guid"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="returnId">A known <see cref="Guid"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupCreate(string logicalName, Guid returnId);

        /// <summary>
        /// Setup calls to the Create method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupCreate(string logicalName, Exception exception);

        /// <summary>
        /// Setup calls to the Delete method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupDelete(Exception exception);

        /// <summary>
        /// Setup calls to the Delete method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupDelete(string logicalName, Exception exception);

        /// <summary>
        /// Setup calls to the Delete method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupDelete(string logicalName, Guid entityId, Exception exception);

        /// <summary>
        /// Setup calls to the Disassociate method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupDisassociate(Exception exception);

        /// <summary>
        /// Setup calls to the Disassociate method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupDisassociate(string logicalName, Guid entityId, string relationshipName, Exception exception);

        /// <summary>
        /// Setup calls to the Execute method to return a known <see cref="OrganizationResponse"/>
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="returnResponse">The <see cref="OrganizationResponse"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupExecute<TRequest>(OrganizationResponse returnResponse)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Setup calls to the Execute method to return a known <see cref="OrganizationResponse"/>
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="returnResponse">The <see cref="OrganizationResponse"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupExecute<TRequest>(Expression<Func<TRequest, bool>> match, OrganizationResponse returnResponse)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Setup calls to the Execute method to throw an <see cref="Exception"/>
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupExecute<TRequest>(Exception exception)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Setup calls to the Execute method to throw an <see cref="Exception"/>
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupExecute<TRequest>(Expression<Func<TRequest, bool>> match, Exception exception)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Setup calls to the Retrieve method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieve(Exception exception);

        /// <summary>
        /// Setup calls to the Retrieve method to return a known <see cref="Entity"/>
        /// </summary>
        /// <param name="returnEntity">The <see cref="Entity"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieve(Entity returnEntity);

        /// <summary>
        /// Setup calls to the Retrieve method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieve(string logicalName, Exception exception);

        /// <summary>
        /// Setup calls to the Retrieve method, with the specified arguments, to return a known <see cref="Entity"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="returnEntity">The <see cref="Entity"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieve(string logicalName, Entity returnEntity);

        /// <summary>
        /// Setup calls to the Retrieve method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieve(string logicalName, Guid entityId, Exception exception);

        /// <summary>
        /// Setup calls to the Retrieve method, with the specified arguments, to return a known <see cref="Entity"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="returnEntity">The <see cref="Entity"/> to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieve(string logicalName, Guid entityId, Entity returnEntity);

        /// <summary>
        /// Setup calls to the RetrieveMultiple method to return a collection of known <see cref="Entity"/> records
        /// </summary>
        /// <param name="returnEntityCollection">The collection of <see cref="Entity"/> records to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieveMultiple(params Entity[] returnEntityCollection);

        /// <summary>
        /// Setup calls to the RetrieveMultiple method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieveMultiple(Exception exception);

        /// <summary>
        /// Setup calls to the RetrieveMultiple method, with the specified arguments, to return a collection of known <see cref="Entity"/> records
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="returnEntityCollection">The collection of <see cref="Entity"/> records to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieveMultiple(string logicalName, params Entity[] returnEntityCollection);

        /// <summary>
        /// Setup calls to the RetrieveMultiple method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieveMultiple(string logicalName, Exception exception);

        /// <summary>
        /// Setup calls to the RetrieveMultiple method, with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <typeparam name="TQuery">The type of <see cref="QueryBase"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Exception exception)
            where TQuery : QueryBase;

        /// <summary>
        /// Setup calls to the RetrieveMultiple method to return a collection of known <see cref="Entity"/> records
        /// </summary>
        /// <typeparam name="TQuery">The type of <see cref="QueryBase"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="returnEntityCollection">The collection of <see cref="Entity"/> records to be returned</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IReturnsResult<IOrganizationService> SetupRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, params Entity[] returnEntityCollection)
            where TQuery : QueryBase;

        /// <summary>
        /// Setup calls to the Update method to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupUpdate(Exception exception);

        /// <summary>
        /// Setup calls to the Update method with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IReturnsResult{IOrganizationService}"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupUpdate(string logicalName, Exception exception);

        /// <summary>
        /// Setup calls to the Update method with the specified arguments, to throw an <see cref="Exception"/>
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An id to filter against</param>
        /// <param name="exception">The <see cref="Exception"/> to be thrown</param>
        /// <returns>An <see cref="IThrowsResult"/> to allow for continuation of the fluent API</returns>
        IThrowsResult SetupUpdate(string logicalName, Guid entityId, Exception exception);

        /// <summary>
        /// Verify that the Associate method has been called with the specified arguments
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyAssociate(Func<Times> times);

        /// <summary>
        /// Verify that the Associate method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyAssociate(string logicalName, Guid entityId, string relationshipName, Func<Times> times);

        /// <summary>
        /// Verify that the Associate method has been called with the specified arguments
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyAssociate(Times times);

        /// <summary>
        /// Verify that the Associate method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyAssociate(string logicalName, Guid entityId, string relationshipName, Times times);

        /// <summary>
        /// Verify that the Create method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(Func<Times> times);

        /// <summary>
        /// Verify that the Create method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(string logicalName, Func<Times> times);

        /// <summary>
        /// Verify that the Create method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(Times times);

        /// <summary>
        /// Verify that the Create method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(string logicalName, Times times);

        /// <summary>
        /// Verify that the Create method has been called satisfying the given predicate
        /// </summary>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(Expression<Func<Entity, bool>> match, Func<Times> times);

        /// <summary>
        /// Verify that the Create method has been called satisfying the given predicate
        /// </summary>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyCreate(Expression<Func<Entity, bool>> match, Times times);

        /// <summary>
        /// Verify that the Delete method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(Func<Times> times);

        /// <summary>
        /// Verify that the Delete method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(string logicalName, Func<Times> times);

        /// <summary>
        /// Verify that the Delete method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(string logicalName, Guid entityId, Func<Times> times);

        /// <summary>
        /// Verify that the Delete method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(Times times);

        /// <summary>
        /// Verify that the Delete method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(string logicalName, Times times);

        /// <summary>
        /// Verify that the Delete method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDelete(string logicalName, Guid entityId, Times times);

        /// <summary>
        /// Verify that the Disassociate method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDisassociate(Func<Times> times);

        /// <summary>
        /// Verify that the Disassociate method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDisassociate(string logicalName, Guid entityId, string relationshipName, Func<Times> times);

        /// <summary>
        /// Verify that the Disassociate method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDisassociate(Times times);

        /// <summary>
        /// Verify that the Disassociate method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="relationshipName">A relationship name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyDisassociate(string logicalName, Guid entityId, string relationshipName, Times times);

        /// <summary>
        /// Verify that the Execute method has been called
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="times">The number of times the method was called</param>
        void VerifyExecute<TRequest>(Func<Times> times)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Verify that the Execute method has been called
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="times">The number of times the method was called</param>
        void VerifyExecute<TRequest>(Times times)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Verify that the Execute method has been called satisfying the given predicate
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyExecute<TRequest>(Expression<Func<TRequest, bool>> match, Func<Times> times)
           where TRequest : OrganizationRequest;

        /// <summary>
        /// Verify that the Execute method has been called satisfying the given predicate
        /// </summary>
        /// <typeparam name="TRequest">The type of <see cref="OrganizationRequest"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyExecute<TRequest>(Expression<Func<TRequest, bool>> match, Times times)
            where TRequest : OrganizationRequest;

        /// <summary>
        /// Verify that the Retrieve method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(Func<Times> times);

        /// <summary>
        /// Verify that the Retrieve method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(string logicalName, Func<Times> times);

        /// <summary>
        /// Verify that the Retrieve method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(string logicalName, Guid entityId, Func<Times> times);

        /// <summary>
        /// Verify that the Retrieve method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(Times times);

        /// <summary>
        /// Verify that the Retrieve method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(string logicalName, Times times);

        /// <summary>
        /// Verify that the Retrieve method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieve(string logicalName, Guid entityId, Times times);

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple(Func<Times> times);

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple(string logicalName, Func<Times> times);

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple(Times times);

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple(string logicalName, Times times);

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called satisfying the given predicate
        /// </summary>
        /// <typeparam name="TQuery">The type of <see cref="QueryBase"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Func<Times> times)
            where TQuery : QueryBase;

        /// <summary>
        /// Verify that the RetrieveMultiple method has been called satisfying the given predicate
        /// </summary>
        /// <typeparam name="TQuery">The type of <see cref="QueryBase"/> to be intercepted</typeparam>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyRetrieveMultiple<TQuery>(Expression<Func<TQuery, bool>> match, Times times)
            where TQuery : QueryBase;

        /// <summary>
        /// Verify that the Update method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(Func<Times> times);

        /// <summary>
        /// Verify that the Update method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(string logicalName, Func<Times> times);

        /// <summary>
        /// Verify that the Update method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(string logicalName, Guid entityId, Func<Times> times);

        /// <summary>
        /// Verify that the Update method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(Times times);

        /// <summary>
        /// Verify that the Update method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(string logicalName, Times times);

        /// <summary>
        /// Verify that the Update method has been called with the specified arguments
        /// </summary>
        /// <param name="logicalName">A logical name to filter against</param>
        /// <param name="entityId">An entity id to filter against</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(string logicalName, Guid entityId, Times times);

        /// <summary>
        /// Verify that the Update method has been called satisfying the given predicate
        /// </summary>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(Expression<Func<Entity, bool>> match, Func<Times> times);

        /// <summary>
        /// Verify that the Update method has been called satisfying the given predicate
        /// </summary>
        /// <param name="match">Matches any value that satisfies the given predicate</param>
        /// <param name="times">The number of times the method was called</param>
        void VerifyUpdate(Expression<Func<Entity, bool>> match, Times times);
    }
}