using MicroRabbit.Infrastructure.bus;
using Microsoft.Extensions.DependencyInjection;
using MircroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            // DomainBus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
