using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Net;

namespace СlothingStore.API.Middleware
{
    public class AuthorizationMiddleware
    {
        readonly RequestDelegate _next;

        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var isApi = context.Request.Path.Value.StartsWith("/api/");

            if (isApi)
            {
                var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
                //var isPublic = endpoint?.Metadata.GetMetadata<PublicAttribute>();

                //if (isPublic == null)
                //{
                    // TODO: CHECK AUTHORIZATION

                    //if (!context.Request.Headers.TryGetValue("ApiKey", out var apiKey))
                    //{
                    //    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    //    return;
                    //}

                    //var admin = await AdminRepository.GetAdminByApiKey(apiKey, context.RequestAborted);

                    //if (admin == null)
                    //{
                    //    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    //    return;
                    //}

                    //var attribute = endpoint?.Metadata.GetMetadata<RoleAttribute>();

                    //var role = attribute?.Role ?? Models.EAdminRole.Founder;

                    //if (admin?.Role > role)
                    //{
                    //    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    //    return;
                    //}

                    //context.Items["Session"] = admin;

                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    return;
                //}
            }

            await _next(context);
        }
    }
}
