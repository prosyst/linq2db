using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace LinqToDB.DataProvider.PostgreSQL
{
	using Configuration;

	[UsedImplicitly]
	public class PostgreSQLFactory: IDataProviderFactory
	{
		IDataProvider IDataProviderFactory.GetDataProvider(IEnumerable<NamedValue> attributes)
		{
			return new PostgreSQLDataProvider();
		}
	}
}
