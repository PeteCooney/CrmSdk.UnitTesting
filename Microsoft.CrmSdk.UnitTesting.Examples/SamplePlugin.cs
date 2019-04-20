// <copyright file="SamplePlugin.cs" author="Peter Cooney">
//   Copyright © 2019 - Peter Cooney
// </copyright>

namespace Microsoft.CrmSdk.UnitTesting.Examples
{
    using System;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;

    /// <summary>
    /// Sample plugin step to demonstrate unit testing
    /// </summary>
    public class SamplePlugin : IPlugin
    {
        private ITracingService tracingService;
        private IPluginExecutionContext pluginContext;
        private IOrganizationService organizationService;

        /// <inheritdoc />
        public void Execute(IServiceProvider serviceProvider)
        {
            // Create and cache the tracing service
            this.tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            this.tracingService.Trace("SamplePlugin started");

            // Create and cache the plugin context
            this.pluginContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Create and cache the CRM service
            var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            this.organizationService = serviceFactory.CreateOrganizationService(this.pluginContext.UserId);

            if (this.pluginContext.InputParameters.Contains("Target") && this.pluginContext.InputParameters["Target"] is Entity)
            {
                var target = (Entity)this.pluginContext.InputParameters["Target"];

                // Retrieve the target record:
                var targetRecord = this.organizationService.Retrieve(target.LogicalName, target.Id, new ColumnSet(true));
            }
        }
    }
}
