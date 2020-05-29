﻿using CypherTools.Core.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.Core.Models
{
    public class Artifact : IArtifact
    {
        private int _level { get; set; }
        public int ArtifactId { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Genre { get; set; }

        public int Level
        {
            get
            {
                if (_level == 0)
                {
                    _level = (LevelDie == 0 ? LevelBonus : new Random().Next(1, LevelDie) + LevelBonus);
                }
                return _level;
            }
            set { _level = value; }
        }
        public int LevelDie { get; set; }
        public int LevelBonus { get; set; }

        public string Effect { get; set; }
        public string Source { get; set; }
        public string Depletion { get; set; }
    }
}
