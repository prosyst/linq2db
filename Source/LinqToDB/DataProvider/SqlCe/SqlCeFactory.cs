﻿using JetBrains.Annotations;

namespace LinqToDB.DataProvider.SqlCe
{
	using System.Collections.Generic;
	using Configuration;

	[UsedImplicitly]
	public class SqlCeFactory : IDataProviderFactory
	{
		IDataProvider IDataProviderFactory.GetDataProvider(IEnumerable<NamedValue> attributes)
		{
			return SqlCeTools.GetDataProvider();
		}
	}
}
