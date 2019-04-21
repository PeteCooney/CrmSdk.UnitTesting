// <copyright file="TracingServiceMock.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Moq;

    /// <summary>
    /// A mocked instance of <seealso cref="ITracingService"/>
    /// </summary>
    /// <seealso cref="ITracingServiceMock"/>
    public class TracingServiceMock : Mock<ITracingService>, ITracingServiceMock
    {
        /// <inheritdoc />
        public void VerifyTrace(Times times)
        {
            this.Verify(service => service.Trace(It.IsAny<string>(), It.IsAny<object[]>()), times);
        }

        /// <inheritdoc />
        public void VerifyTrace(Func<Times> times)
        {
            this.Verify(service => service.Trace(It.IsAny<string>(), It.IsAny<object[]>()), times);
        }
    }
}
