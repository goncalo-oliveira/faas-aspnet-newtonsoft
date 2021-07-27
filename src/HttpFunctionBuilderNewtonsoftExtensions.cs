using System;
using Microsoft.AspNetCore.Mvc;
using OpenFaaS;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class HttpFunctionBuilderNewtonsoftExtensions
    {
        /// <summary>
        /// Configures Newtonsoft.Json specific features such as input and output formatters
        /// </summary>
        /// <returns>The OpenFaaS.IHttpFunctionBuilder instance</returns>
        public static IHttpFunctionBuilder AddNewtonsoftJson( this IHttpFunctionBuilder builder )
        {
            var mvcBuilder = new MvcBuilder( builder );

            mvcBuilder.AddNewtonsoftJson();

            return ( builder );
        }

        /// <summary>
        /// Configures Newtonsoft.Json specific features such as input and output formatters
        /// </summary>
        /// <param name="configure">Callback to configure Microsoft.AspNetCore.Mvc.MvcNewtonsoftJsonOptions</param>
        /// <returns>The OpenFaaS.IHttpFunctionBuilder instance</returns>
        public static IHttpFunctionBuilder AddNewtonsoftJson( this IHttpFunctionBuilder builder, Action<MvcNewtonsoftJsonOptions> configure )
        {
            var mvcBuilder = new MvcBuilder( builder );

            mvcBuilder.AddNewtonsoftJson( configure );

            return ( builder );
        }
    }
}
