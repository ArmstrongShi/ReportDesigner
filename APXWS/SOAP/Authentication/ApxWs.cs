﻿using System;

namespace Advent.ApxSoap.ApxWS
{
    public partial class ApxWS : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public string AccessToken
        {
            get;
            set;
        }

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            var request = base.GetWebRequest(uri);
            request.Headers.Add("Authorization", $"Bearer {AccessToken}");
            return request;
        }
    }
}
