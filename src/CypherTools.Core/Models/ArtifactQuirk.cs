using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.Core.Models
{
	public class ArtifactQuirk
	{
		public int ArtifactQuirkId { get; set; }
		public int StartRange { get; set; }
		public int EndRange { get; set; }
		public string Quirk { get; set; }

		public string Source { get; set; }
		public string Ruleset { get; set; }
	}
}
