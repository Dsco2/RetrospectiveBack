using Autofac;
using Business.Interfaces;
using Business.Services;
using Persistence.Repositories;

namespace IoC
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommentRepository>().As<ICommentRepository>();
            builder.RegisterType<CommentService>().As<ICommentService>();
        }
    }
}