using HumanResources.DataAccess.Model;
using HumanResources.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace HumanResources.WebApi.App_Start
{
    public static class DependencyConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            container.RegisterType<IRepository<Candidate>, CandidateRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepository<Employee>, EmployeeRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}