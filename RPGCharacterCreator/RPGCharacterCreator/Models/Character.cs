﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGCharacterCreator.Models
{
    public class Character
    {
        private List<string> abilities = new List<string>();
        public string charID { get; set; }

        public Character() { }
        public Character(string name, string gender, string species, string description)
        {
            Name = name;
            Gender = gender;
            Species = species;
            Description = description;
        }

        public bool IsMonster { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsNPC { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }

        public List<string> Abilities { get { return abilities; } }

    }
}