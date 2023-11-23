using Castle.Windsor;

namespace ControleAcces.Test.Utilities;

public interface IFunctionalTest
{
    BadgeBuilder BadgeBuilder { get; }
}

// ReSharper disable once ClassNeverInstantiated.Global
public class FunctionalTestFixture : IFunctionalTest
{
    private readonly WindsorContainer _container;

    public BadgeBuilder BadgeBuilder => _container.Resolve<BadgeBuilder>();

    public FunctionalTestFixture()
    {
        var container = new WindsorContainer();
        container.Install(new ControleAccesInstaller(), new TestUtilitiesInstaller());
        _container = container;
    }
}