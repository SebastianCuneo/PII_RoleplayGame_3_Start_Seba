public class Encounter : IEncounter
{
    private List<Hero> heroes;
    private List<Enemy> enemies;

    public Encounter(List<Hero> heroes, List<Enemy> enemies)
    {
        if (heroes.Count == 0 || enemies.Count == 0)
            throw new ArgumentException("An encounter must have at least one hero and one enemy.");
        this.heroes = heroes;
        this.enemies = enemies;
    }

    public void DoEncounter()
    {
        while (heroes.Any(hero => hero.Health > 0) && enemies.Any(enemy => enemy.Health > 0))
        {
            EnemiesAttack();
            HeroesAttack();
        }

        if (heroes.Any(hero => hero.Health > 0))
            Console.WriteLine("Heroes won the encounter!");
        else
            Console.WriteLine("Enemies won the encounter!");
    }

    private void EnemiesAttack()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].Health > 0)
            {
                Hero targetHero = heroes[i % heroes.Count];
                if (targetHero.Health > 0)
                {
                    targetHero.ReceiveAttack(enemy.AttackValue);
                }
            }
        }
    }

    private void HeroesAttack()
    {
        foreach (var hero in heroes)
        {
            if (hero.Health > 0)
            {
                foreach (var enemy in enemies)
                {
                    if (enemy.Health > 0)
                    {
                        enemy.ReceiveAttack(hero.AttackValue);
                        
                        if (enemy.Health <= 0)
                        {
                            hero.GainVictoryPoints(enemy.VictoryPoints);
                        }
                    }
                }
            }
        }
    }
}
