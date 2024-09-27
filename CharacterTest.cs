

namespace SpelProject
{
    public interface ICharacter
    {
        public void Attack();
    }

    public class Player : ICharacter
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Player(int health, int attackPower)
        {
            Health = health;
            AttackPower = attackPower;
        }

        public void Attack()
        {
            Console.WriteLine($"You have attacked the enemy for {AttackPower} health");
        }

        public void Heal()
        {
            int healAmount = new Random().Next(1, 11);
            Health += healAmount;
            Console.WriteLine($"Player heals for {healAmount} health.");
        }
        
    }

    public class Enemy : ICharacter
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Enemy(int health, int attackPower)
        {
            Health = health;
            AttackPower = attackPower;
        }

        public void Attack()
        {
            Console.WriteLine($"You have been attacked for {AttackPower} health");
        }
    } 
}
