using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysticMathsGame__Divan_Gomm.Interface;
using MysticMathsGame__Divan_Gomm.Enums;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the Attack Class of Mystic Math Game.
It represents a single type of attack in the game.
It stores the attack name, damage, type, amd a delegate to determine if the attack can hit a target.
*/


namespace MysticMathsGame__Divan_Gomm.Classes
{
    public class Attack
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public AttackType Type { get; set; }

        public Func<IEnemy, bool > CanHit { get; set; }

        //constructor for attack
        public Attack(string name, int damage, AttackType type, Func<IEnemy, bool> canHit)
        {
            Name = name;
            Damage = damage;
            Type = type;
            CanHit = canHit;

        } 
        
      


    }
}
