using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
            builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();

            var proxyOptions = new ProxyGenerationOptions { Selector = new AspectInterceptorSelector() };

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(proxyOptions)
                .SingleInstance();
        }
    }
}
