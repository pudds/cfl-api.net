﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.TeamLeaders
//{
//	public class TeamLeadersFilterCreator<TValue> :
//		FilterCreator<TValue>,
//		IEqualToFilter<TValue>,
//		INotEqualToFilter<TValue>,
//		IGreaterThanFilter<TValue>,
//		ILessThanFilter<TValue>,
//		IGreaterThanOrEqualToFilter<TValue>,
//		ILessThanOrEqualToFilter<TValue>
//	{
//		public TeamLeadersFilterCreator(string filterProperty)
//			: base(filterProperty)
//		{

//		}
//		public string EqualTo(TValue value)
//		{
//			return CreateEqualToFilter(value);
//		}

//		public string NotEqualTo(TValue value)
//		{
//			return CreateNotEqualToFilter(value);
//		}

//		public string GreaterThan(TValue value)
//		{
//			return CreateGreaterThanFilter(value);
//		}

//		public string LessThan(TValue value)
//		{
//			return CreateLessThanFilter(value);
//		}

//		public string GreaterThanOrEqualTo(TValue value)
//		{
//			return CreateGreaterThanOrEqualToFilter(value);
//		}

//		public string LessThanOrEqualTo(TValue value)
//		{
//			return CreateLessThanOrEqualToFilter(value);
//		}
//	}
//}