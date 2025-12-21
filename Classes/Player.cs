using MysticMathsGame__Divan_Gomm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the Player Class of Mystic Math Game.
It represents the player character in the game. 
It store the player name, current HP, methods to apply damage to the player and to check if the player is alive.
*/



namespace MysticMathsGame__Divan_Gomm.Classes
{
    public class Player
    {
        public string 
            Name { get; set; }
        public int 
            HP { get; set; }

        //constructor for player
        public Player(string name, int hp)
        {
            Name = name;
            HP = hp;
        }


         // Reduce player HP by the damage amount 
         public void TakeDamage(int damage)
        {
            HP -= damage;

            if (HP < 0) HP = 0;
        }

        // Returns true if the player is alive
        public bool IsAlive()
        {
            return HP > 0;
        }
                

    }
}
