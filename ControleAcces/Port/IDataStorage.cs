namespace ControleAcces.Port;

public interface IDataStorage
{
    void StoreBadge(int numéroSérie);
    bool BadgeExists(int numéroSérie);
}