﻿using System.Net.Http.Json;
using Alba;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SoftwareCenter.Tests.Vendors;

public class AddingAVendor
{

    [Fact]
    public async Task CanAddVendorAsync()
    {

        var host = await AlbaHost.For<Program>();
        await host.Scenario(api =>
        {
            api.Post.Json(new { }).ToUrl("/vendors");
            api.StatusCodeShouldBeOk();
        });
    }
}