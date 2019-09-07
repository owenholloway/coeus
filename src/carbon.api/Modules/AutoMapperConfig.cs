using Autofac;
using AutoMapper;
using carbon.core.domain.model.account;
using carbon.core.dtos.account;

namespace carbon.api.Modules
{
    public class AutoMapperConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(mp =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    /*
                     * Used to specify mapping configs
                     *
                     * Add further domain to dto configs in here
                     */
                    
                    cfg.CreateMap<CoreUser,CoreUserDto>();
                    
                    
                });

                return config.CreateMapper();

            }).As<IMapper>().SingleInstance();
            
        }
    }
}