﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGCharacterCreator.Models
{
    public class User
    {
        private List<Character> characters = new List<Character>();

        public int UserID { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Character> Characters { get { return characters; } }

    }
}
