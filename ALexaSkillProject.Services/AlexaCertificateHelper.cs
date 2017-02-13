﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSkillProject.Services
{
    public static class AlexaCertificateHelper
    {
        public const string VERSION = "1.0";
        public const string CHARACTER_ENCODING = "UTF-8";
        public const string ECHO_API_DOMAIN_NAME = "echo-api.amazon.com";
        public const string SIGNATURE_CERT_URL_REQUEST_HEADER = "SignatureCertChainUrl";
        public const string SIGNATURE_CERT_URL_HOST = "s3.amazonaws.com";
        public const string SIGNATURE_CERT_URL_PATH = "/echo.api/";
        public const string SIGNATURE_CERT_TYPE = "X.509";
        public const string SIGNATURE_REQUEST_HEADER = "Signature";
        public const string SIGNATURE_ALGORITHM = "SHA1withRSA";
        public const string SIGNATURE_KEY_TYPE = "RSA";
        public const int TIMESTAMP_TOLERANCE_SEC = 150;

        public static JsonSerializerSettings DeserializationSettings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
    }
}
