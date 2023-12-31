﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ControleAcces.Port;

namespace ControleAcces.Test.Utilities;

internal class TestUtilitiesInstaller : IWindsorInstaller
{
    /// <inheritdoc />
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(Component.For<BadgeBuilder>().LifestyleTransient());

        #if INTEGRATION
        container.Install(new SqliteDataStorageInstaller());
        #else
        container.Register(Component.For<IDataStorage>().ImplementedBy<FakeDataStorage>().LifestyleTransient());
        #endif
    }
}