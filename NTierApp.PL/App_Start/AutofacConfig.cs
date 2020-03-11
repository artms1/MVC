using Autofac;
using Autofac.Integration.Mvc;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using NTierApp.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NTierApp.PL
{
    public class AutofacConfig
    {
        public static void ConfigureContainer(string connectionString)
        {
            var builder = AutofacBuilder.GetBuilder(connectionString);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}
