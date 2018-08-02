﻿using System;

namespace Spaier.Recaptcha
{
    public class RecaptchaConfiguration
    {
        /// <summary>
        /// Back-end reCAPTCHA secret.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Type of a reCAPTCHA key.
        /// </summary>
        public RecaptchaSecretType SecretType { get; set; }

        public RecaptchaConfiguration() { }

        public RecaptchaConfiguration(string secret, RecaptchaSecretType secretType)
        {
            Secret = secret ?? throw new ArgumentNullException(nameof(secret));
            SecretType = Enum.IsDefined(typeof(RecaptchaSecretType), secretType)
                ? secretType : throw new ArgumentException(nameof(secretType));
        }
    }
}
