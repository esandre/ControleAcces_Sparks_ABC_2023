using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ControleAcces.Port;

namespace ControleAcces.Sqlite;

public class SqliteDataStorageInstaller : IWindsorInstaller
{
    /// <inheritdoc />
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(Component.For<IDataStorage>().ImplementedBy<SqliteDataStorage>());
    }
}