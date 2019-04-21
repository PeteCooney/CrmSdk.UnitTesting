// <copyright file="SampleWorkflow.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace CrmSdk.UnitTesting.Examples
{
    using System;
    using System.Activities;

    /// <summary>
    /// Sample workflow activity to demonstrate unit testing
    /// </summary>
    public class SampleWorkflow : CodeActivity
    {
        /// <inheritdoc />
        protected override void Execute(CodeActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
