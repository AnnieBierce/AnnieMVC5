﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnnieMVC5.Startup))]
namespace AnnieMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
