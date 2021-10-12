using System;

namespace IocContainer.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; }
        public Type ImplementationType { get; set; }
        public object Implementation { get; set; }
        public ServiceLifetime ServiceLifetime { get; set; }

        public ServiceDescriptor(object implementation, ServiceLifetime serviceLifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            ServiceLifetime = serviceLifetime;
        }

        public ServiceDescriptor(Type serviceType, ServiceLifetime serviceLifetime)
        {
            ServiceType = serviceType;
            ServiceLifetime = serviceLifetime;
        }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime serviceLifetime)
        {
            ServiceType = serviceType;
            ServiceLifetime = serviceLifetime;
            ImplementationType = implementationType;
        }
    }
}
