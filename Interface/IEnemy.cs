using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysticMathsGame__Divan_Gomm.Interface;
using MysticMathsGame__Divan_Gomm.Enums;
using MysticMathsGame__Divan_Gomm.Classes;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the IEnemy interface.
It defines the required properties and methods that any enemy must implement.
Such as HP, name, taking damage, and checking if still alive.
*/



namespace MysticMathsGame__Divan_Gomm.Interface
{
    public interface IEnemy
    {
        string Name { get; set; }
        int HP { get; set; }
        EnemyWeakness Weakness { get; set; }

        void TakeDamage(int damage);

        bool IsAlive();


    }
}
