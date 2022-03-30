using Azure.Core;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace LandingPage
{
    public static class ConfigurationExtension
    {
        public static IConfiguration BuildCustomConfiguration(this IConfiguration config)
        {
            var builtConfig = GetAppSettingsConfiguration();

            SecretClientOptions options = new()
            {
                Retry =
                {
                    Delay= TimeSpan.FromSeconds(2),
                    MaxDelay = TimeSpan.FromSeconds(16),
                    MaxRetries = 5,
                    Mode = RetryMode.Exponential
                 }
            };

            SecretClient secretClient = new(
                vaultUri: new Uri(builtConfig["KeyVault:Uri"]),
                credential: new DefaultAzureCredential(),
                options
            );

            config = new ConfigurationBuilder()
                .AddConfiguration(builtConfig)
                .AddAzureKeyVault(secretClient, new KeyFormatKeyVaultSecretManager())
                            .Build();

            return config;
        }

        private static IConfiguration GetAppSettingsConfiguration()
        {
            return new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"{AppContext.BaseDirectory}/appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }

    public class KeyFormatKeyVaultSecretManager : KeyVaultSecretManager
    {
        public override string GetKey(KeyVaultSecret secret)
        {
            return secret.Name.Replace("--", ":");
        }
    }
}
