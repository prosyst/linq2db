using System.Collections.Generic;

using JetBrains.Annotations;

namespace LinqToDB.DataProvider.MySql
{
	using Configuration;

	[UsedImplicitly]
	public class MySqlFactory : IDataProviderFactory
	{
		IDataProvider IDataProviderFactory.GetDataProvider(IEnumerable<NamedValue> attributes)
		{
			return MySqlTools.GetDataProvider();
		}
	}
}
