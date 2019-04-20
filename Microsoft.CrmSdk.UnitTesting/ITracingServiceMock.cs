// <copyright file="ITracingServiceMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// Interface describing a mocked instance of <seealso cref="ITracingService"/>
    /// </summary>
    public interface ITracingServiceMock : IMock<ITracingService>
    {
        /// <summary>
        /// Verify that the Trace method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyTrace(Times times);

        /// <summary>
        /// Verify that the Trace method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyTrace(Func<Times> times);
    }
}
