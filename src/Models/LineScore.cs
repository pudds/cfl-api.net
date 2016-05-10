﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class LineScore
	{
		[JsonProperty(PropertyName = "quarter")]
		public int Quarter { get; set; }

		[JsonProperty(PropertyName = "score")]
		public int Score { get; set; }

	}
}
