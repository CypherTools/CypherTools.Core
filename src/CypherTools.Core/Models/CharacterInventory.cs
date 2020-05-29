﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.Core.Models
{
    public class CharacterInventory
    {
        public int InventoryId { get; set; }
        public int CharacterId { get; set; }
        public string ItemName { get; set; }
        public int Qty { get; set; }

        public Character Character { get; set; }
    }
}
