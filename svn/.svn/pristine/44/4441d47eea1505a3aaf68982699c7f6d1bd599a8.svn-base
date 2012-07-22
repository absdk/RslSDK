using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using SoftwareGrid.BusinessLogic.Repositories.Context;

namespace SoftwareGrid
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private static Collection<ModuleBase> _modules;

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();

            //RegisterGlobalFilters(GlobalFilters.Filters);
            //RegisterRoutes(RouteTable.Routes);

            OnStart(new Action<ContainerBuilder>[] { RegisterServices, RegisterControllers, RegisterModelBinders, RegisterModelBinderProvider, RegisterConnectionString });
        }

        protected virtual void OnStart(params Action<ContainerBuilder>[] registerServices)
        {

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);

            RegisterRoutes(RouteTable.Routes);

            _modules = new Collection<ModuleBase>();
            RegisterModules(_modules);

            var containerBuilder = new ContainerBuilder();

            foreach (var register in registerServices)
                register(containerBuilder);

            foreach (var module in _modules)
            {
                module.RegisterComponents(containerBuilder);
                module.RegisterRoutes(RouteTable.Routes);
            }

            var container = containerBuilder.Build();

            var repositoryContextInitializers = container.Resolve<IEnumerable<IRepositoryContextInitializer>>();
            foreach (var item in repositoryContextInitializers)
                item.InitializeDatabase();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected virtual void RegisterServices(ContainerBuilder containerBuilder) { }

        protected virtual void RegisterModules(Collection<ModuleBase> modules)
        {
            modules.Add(new Module());
        }

        protected virtual void RegisterControllers(ContainerBuilder containerBuilder)
        {
            foreach (var module in _modules)
            {
                containerBuilder.RegisterControllers(module.GetType().Assembly);
            }

            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());
        }

        protected virtual void RegisterModelBinders(ContainerBuilder containerBuilder)
        {
            foreach (var module in _modules)
            {
                containerBuilder.RegisterModelBinders(module.GetType().Assembly);
            }

            containerBuilder.RegisterModelBinders(Assembly.GetExecutingAssembly());
        }

        protected virtual void RegisterModelBinderProvider(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModelBinderProvider();
        }

        protected virtual void RegisterConnectionString(ContainerBuilder containerBuilder)
        {
            containerBuilder.Register(
                container =>
                new ConnectionString(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString)).As
                <IConnectionString>();
        }
    }
}