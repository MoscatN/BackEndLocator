﻿using System.Net.Http.Headers;

namespace LocatorBackEnd
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
 
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
