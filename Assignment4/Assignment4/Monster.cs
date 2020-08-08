using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType ElementType { get; private set; }
        public int Health { get; private set; }
        public int AttackStat { get; private set; }
        public int DefenseStat { get; private set; }

        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }

        public void TakeDamage(int amount)
        {
            if ((Health - amount) < 0)
            {
                Health = 0;
            }
            else
            {
                Health -= amount;
            }
        }

        public void Attack(Monster otherMonster)
        {
            int basicDamage = AttackStat - otherMonster.DefenseStat;
            if (basicDamage <= 1)
            {
                basicDamage = 1;
                otherMonster.TakeDamage(basicDamage);
                return;
            }
            int counter = ElementType.GetCounter(otherMonster.ElementType);

            if (counter == 1)
            {
                otherMonster.TakeDamage((int)(basicDamage * 1.5));
            }
            else if (counter == 0)
            {
                otherMonster.TakeDamage((int)(basicDamage * 0.5));
            }
            else if (counter == -1)
            {
                otherMonster.TakeDamage(basicDamage);
            }
        }
    }
}
