using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Security.Jwt.Core.Interfaces;

namespace NetDevPack.Security.Jwt.Store.EntityFrameworkCore
{
    /// <summary>
    /// Builder extension methods for registering crypto services
    /// </summary>
    public static class EFCoreServiceExtensions
    {
        /// <summary>
        /// Sets the signing credential.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="credential">The credential.</param>
        /// <returns></returns>
        public static IJwksBuilder PersistKeysToDatabaseStore<TContext>(this IJwksBuilder builder) where TContext : DbContext, ISecurityKeyContext
        {
            builder.Services.AddScoped<IJsonWebKeyStore, DatabaseJsonWebKeyStore<TContext>>();

            return builder;
        }
    }
}