﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Spaier.Recaptcha.Services
{
    public sealed class RecaptchaConfigurationHeaderProvider : IRecaptchaConfigurationProvider
    {
        private readonly string recaptchaConfigurationHeaderKey;

        public RecaptchaConfigurationHeaderProvider(IOptions<Options> options)
        {
            recaptchaConfigurationHeaderKey = options?.Value.HeaderKey ?? throw new ArgumentException(nameof(options));
        }

        public string GetRecaptchaConfigurationKey(HttpRequest request)
        {
            return request?.Headers[recaptchaConfigurationHeaderKey];
        }

        public sealed class Options
        {
            public string HeaderKey { get; set; } = RecaptchaDefaults.DefaultConfigurationHeaderKey;
        }
    }
}
