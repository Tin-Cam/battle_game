public interface ICharacter {
    int maxHealth { get; }
    int currentHealth { get; }

    void TakeDamage(float value);
}