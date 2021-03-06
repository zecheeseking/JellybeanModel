﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public interface Turret
    {
        #region Properties
        AgentState State
        {
            get;
            set;
        }

        int Row
        {
            get;
            set;
        }

        int Column
        {
            get;
            set;
        }

        AreaOfEffect AreaOfEffect
        {
            get;
        }

        float CooldownTime
        {
            get;
            set;
        }

        int Cost
        {
            get;
        }

        float FireRate
        {
            get;
        }

        int CurrentAmmo
        {
            get;
            set;
        }

        int AttackDamage
        {
            get;
            set;
        }

        int Health
        {
            get;
            set;
        }
        #endregion

        void Attack(List<Agent> potentialTargets);

        void Die();
    }
}
