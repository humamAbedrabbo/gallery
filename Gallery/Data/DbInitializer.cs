using Gallery.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(GalleryContext context, IConfiguration config, IServiceProvider serviceProvider)
        {
            var initializer = new DbInitializer();
            await initializer.Seed(context, config, serviceProvider);
        }

        private async Task Seed(GalleryContext context, IConfiguration config, IServiceProvider serviceProvider)
        {
            context.Database.Migrate();

            // Get Identity registered services
            var um = serviceProvider.GetService<UserManager<AppUser>>();

        }
    }
}
