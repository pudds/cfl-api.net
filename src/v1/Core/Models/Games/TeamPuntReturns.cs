﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class TeamPuntReturns : PuntReturns
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonIgnore]
		public int TeamId { get; set; }
	}
}
