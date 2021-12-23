namespace JTools
{
    public interface IDamageable
    {
        int Health { get; set; }
        int MaxHealth { get; set; }
        void TakeDamage(int dmg);
    }
}