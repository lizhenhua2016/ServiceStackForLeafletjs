using Funq;
using ServiceStack;
using ServiceStack.Api.Swagger;
using ServiceStack.Auth;
using ServiceStack.Caching;
using ServiceStack.Data;
using ServiceStack.Logging;
using ServiceStack.Logging.Log4Net;
using ServiceStack.OrmLite;
using ServiceStack.Razor;
using ServiceStackForLeafletjs.ServiceInterface;
using System.Configuration;

namespace ServiceStackForLeafletjs
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("ServiceStackForLeafletjs", typeof(AdcdService).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            this.Plugins.Add(new RazorFormat());
            this.Plugins.Add(new CorsFeature(allowedMethods: "GET, POST"));
            this.Plugins.Add(new SwaggerFeature() { });

            this.Plugins.Add(new AuthFeature(() =>
                new AuthUserSession(),
                new IAuthProvider[] {
                new CredentialsAuthProvider(),
            }));
            this.Plugins.Add(new RegistrationFeature());

            LogManager.LogFactory = new Log4NetFactory(configureLog4Net: true);
            ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;

            var connectString = ConfigurationManager.ConnectionStrings["connectstring"].ConnectionString;
            var connFactory = new OrmLiteConnectionFactory(connectString);

            container.Register<IDbConnectionFactory>(c => connFactory);

            container.Register<ICacheClient>(new MemoryCacheClient());
            container.Register<ISessionFactory>(c => new SessionFactory(c.Resolve<ICacheClient>()));
            //container.Register<IUserAuthRepository>(new OrmLiteAuthRepository(connFactory) { UseDistinctRoleTables = true });
        }
    }
}