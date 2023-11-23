using Castle.Windsor;
using ControleAcces;
using ControleAcces.Application;
using ControleAcces.Sqlite;

var container = new WindsorContainer();
container.Install(new ControleAccesInstaller(), new SqliteDataStorageInstaller());

var badgeRepository = container.Resolve<BadgeRepository>();
badgeRepository.RécupérerLeNuméro(800);

// Reste à jouer avec !
