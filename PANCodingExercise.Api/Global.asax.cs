using Autofac;
using Autofac.Integration.WebApi;
using PANCodingExercise.Data;
using PANCodingExercise.Data.Contracts;
using PANCodingExercise.Services;
using PANCodingExercise.Services.Contracts;
using System.Reflection;
using System.Web.Http;

namespace PANCodingExercise
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.Register<IDbContext>(c => new ItemDbContext());

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            builder.RegisterType<ItemService>().As<IItemService>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
