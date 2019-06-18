using Colony.Ants.Types;

namespace Colony.Ants
{
    interface IAnt
    {
        IAntType Type { get; }
        int MaxAge { get; }

        void Born();
        void Die();
    }
}
