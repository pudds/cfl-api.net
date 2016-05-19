﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class SeasonPassing : Passing
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty(PropertyName = "season")]
		public int Season { get; set; }

		[JsonProperty(PropertyName = "team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty(PropertyName = "games_played")]
		public int GamesPlayed { get; set; }
	}
}
