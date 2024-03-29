﻿using DigitalLibraryApplication;
using DigitalLibraryApplication.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace DigitalLibraryIntegrationTests
{
    public class AudioBookServiceIntegrationTest
    {
        private readonly TestServer _server;
        public AudioBookServiceIntegrationTest()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
        }

    }
}
