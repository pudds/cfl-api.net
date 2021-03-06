﻿using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IInterceptionsLeadersRequestBuilder : ILeadersRequestBuilder<IInterceptionsLeadersRequestBuilder, IList<Offence>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IInterceptionsLeadersRequestBuilder>>,
		IExtendedDataAvailable<IInterceptionsLeadersRequestBuilder>
	{

	}
}
