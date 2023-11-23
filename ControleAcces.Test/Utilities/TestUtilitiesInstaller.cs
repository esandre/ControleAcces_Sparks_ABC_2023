using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ControleAcces.Test.Utilities;

internal class TestUtilitiesInstaller : IWindsorInstaller
{
    /// <inheritdoc />
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(Component.For<BadgeBuilder>().LifestyleTransient());
    }
}