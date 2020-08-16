using Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Migrations.Seed
{
	public class BaseSeed
	{
		public static void SeedByEnum<TEnum>(Action<int, TEnum> action)
		{
			IEnumerable<TEnum> enums = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
			enums.ForEach(enumItem => action.Invoke(Convert.ToInt32(enumItem), enumItem));
		}
	}
}
