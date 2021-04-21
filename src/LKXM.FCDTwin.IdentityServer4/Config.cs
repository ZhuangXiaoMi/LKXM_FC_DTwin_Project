using IdentityServer4.Models;
using System.Collections.Generic;

namespace LKXM.FCDTwin.IdentityServer4
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api")
            };
        }

        /// <summary>
        /// 微服务API资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("webapi", "LKXM.FCDTwin.WebApi")
                {
                    ApiSecrets = { new Secret("secret".Sha256()) },
                    Scopes = { "api" }
                },
                new ApiResource("aggregate", "LKXM.FCDTwin.Aggregate")
                {
                    ApiSecrets = { new Secret("secret".Sha256()) },
                    Scopes = { "api" }
                },
                new ApiResource("collect", "LKXM.FCDTwin.Collect")
                {
                    ApiSecrets = { new Secret("secret".Sha256()) },
                    Scopes = { "api" }
                }
            };
        }

        /// <summary>
        /// 客户端
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "LKXM.FCDTwin.Blazor",
                    ClientName = "PC端",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    //客户端有权访问的范围
                    AllowedScopes = { "api" },
                    AccessTokenLifetime = 75
                },
                new Client
                {
                    ClientId = "LKXM.FCDTwin.WebApi",
                    ClientName = "WebApi",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    //客户端有权访问的范围
                    AllowedScopes = { "api" },
                    AccessTokenLifetime = 75
                }
            };
        }
    }
}
