public interface ICharacter
{
    string Name { get; }
    int Health { get; }
    void Attack(ICharacter target);
    void Defend(int damage);
}

public interface IItem
{
    string Name { get; }
    int AttackBonus { get; }
    int DefenseBonus { get; }
}
