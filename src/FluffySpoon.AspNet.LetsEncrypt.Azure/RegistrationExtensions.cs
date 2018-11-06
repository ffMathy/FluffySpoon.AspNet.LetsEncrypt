﻿using FluffySpoon.LetsEncrypt.Azure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FluffySpoon.AspNet.LetsEncrypt
{
	public static class RegistrationExtensions
	{
		public static void AddFluffySpoonLetsEncryptAzureAppServiceSslBindingCertificatePersistence(
			this IServiceCollection services,
			AzureOptions azureOptions)
		{
			services.AddFluffySpoonLetsEncryptCertificatePersistence(
				(provider) => new AzureAppServiceSslBindingCertificatePersistenceStrategy(
					azureOptions, 
					provider.GetRequiredService<ILogger<AzureAppServiceSslBindingCertificatePersistenceStrategy>>()));
		}
	}
}