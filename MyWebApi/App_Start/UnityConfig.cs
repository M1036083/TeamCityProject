using Microsoft.Practices.Unity;
using MyWebApi.DataAccessRepository;
using MyWebApi.Models;
using System.Web.Http;
using Unity.WebApi;

namespace MyWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDataAccessRepository<EmployeeInfo, int>, clsDataAccessRepository>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}