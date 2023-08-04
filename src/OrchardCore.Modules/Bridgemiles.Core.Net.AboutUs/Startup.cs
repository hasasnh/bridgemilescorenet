using System;
using Bridgemiles.Core.Net.AboutUs.Drivers;
using Fluid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Modules;

namespace Bridgemiles.Core.Net.AboutUs
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services
                   .AddContentPart<Bridgemiles.Core.Net.AboutUs.Models.AboutUsStory>()
                   .UseDisplayDriver<AboutUsStoryDisplayDriver>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "Bridgemiles.Core.Net.AboutUs",
                pattern: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
