﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.Core.Models.Abstractions
{
    interface IAbility
    {
        int Tier { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Source { get; set; }
    }
}
