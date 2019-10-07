﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityPUBG.Scripts.Items
{
    public abstract class Weapon : Item
    {
        public Weapon(string name, ItemRarity rarity, float damage, float attackSpeed, float attackRange, float knockbackPower) : base(name, rarity)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
            AttackRange = attackRange;
            KnockbackPower = knockbackPower;
        }

        public float Damage { get; private set; }
        public float AttackSpeed { get; private set; }
        public float AttackRange { get; private set; }
        public float KnockbackPower { get; private set; }
    }
}
