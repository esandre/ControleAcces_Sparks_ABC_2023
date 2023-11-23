using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ControleAcces.Application;

namespace ControleAcces;

public class ControleAccesInstaller : IWindsorInstaller
{
    /// <inheritdoc />
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(Component.For<BadgeFactory>());
        container.Register(Component.For<BadgeRepository>());
    }
}