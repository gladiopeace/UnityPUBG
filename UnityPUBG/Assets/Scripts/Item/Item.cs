﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityPUBG.Scripts.Items
{
    public abstract class Item : ScriptableObject
    {
        [SerializeField] private string itemName;
        [SerializeField] private ItemRarity rarity;
        [SerializeField] private GameObject model;

        protected Item(string itemName, ItemRarity rarity)
        {
            this.itemName = itemName ?? throw new ArgumentNullException(nameof(itemName));
            this.rarity = rarity;
        }

        public string ItemName => itemName;
        public ItemRarity Rarity => rarity;
        public GameObject Model => model;
    }
}