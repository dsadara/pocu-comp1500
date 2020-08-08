using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment4
{
    public class Arena
    {
        public uint Capacity { get; private set; }
        public string ArenaName { get; private set; }
        public uint Turns { get; private set; }
        public uint MonsterCount { get; private set; }
        public List<Monster> Monster;

        public Arena(string arenaName, uint capacity)
        {
            Capacity = capacity;
            ArenaName = arenaName;
        }

        public void LoadMonsters(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            string[] Lines = File.ReadAllLines(filePath);
            string[] tokens;
            if (Lines.Length > Capacity)
            {
                Monster = new List<Monster>();
                MonsterCount = Capacity;
            }
            else
            {
                Monster = new List<Monster>();
                MonsterCount = (uint)Lines.Length;
            }

            for (int i = 0; i < MonsterCount; i++)
            {
                tokens = Lines[i].Split(',');
                Monster.Add(new Monster(tokens[0], (EElementType)Enum.Parse(typeof(EElementType), tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]), int.Parse(tokens[4])));
            }
        }

        public void GoToNextTurn()
        {
            if (MonsterCount == 0)
            {
                return;
            }
            if (MonsterCount == 1)
            {
                return;
            }

            for (int i = 0; i < MonsterCount; i++)
            {
                Monster[i].Attack(Monster[(i + 1) % (int)MonsterCount]);
                if (Monster[(i + 1) % (int)MonsterCount].Health <= 0)
                {
                    Monster.RemoveAt((i + 1) % (int)MonsterCount);
                    MonsterCount--;
                }
            }
            Turns++;
        }

        public Monster GetHealthiest()
        {
            if (MonsterCount == 0)
            {
                return null;
            }
            int healthiestMonsterindex = 0;
            for (int i = 1; i < MonsterCount; i++)
            {
                if (Monster[healthiestMonsterindex].Health < Monster[i].Health)
                {
                    healthiestMonsterindex = i;
                }
            }
            return Monster[healthiestMonsterindex];
        }
    }
}
