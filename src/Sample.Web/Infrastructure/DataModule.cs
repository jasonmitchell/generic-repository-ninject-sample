using Ninject.Modules;
using Ninject.Web.Common;
using Sample.Web.Data;

namespace Sample.Web.Infrastructure
{
    public class DataModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<SampleDataContext>().ToSelf().InRequestScope(); //.WithConstructorArgument("connectionString", ConfigurationManager.ConnectionStrings["SampleDataContext"].ConnectionString);
            Bind<IRepository>().To<EntityFrameworkRepository>().InRequestScope();
        }
    }
}