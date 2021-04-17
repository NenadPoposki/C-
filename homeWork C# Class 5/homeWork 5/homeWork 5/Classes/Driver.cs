﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_5.Classes
{
    public class Driver
    {
        public string Name { get; set; }
        private int _skill { get; set; }
        public int skill
        {
            get { return _skill; }
            set { _skill = value; }
        }

        public int Skill { get; internal set; }

        public Driver(string name, int skill)
        {
            Name = name;
            _skill = skill;
        }
    }
}
