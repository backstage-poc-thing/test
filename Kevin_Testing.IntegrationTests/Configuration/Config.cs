using Microsoft.Extensions.Configuration;

namespace kevin_testing.IntegrationTests.Configuration
{
    public static class Config
    {
        public static string BaseUrl => Configuration["BaseUrl"];

        private static readonly IConfigurationRoot Configuration = SetupConfiguration();

        private static IConfigurationRoot SetupConfiguration()
        {
            var builder = new ConfigurationBuilder();
            builder.AddEnvironmentVariables();
            return builder.Build();
        }
    }
}