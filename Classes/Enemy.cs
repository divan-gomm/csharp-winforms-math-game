using MysticMathsGame__Divan_Gomm.Enums;
using MysticMathsGame__Divan_Gomm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the Enemy Class of Mystic Math Game.
It represents the enemy character in the game. 
The class stores the enemy name, enemy HP, enemy weakness and methods for damage and to check if enemy is alive.
*/


namespace MysticMathsGame__Divan_Gomm.Classes
{
    public class Enemy : IEnemy
    {
      public string Name { get; set; }
      public int HP { get; set; }
      public EnemyWeakness Weakness {get; set; }
         
        //constructor for enemy
        public Enemy(string name, int hp, EnemyWeakness weakness)
        {
            Name = name;
            HP = hp;
            Weakness = weakness;
        }

        //allow enemy to take damage
        public void TakeDamage(int damage)
        {
            HP -= damage;
            
            if(HP < 0) HP = 0;
        }

        //check if enemy is alive
        public bool IsAlive()
        {

            return HP > 0;

        }


    }
}
