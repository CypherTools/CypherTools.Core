using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.Core.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public Guid UserId { get; set; }
        public string Player { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }
        public int Effort { get; set; }
        public int XP { get; set; }

        public string Descriptor { get; set; }
        public string Type { get; set; }
        public string Focus { get; set; }

        //Pools
        public IList<CharacterPool> Pools { get; set; }

        public int RecoveryDie { get; set; }
        public int RecoveryMod { get; set; }
        public IList<CharacterRecoveryRoll> RecoveryRolls { get; set; }

        public IList<CharacterCypher> Cyphers { get; set; }
        public IList<CharacterInventory> Inventory { get; set; }
        public IList<CharacterAbility> Abilities { get; set; }
        public IList<CharacterArtifact> Artifacts { get; set; }

        public Character()
        {
            //set some defaults
            RecoveryRolls = new List<CharacterRecoveryRoll>();
            Cyphers = new List<CharacterCypher>();
            Inventory = new List<CharacterInventory>();
            Abilities = new List<CharacterAbility>();
            Artifacts = new List<CharacterArtifact>();
            Pools = new List<CharacterPool>();
        }
    }
}
