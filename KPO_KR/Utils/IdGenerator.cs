public class IdGenerator
{
    private static readonly Dictionary<Type, int> _idCounters = new();

    public static int GetNextId<T>()
    {
        Type type = typeof(T);
        if (!_idCounters.ContainsKey(type))
        {
            _idCounters[type] = 1;
        }
        return _idCounters[type]++;
    }

    public static bool CheckId<T>(int id)
    {
        Type type = typeof(T);
        return id > 0 && id <= _idCounters[type];
    }
}