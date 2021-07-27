using System;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;

namespace OpenFaaS
{
    internal class MvcBuilder : IMvcBuilder
    {
        public MvcBuilder( IHttpFunctionBuilder builder )
        {
            Services = builder.Services;
        }

        public IServiceCollection Services { get; }

        public ApplicationPartManager PartManager => throw new NotImplementedException();
    }
}
