using ControleAcces.Port;

namespace ControleAcces.Sqlite;

public class SqliteDataStorage : IDataStorage
{
    /// <inheritdoc />
    public void StoreBadge(int numéroSérie)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool BadgeExists(int numéroSérie)
    {
        throw new NotImplementedException();
    }
}