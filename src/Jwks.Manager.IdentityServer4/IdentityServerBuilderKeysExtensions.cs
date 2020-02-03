using IdentityServer4.Stores;
using Jwks.Manager.IdentityServer4;
using Jwks.Manager.Interfaces;
using Jwks.Manager.Jwk;
using Jwks.Manager.Jwks;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Builder extension methods for registering crypto services
    /// </summary>
    public static class IdentityServerBuilderKeysExtensions
    {
        /// <summary>
        /// Sets the signing credential.
        /// </summary>
        /// <returns></returns>
        public static IJwksBuilder IdentityServer4AutoJwksManager(this IJwksBuilder builder)
        {

            builder.Services.AddScoped<IJsonWebKeyService, JwkService>();
            builder.Services.AddScoped<IJsonWebKeySetService, JwksService>();
            builder.Services.AddScoped<ISigningCredentialStore, IdentityServer4KeyStore>();
            builder.Services.AddScoped<IValidationKeysStore, IdentityServer4KeyStore>();

            return builder;
        }
    }
}